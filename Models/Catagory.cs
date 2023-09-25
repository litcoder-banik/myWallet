using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myWallet.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        [Required(ErrorMessage = "Catagory Name Required")]
        public string CatagoryName { get; set; }

        public string Icon { get; set; } = "";

        [Required(ErrorMessage = "Catagory Type Required")]
        public string Type { get; set; } = "Expense";
    }
}
