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
        public string AccountName { get; set; } = "Main Account";

        //CurrencyId
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
