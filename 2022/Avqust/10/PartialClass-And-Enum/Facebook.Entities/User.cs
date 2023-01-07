using System;

namespace Facebook.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public UserDocument Document { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class UserDocument
    {
        public string Number { get; set; }
        public string Serial { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
