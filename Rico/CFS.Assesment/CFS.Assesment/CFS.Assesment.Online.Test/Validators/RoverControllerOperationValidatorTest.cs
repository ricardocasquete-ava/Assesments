using Beef.Test.NUnit;
using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using NUnit.Framework;
using System.Threading.Tasks;   

namespace CFS.Assesment.Online.Test.Validators
{
    [TestFixture]
    public class RoverControllerOperationValidatorTest : BaseValidatorsTest
    {
        [Test]
        public async Task Empty_Operations()
        {
            var operations = string.Empty;

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .CreateAndRunAsync<IValidator<string>, string>(operations);
        }

        [Test]
        public async Task Invalid_Operations()
        {
            var operations = "T";

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectErrorType(Beef.ErrorType.ValidationError)
               .CreateAndRunAsync<IValidator<string>, string>(operations);
        }

        [Test]
        public async Task Valid_Operations ()
        {
            var operations = "MLR";

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .CreateAndRunAsync<IValidator<string>, string>(operations);
        }
    }
}