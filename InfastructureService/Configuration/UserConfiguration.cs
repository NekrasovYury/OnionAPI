using Infastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Users.InfrastructureServices.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<InfastructureUsers>
    {
        public void Configure(EntityTypeBuilder<InfastructureUsers> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(_ => _.Id);
        }
    }
}
