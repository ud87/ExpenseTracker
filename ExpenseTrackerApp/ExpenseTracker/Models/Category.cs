using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key] // Primary key for the category
        public int CategoryId { get; set; } // Unique identifier for the category

        [Column(TypeName = "nvarchar(50)")] // Specifies the column type in the database
        public string Title { get; set; } // Name of the category

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = ""; // Icon representing the category, default is an empty string

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense"; // for e.g. income, expense, etc, default is "Expense"
    }
}
