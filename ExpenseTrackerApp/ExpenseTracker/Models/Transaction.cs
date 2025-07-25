using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key] // Primary key for the transaction
        public int TransactionId { get; set; } //Unique identifier for the transaction

        //CategoryId
        public int CategoryId { get; set; } // Foreign key to the Category table
        public Category Category {get; set; } // Navigation property to the Category

        public int Amount { get; set; } // Amount of the transaction

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; } // Note or description of the transaction

        public DateTime Date { get; set; } = DateTime.Now; // Date of the transaction
    }
}
