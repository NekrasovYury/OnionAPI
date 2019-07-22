using Domain.Interface;
using Domain.Models;
using DomainService.Maper;
using Infastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.DomainService
{
    public class DataService : IDataInterface
    {
        private readonly IDataRepository _dataRepository;

        public DataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IList<DomainCards> GetCard()
        {
            var a = _dataRepository.GetCard();
            return a.Select(_=>_.ToDomain()).ToList(); 
        }

        public DomainCards GetCard(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
