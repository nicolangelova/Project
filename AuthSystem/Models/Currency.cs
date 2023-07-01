using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Name{ get; set; }
    }
}
