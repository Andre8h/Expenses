using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Expenses.Models
{
    public class Expense
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int expense_id { get; set; }

        [Required]
        public int amount { get; set; }

        [Required]
        public int category_id { get; set; }

        [Required]
        public int method_id { get; set; }

        [Required]
        public DateTime date
        { get; set; }

        [Required]
        public required string note { get; set; }

        [Required]
        public DateTime created_at
        { get; set; }
    }
}
