using Beef.RefData.Model;
using System.Collections.Generic;

namespace Beef.AspNetCore.Spa.Ref
{
    public class RefType
    {
        public string RefTypeName { get; set; }
        public List<RefItem> Values { get; set; }
    }

    public class RefItem
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public RefItem(ReferenceDataBaseInt32 refItem)
        {
            this.ID = refItem.Id;
            this.Code = refItem.Code;
            this.Description = refItem.Text;
        }
    }
}
