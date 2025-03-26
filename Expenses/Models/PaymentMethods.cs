using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Expenses.Models
{
    public class PaymentMethods
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int method_id { get; set; }

        [Required]
        public required string  name { get; set; }

        [Required]
        public DateTime created_at
        { get; set; }
    }
}
