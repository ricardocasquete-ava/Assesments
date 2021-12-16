using Beef.Test.NUnit;
using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using NUnit.Framework;
using System.Threading.Tasks;   

namespace CFS.Assesment.Online.Test.Validators
{
    [TestFixture]
    public class RoverPositionValidatorTest : BaseValidatorsTest
    {
        [Test]
        public async Task X_Negative ()
        {
            var position = new RoverPosition
            {
                XCoordinate = -1
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("X Coordinate must be greater than or equal to 0.", "Orientation is required.")
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }

        [Test]
        public async Task Y_Negative()
        {
            var position = new RoverPosition
            {
                YCoordinate = -1
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Y Coordinate must be greater than or equal to 0.", "Orientation is required.")
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }

        [Test]
        public async Task Missing_Orientation()
        {
            var position = new RoverPosition
            {
                XCoordinate = 5,
                YCoordinate = 5
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages( "Orientation is required.")
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }

        [Test]
        public async Task InValid_Orientation_ByCode()
        {
            var position = new RoverPosition
            {
                XCoordinate = 5,
                YCoordinate = 5,
                Orientation = new CardinalPosition { Id = 1, Code = "J" }
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .ExpectMessages("Orientation is invalid.")
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }

        [Test]
        public async Task InValid_Orientation_ById()
        {
            var position = new RoverPosition
            {
                XCoordinate = 5,
                YCoordinate = 5,
                Orientation = new CardinalPosition { Id = 0, Code = "N" }
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }

        [Test]
        public async Task Valid_Orientation()
        {
            var position = new RoverPosition
            {
                XCoordinate = 5,
                YCoordinate = 5,
                Orientation = new CardinalPosition { Id = 1, Code = "N" }
            };

            await ValidationTester.Test()
               .ConfigureServices(_testSetup!)
               .CreateAndRunAsync<IValidator<RoverPosition>, RoverPosition>(position);
        }
    }
}