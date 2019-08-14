using Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Interface
{
    public interface IDataRepository
    {
        List<InfastructureUsers> GetUsers();
        List<InfastructureCard> GetCards(int userId);
        void AddNewCard(InfastructureCard card, int userId);
        void DeleteCard(int userId, int cardId);
        
    }
}
