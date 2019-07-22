using Domain.Models;
using Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Maper
{
    public static class InfastructureToDomainServiceMapper
    {
        public static DomainCards ToDomain(this InfastructureCard @this)
        {
            return new DomainCards
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
