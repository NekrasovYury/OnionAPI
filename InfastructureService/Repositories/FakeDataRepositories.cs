using Infastructure.Interface;
using Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureService.Repositories
{
    public class FakeDataRepositories : IDataRepository
    {
        List<InfastructureUsers> users = new List<InfastructureUsers>() {
        new InfastructureUsers() { Id = 1, Name = "Yura" },
        new InfastructureUsers() { Id = 2, Name = "Vasia" },
        new InfastructureUsers() { Id = 3, Name = "Marina" },
        };

        List<InfastructureCard> cards = new List<InfastructureCard>()
        {
             new InfastructureCard()
                {
                    Id = 1,
                    CardName = "Platin",
                    NumberCard = 181231673,
                    UserId = 1,
                    CardMoney = 9.99M,
                },
                new InfastructureCard()
                {
                    Id = 2,
                    CardName = "gold",
                    NumberCard = 3918593,
                    UserId = 2,
                    CardMoney = 12.9M,
                },
                new InfastructureCard()
                {
                    Id = 3,
                    CardName = "Silver",
                    NumberCard = 39208133,
                    UserId = 1,
                    CardMoney = 1M,
                },
                new InfastructureCard()
                {
                    Id = 4,
                    CardName = "Platin",
                    NumberCard = 390194844,
                    UserId = 3,
                    CardMoney = 1999M,
                },
        };

            public IList<InfastructureCard> GetCard()
        {
            
            return cards;
        }
        //public List<InfastructureCard> GetCard()
        //{
        //    return cards;
        //}
        public InfastructureCard GetCard(int Id)
        {
     
            
            return cards[Id];
        }

    }
}
