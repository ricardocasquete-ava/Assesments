using Beef.Test.NUnit;
using CFS.Assesment.Online.Api;
using CFS.Assesment.Online.Common.Agents;
using CFS.Assesment.Online.Common.Entities;
using NUnit.Framework;
using System.Net;

namespace CFS.Assesment.Online.Test.Apis
{
    [TestFixture, NonParallelizable]
    public class RoverControllerTest
    {
        [Test, TestSetUp]
        public void ValidSingleMove_Forward()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "N" }
            };

            var operation = "M";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveOneAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Value.Position.XCoordinate);
            Assert.AreEqual(4, result.Value.Position.YCoordinate);
            Assert.AreEqual("N", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidMany_Test_1()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 1, YCoordinate = 2, Orientation = "N" }
            };

            var operation = "LMLMLMLMM";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveManyAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(1, result.Value.Position.XCoordinate);
            Assert.AreEqual(3, result.Value.Position.YCoordinate);
            Assert.AreEqual("N", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidMany_Test_2()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "E" }
            };

            var operation = "MMRMMRMRRM";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveManyAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(5, result.Value.Position.XCoordinate);
            Assert.AreEqual(1, result.Value.Position.YCoordinate);
            Assert.AreEqual("E", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidSingleMove_TurnLeft()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "N" }
            };

            var operation = "L";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveOneAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Value.Position.XCoordinate);
            Assert.AreEqual(3, result.Value.Position.YCoordinate);
            Assert.AreEqual("W", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidMany_TurnLeft()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "N" }
            };

            var operation = "LLL";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveManyAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Value.Position.XCoordinate);
            Assert.AreEqual(3, result.Value.Position.YCoordinate);
            Assert.AreEqual("E", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidSingleMove_TurnRight()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "N" }
            };

            var operation = "R";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveOneAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Value.Position.XCoordinate);
            Assert.AreEqual(3, result.Value.Position.YCoordinate);
            Assert.AreEqual("E", result.Value.Position.Orientation);
        }

        [Test, TestSetUp]
        public void ValidMany_TurnRight()
        {
            using var agentTester = AgentTester.CreateWaf<Startup>();

            // Get / Create an existing value.
            var roverController = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 3, YCoordinate = 3, Orientation = "N" }
            };

            var operation = "RRR";

            var result = agentTester.Test<RoverControllerAgent, RoverController>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.MoveManyAsync(roverController, operation));

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Value.Position.XCoordinate);
            Assert.AreEqual(3, result.Value.Position.YCoordinate);
            Assert.AreEqual("W", result.Value.Position.Orientation);
        }
    }
}
