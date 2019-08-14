using Infastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureService.Configuration
{
    public class RequestLogEntryConfiguration : IEntityTypeConfiguration<ReqestLogEntry>
    {
        public void Configure(EntityTypeBuilder<ReqestLogEntry> builder)
        {
            builder.ToTable("logs");
            builder.HasKey(_ => _.Id);
        }
    }
}
