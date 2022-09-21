using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3
{
    public class Customer
    {
        public Guid Id { get; set; } //Global unique identifier / 128 bit həcmi var
        //Example Guid data: 1F5G4N-4G5F4-651541561

        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + FatherName + " " + Email + " " + PhoneNumber;
        }
    }
}
