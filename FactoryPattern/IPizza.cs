using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IPizza 
    {
        public double Price { get; set; }
        public bool ToGo { get; set; }
        public void GetDetails();
    }
}
