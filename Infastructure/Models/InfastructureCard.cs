using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Models
{
    public class InfastructureCard
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public int NumberCard { get; set; }
        public decimal CardMoney { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        // Navigation property
        public InfastructureUsers User { get; set; }
    }
}
