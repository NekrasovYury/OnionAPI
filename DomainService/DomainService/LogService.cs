using Domain.Interface;
using Domain.Models;
using Infastructure.Interface;

namespace DomainService.DomainService
{
    class LogService : ILogService
    {
        private readonly IlogRepository _LogRepository;
        public LogService(IlogRepository LogRepository)
        {
            _LogRepository = LogRepository;
        }

        public void LogRequest(RequestInfo requestInfo)
        {
            _LogRepository.Insert(new Infastructure.Models.ReqestLogEntry()
            {
                ClientIP = requestInfo.ClientIP,
                Controller = requestInfo.Controller,
                Request = requestInfo.Request
            });
        }
    }
}
