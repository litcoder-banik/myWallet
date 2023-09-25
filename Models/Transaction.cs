using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace myWallet.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }

        [Required(ErrorMessage = "Amount Required")]
        public float Amount { get; set; }

        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;        
    }
}
