﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Back;

namespace Projeto1.ConnectionDB
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=DESKTOP-AUL6F82;Initial Catalog=Projeto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }

        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Department> Deparments { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstoqueMap());
            modelBuilder.Configurations.Add(new DeparmentMap());
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new SolicitacaoMap());
        }
    }
}
