using Infastructure.Interface;
using Infastructure.Models;
using System.Collections.Generic;

namespace InfastructureService.Repositories
{
    public class LogRepository : IlogRepository
    {
        List<ReqestLogEntry> _cache = new List<ReqestLogEntry>();

        private readonly InfastructureUsers _context;

        public LogRepository(InfastructureUsers context)
        {
            _context = context;
        }

        public void Insert(ReqestLogEntry entry)
        {
            _cache.Add(entry);
        }
    }
}
