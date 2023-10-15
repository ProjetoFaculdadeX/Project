using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Back;

namespace Projeto1.ConnectionDB
{
    public class DeparmentMap : EntityTypeConfiguration<Deparment>
    {
        public DeparmentMap()
        {
            ToTable("Department");
            HasKey(x => x.IdDepartment);
            Property(x => x.Name).HasColumnName("Name_Deparment").HasColumnType("varchar").HasMaxLength(100);

        }
    }
}
