using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expenses.Models
{
    public class Categories
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }


        required
        public string name
        { get; set; }


        required
        public DateTime created_at
        { get; set; }
    }
}
