using System.ComponentModel.DataAnnotations;

namespace myWallet.Models
{
    public class UserCatagory
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
