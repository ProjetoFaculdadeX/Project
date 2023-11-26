using Projeto1.Back;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.ConnectionDB
{
    public class SolicitacaoMap : EntityTypeConfiguration<Solicitacao>
    {
        public SolicitacaoMap()
        {
            ToTable("dbo.Solicitacao");
            //Chave Primaria
            HasKey(x => x.Id);
            //Chave Estrangeira
             HasRequired(x => x.Estoque)
                .WithMany(s => s.Solicitacao)
                .HasForeignKey(x => x.IdEstoque)
                .WillCascadeOnDelete(false);
            Property(x => x.IdEstoque).IsRequired().HasColumnType("int");
            Property(x => x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Unit).IsRequired().HasColumnType("int");
            Property(x => x.IdDepartment).IsRequired();
            Property(x => x.Date_Created).IsRequired().HasColumnType("datetime");
            Property(x => x.Lote).IsRequired().HasColumnType("varchar").HasMaxLength(30).IsRequired();
           
        }

    }
}
