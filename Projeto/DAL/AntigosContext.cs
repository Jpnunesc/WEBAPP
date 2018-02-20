using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Projeto.DAL
{
    public class AntigosContext : DbContext
    {
        public AntigosContext() : base("WebapiUp7app")
        { }

        public IDbSet<Login> Logins { get; set; }
        public IDbSet<Carro> Carros { get; set; }
        public IDbSet<Evento> Eventos { get; set; }
        public IDbSet<Ganhador> Ganhatores { get; set; }
        public IDbSet<Instituicao> Isntituicoes { get; set; }
        public IDbSet<Parceiro> Parceiros { get; set; }
        public IDbSet<Rifa> Rifas { get; set; }
        public IDbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Projeto.Models.Carro> Carroes { get; set; }
    }
}