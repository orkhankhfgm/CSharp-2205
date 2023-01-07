using System;

namespace Facebook.Entities
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? EditDate { get; set; }
        public int? EditUserId { get; set; }

        public BaseClass(int id, DateTime createDate, int createUserId)
        {
            this.Id = id;
            this.CreateDate = createDate;
            this.CreateUserId = createUserId;
        }
    }
}
