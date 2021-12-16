using CFS.Assesment.Online.Business.Entities;
using System;
using System.Threading.Tasks;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;


namespace CFS.Assesment.Online.Business.Data
{   
    public partial class ReferenceDataData
    {
        private Task CardinalPositionGetAll_OnImplementation(RefDataNamespace.CardinalPositionCollection coll)
        {
            coll.Add(new CardinalPosition { Id = 1, Code = "N", Text = RefConst.CARDINAL_NORTH });
            coll.Add(new CardinalPosition { Id = 2, Code = "S", Text = RefConst.CARDINAL_SOUTH });
            coll.Add(new CardinalPosition { Id = 3, Code = "E", Text = RefConst.CARDINAL_EAST });
            coll.Add(new CardinalPosition { Id = 4, Code = "W", Text = RefConst.CARDINAL_WEST });

            return Task.FromResult(coll);
        }

        private Task RoverOperationGetAll_OnImplementation(RefDataNamespace.RoverOperationCollection coll)
        {
            coll.Add(new RoverOperation { Id = 1, Code = "L", Text = RefConst.OPERATION_LEFT });
            coll.Add(new RoverOperation { Id = 2, Code = "R", Text = RefConst.OPERATION_RIGHT });
            coll.Add(new RoverOperation { Id = 3, Code = "M", Text = RefConst.OPERATION_MOVE });

            return Task.FromResult(coll);
        }

        private Task UserContextGetAll_OnImplementation(RefDataNamespace.UserContextCollection coll)
        {
            coll.Add(new UserContext { Id = 1, Code = "Teen", Text = "Teen" });
            coll.Add(new UserContext { Id = 2, Code = "Retiree", Text = "Retiree" });
            coll.Add(new UserContext { Id = 3, Code = "Expat", Text = "Expat" });
            coll.Add(new UserContext { Id = 4, Code = "Other", Text = "Other" });
            coll.Add(new UserContext { Id = 5, Code = "Anything", Text = "Anything" });

            return Task.FromResult(coll);
        }
    }
}
