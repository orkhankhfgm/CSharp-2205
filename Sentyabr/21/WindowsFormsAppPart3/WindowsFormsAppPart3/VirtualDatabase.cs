using System.Collections.Generic;

namespace WindowsFormsAppPart3
{
    public static class VirtualDatabase
    {
        public static List<Customer> Customers { get; set; }

        static VirtualDatabase()
        {
            Customers = new List<Customer>();
        }
    }
}
