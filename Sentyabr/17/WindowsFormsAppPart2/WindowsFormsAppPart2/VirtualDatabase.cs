using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User {
                Id = 1,
                Name = "Orxan",
                Surname = "Farajov",
                Username = "orkhanfarajov",
                Password = "orkhan123456"
            });

            Users.Add(new User
            {
                Id = 1,
                Name = "Ruslan",
                Surname = "Jafarov",
                Username = "ruslanjafarov",
                Password = "ruslan123456"
            });

            Users.Add(new User
            {
                Id = 1,
                Name = "Elmir",
                Surname = "Mammadov",
                Username = "elmirmammadov",
                Password = "elmir123456"
            });
        }
    }
}
