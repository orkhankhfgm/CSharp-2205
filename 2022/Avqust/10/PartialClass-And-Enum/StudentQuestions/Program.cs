using Facebook.Entities;
using System;

namespace StudentQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, DateTime.Now, 152, "Orkhan", "Farajov");

            UserDocument userDoc = new UserDocument()
            {
                Serial = "AA",
                Number = "123456",
                ExpiryDate = new DateTime(2025, 12, 01),
                IssueDate = new DateTime(2019, 12, 01)
            };

            DateTime dob = new DateTime(1995, 12, 24);

            User user = new User();
            user.Id = 1;
            user.Name = "Orkhan";
            user.Surname = "Farajov";
            user.Document = userDoc;
            user.DateOfBirth = dob;



            var docNumberOfUser = user.Document.Number;
        }
    }
}
