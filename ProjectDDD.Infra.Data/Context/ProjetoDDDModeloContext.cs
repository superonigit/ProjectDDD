using System.Data.Entity.ModelConfiguration.Conventions;
using ProjectDDD.Domain.Entities;
using System.Data.Entity;
using System.Linq;
using System;
using ProjectDDD.Infra.Data.EntityConfig;

namespace ProjectDDD.Infra.Data.Context
{
    public class ProjetoDDDModeloContext : DbContext
    {
        public ProjetoDDDModeloContext() 
            :base("ProjetoDDDModelo")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public override int SaveChanges()
        {
            foreach(var e in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("Inclusao") != null))
            {
                if (e.State == EntityState.Added)
                    e.Property("Inclusao").CurrentValue = DateTime.Now;

                if (e.State == EntityState.Modified)
                    e.Property("Inclusao").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
