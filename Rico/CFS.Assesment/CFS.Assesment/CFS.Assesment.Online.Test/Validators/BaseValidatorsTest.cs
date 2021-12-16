using Beef.Test.NUnit;
using Beef.Validation;
using CFS.Assesment.Online.Business;
using CFS.Assesment.Online.Business.Data;
using CFS.Assesment.Online.Business.DataSvc;
using CFS.Assesment.Online.Business.Entities;
using CFS.Assesment.Online.Business.Validation;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Test.Validators
{
    public class BaseValidatorsTest
    {
        protected Func<IServiceCollection, IServiceCollection>? _testSetup;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var rd = new Mock<IReferenceDataData>();

            rd.Setup(x => x.RoverOperationGetAllAsync()).ReturnsAsync(new RoverOperationCollection { 
                new RoverOperation { Id = 1, Code = "L", Text = RefConst.OPERATION_LEFT }, 
                new RoverOperation { Id = 2, Code = "R", Text = RefConst.OPERATION_RIGHT }, 
                new RoverOperation { Id = 3, Code = "M", Text = RefConst.OPERATION_MOVE } 
            });

            rd.Setup(x => x.CardinalPositionGetAllAsync()).ReturnsAsync(new CardinalPositionCollection {
                new CardinalPosition { Id = 1, Code = "N", Text = RefConst.CARDINAL_NORTH },
                new CardinalPosition { Id = 2, Code = "S", Text = RefConst.CARDINAL_SOUTH },
                new CardinalPosition { Id = 3, Code = "E", Text = RefConst.CARDINAL_EAST },
                new CardinalPosition { Id = 4, Code = "W", Text = RefConst.CARDINAL_WEST }
            });

            _testSetup = sc => sc
                .AddGeneratedValidationServices()
                .AddGeneratedValidationManualServices()
                .AddGeneratedReferenceDataManagerServices()
                .AddGeneratedReferenceDataDataSvcServices()
                .AddScoped(_ => rd.Object);
        }
    }
}
