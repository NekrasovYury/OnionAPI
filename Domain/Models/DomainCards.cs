using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DomainCards
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public int NumberCard { get; set; }
        public decimal CardMoney { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        // Navigation property
        public DomainUsers User { get; set; }
    }
}
