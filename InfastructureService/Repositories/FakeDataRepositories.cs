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
        public void AddNewCard(InfastructureCard card, int userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCard(int userId, int cardId)
        {
            throw new NotImplementedException();
        }

        public List<InfastructureCard> GetCards(int userId)
        {
            throw new NotImplementedException();
        }

        public List<InfastructureUsers> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
