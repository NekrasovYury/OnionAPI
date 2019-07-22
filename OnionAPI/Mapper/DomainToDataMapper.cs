using Domain.Models;
using OnionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnionAPI.Mapper
{
    public static class DomainToDataMapper
    {
        public static CardModel ToData(this DomainCards @this)
        {
            return new CardModel
            {
                CardMoney = @this.CardMoney,
                CardName = @this.CardName,
                Id = @this.Id,
                NumberCard = @this.NumberCard,
                // User = @this.User,
                UserId = @this.UserId

            };
        }
    }
}