using Beef.Test.NUnit;
using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using NUnit.Framework;
using System.Threading.Tasks;   

namespace CFS.Assesment.Online.Test.Validators
{
    [TestFixture]
    public class PlateauValidatorTest : BaseValidatorsTest
    {
        [Test]
        public async Task Length_Negative ()
        {
            var plateau = new Plateau
            {
                Length = -1
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Length must be greater than or equal to 0.")
               .CreateAndRunAsync<IValidator<Plateau>, Plateau>(plateau);
        }

        [Test]
        public async Task Height_Negative()
        {
            var plateau = new Plateau
            {
                Height = -1
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Height must be greater than or equal to 0.")
               .CreateAndRunAsync<IValidator<Plateau>, Plateau>(plateau);
        }
    }
}