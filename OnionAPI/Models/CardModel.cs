using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnionAPI.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public int NumberCard { get; set; }
        public decimal CardMoney { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        // Navigation property
        public UserModel User { get; set; }
    }
}