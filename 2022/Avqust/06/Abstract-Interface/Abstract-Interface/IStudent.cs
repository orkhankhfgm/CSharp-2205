using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public interface IStudent : IBase
    {
        string Name { get; set; }
        string Surname { get; set; }
        void ShowStudentInfo();
        //int Age; //Interface cannot contains fields


        void Add(string name, string surname);
        void Update(int id, string name, string surname);
        void Delete(int id);
    }
}
