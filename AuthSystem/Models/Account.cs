using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Account name is required.")]
        public string AccountName { get; set; }

        //CurrencyId
        [Range(1, int.MaxValue, ErrorMessage = "Please select a currency.")]
        public int CurrencyId { get; set; }
        public Currency? Currency { get; set; }


        [NotMapped]
        public string? CurrencyText
        {
            get
            {
                return Currency == null ? "" : Currency.Name;
            }
        }

        
    }
}
