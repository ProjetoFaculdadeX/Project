using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Back;

namespace Projeto1.ConnectionDB
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            ToTable("dbo.Estoque");
            HasKey(x => x.Id);
            Property(x => x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Unit).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Department).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Date_Created).IsRequired().HasColumnType("datetime");
            Property(x => x.Lote).IsRequired().HasColumnType("varchar").HasMaxLength(30).IsRequired();
            Property(x => x.Date_Updated).IsRequired().HasColumnType("datetime");
        }
    }
}
