using InformacionLogsBots.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InformacionLogsBots.DataAccess.DataBase.Configurations
{
    internal sealed class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.IdTransaccion).HasMaxLength(100);
            builder.Property(p => p.Ambiente).HasMaxLength(30);
            builder.Property(p => p.Ip).HasMaxLength(40);
            builder.Property(p => p.Usuario).HasMaxLength(50);
            builder.Property(p => p.Tecnologia).HasMaxLength(30);
            builder.Property(p => p.Proceso).HasMaxLength(50);
            builder.Property(p => p.Proyecto).HasMaxLength(50);
            builder.Property(p => p.Level).HasMaxLength(50);
            builder.Property(p => p.ProcesoInterno).HasMaxLength(100);
        }
    }
}
