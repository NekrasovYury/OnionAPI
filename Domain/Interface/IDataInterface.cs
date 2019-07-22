using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IDataInterface
    {
        IList<DomainCards> GetCard();
        DomainCards GetCard(int userId);
    }
}
