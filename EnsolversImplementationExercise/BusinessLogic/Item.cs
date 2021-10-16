using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Item
    {
        public string Name { get; set; }


        public bool IsValidItemName()
        {
            return this.Name != null;
        }
    }
}
