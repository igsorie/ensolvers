using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        private const int NAME_MAX_LENGTH = 36;

        public Item()
        {
            this.Status = false;
        }

        public bool IsValidItemName()
        {
            return this.Name != null && this.Name.Length <= NAME_MAX_LENGTH;
        }

        public override bool Equals(object obj)
        {
            Item item = (Item)obj;
            return this.Name.Equals(item.Name);
        }
    }
}
