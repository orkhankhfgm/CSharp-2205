using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersionChanges
{
    public class Phone
    {
        #region Auto Property
        //Not auto prop.
        private string _brand;

        public string Brand
        { //bu yontem encapsulation ucun istifade oluna biler
            get { return _brand; }
            set { _brand = value; }
        }

        //Auto Property
        public string Model { get; set; }

        public const string SomeProp = "Some value";
        public string SomeAutoProp { get; } = SomeProp;
        #endregion
    }
}
