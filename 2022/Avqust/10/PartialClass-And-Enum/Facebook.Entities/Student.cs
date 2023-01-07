using System;

namespace Facebook.Entities
{
    public class Student : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //Passing parameters to base class constructor ->>>>  : base(param1, param2, param3)
        public Student(int id, DateTime createDate, int createUserId, string name, string surname) : base(id, createDate, createUserId)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
