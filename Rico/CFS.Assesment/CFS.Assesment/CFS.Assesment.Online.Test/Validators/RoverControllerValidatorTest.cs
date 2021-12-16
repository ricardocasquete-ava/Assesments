using Beef.Test.NUnit;
using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using NUnit.Framework;
using System.Threading.Tasks;   

namespace CFS.Assesment.Online.Test.Validators
{
    [TestFixture]
    public class RoverControllerValidatorTest : BaseValidatorsTest
    {
        [Test]
        public async Task EmptyValues ()
        {
            var controller = new RoverController
            {
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Plateau is required.")
               .ExpectMessages("Position is required.")
               .ExpectMessages("The Rover must be witin the Plateau must be equal to True.")
               .CreateAndRunAsync<IValidator<RoverController>, RoverController>(controller);
        }

        [Test]
        public async Task MissingOrientation ()
        {
            var controller = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 1, YCoordinate = 1 },
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Orientation is required.")
               .CreateAndRunAsync<IValidator<RoverController>, RoverController>(controller);
        }

        [Test]
        public async Task RoverOutOfPlateau()
        {
            var controller = new RoverController
            {
                Plateau = new Plateau { Height = 5, Length = 5 },
                Position = new RoverPosition { XCoordinate = 10, YCoordinate = 10, Orientation = new CardinalPosition { Id = 1, Code = "N" } },
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("The Rover must be witin the Plateau must be equal to True.")
               .CreateAndRunAsync<IValidator<RoverController>, RoverController>(controller);
        }
    }
}