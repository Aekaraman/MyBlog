namespace BlogInstance.DataAccess.Entities
{
    public class UserAndCategory
    {
        public int UserID { get; set; }
        public User User { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
