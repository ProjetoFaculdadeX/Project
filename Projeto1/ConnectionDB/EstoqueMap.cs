﻿using System;
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
            //Chave Primaria
            HasKey(x => x.Id);
            HasRequired(x => x.Department)
                .WithMany(s => s.estoque)
                .HasForeignKey(x => x.IdDepartment)
                .WillCascadeOnDelete(false);
            Property(x => x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Unit).IsRequired().HasColumnType("int");
            Property(x => x.IdDepartment).HasColumnType("int");
            Property(x => x.Date_Created).IsRequired().HasColumnType("datetime");
            Property(x => x.Lote).IsRequired().HasColumnType("varchar").HasMaxLength(30).IsRequired();
            Property(x => x.Date_Updated).IsRequired().HasColumnType("datetime");
        }
    }
}
