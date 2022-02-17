using System.Threading;
using System.Threading.Tasks;
using App.Singleton;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

namespace App.Tests.Singleton;

public class ServerTests
{
    private readonly ITestOutputHelper _output;

    public ServerTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Singleton_Should_Not_Change_Regardless_Of_Thread()
    {
        var id = Server.Instance.Id;

        var thread1 = new Task(() =>
        {
            var threadId = Server.Instance.Id;

            threadId.Should().Be(id);
        });

        var thread2 = new Task(() =>
        {
            var threadId = Server.Instance.Id;

            threadId.Should().Be(id);
        });

        thread1.Start();
        thread2.Start();

        Task.WaitAll(thread1, thread2);
    }

    [Fact]
    public void Singleton_Should_Keep_Track_Of_State_Globally()
    {
        var lockObject = new object();
        var userId = 0;

        var thread1 = new Task(() =>
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var initial = Server.Instance.ConnectedUsers;
            initial.Should().BeEmpty();

            Thread.Sleep(500);
            lock(lockObject) {
                // a bit higher sleep means this will run third
                _output.WriteLine($"[{threadId}] Testing...");
                var actual = Server.Instance.ConnectedUsers;
                actual.Should().HaveCount(1);
            }
        });

        var thread2 = new Task(() =>
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;

            lock(lockObject)
            {
                // this will run first
                _output.WriteLine($"[{threadId}] Registering...");
                userId = Server.Instance.Register();
            }

            Thread.Sleep(750);
            lock(lockObject) {
                // higher sleep means this will run third
                _output.WriteLine($"[{threadId}] Logging off...");
                Server.Instance.LogOff(userId);
            }
        });

        var thread3 = new Task(() =>
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;

            Thread.Sleep(250);
            lock(lockObject)
            {
                // smaller sleep means this will run second
                _output.WriteLine($"[{threadId}] Logging in...");
                Server.Instance.Login(userId);
            }

            Thread.Sleep(1000);
            lock(lockObject)
            {
                // highest sleep means this will run last
                _output.WriteLine($"[{threadId}] Retesting...");
                var actual = Server.Instance.ConnectedUsers;
                actual.Should().BeEmpty();
            }
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();

        Task.WaitAll(thread1, thread2, thread3);
    }
}