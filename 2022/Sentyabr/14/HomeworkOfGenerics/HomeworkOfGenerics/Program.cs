using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOfGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();

            //GenericRepository<int> integerRepository = new GenericRepository<int>();
        }
    }
}
