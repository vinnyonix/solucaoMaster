using solucaoData.EntityConfig;
using solucaoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoData.Context
{
   
        public class Contexto : DbContext
        {
            public Contexto()
                : base("solucaoMaster")
            {

            }

        public DbSet<Classificado> Classificados { get; set; }
        public DbSet<Empreendimento> Empreendimentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

                modelBuilder.Properties()
                    .Where(p => p.Name == "ID" + p.ReflectedType.Name)
                    .Configure(p => p.IsKey());

                modelBuilder.Properties<string>()
                    .Configure(p => p.HasColumnType("varchar"));

                modelBuilder.Properties<string>()
                    .Configure(p => p.HasMaxLength(100));
            
                modelBuilder.Configurations.Add(new ClassificadoConfig());
            }

            public override int SaveChanges()
            {
                foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    }

                    if (entry.State == EntityState.Modified)
                    {
                        entry.Property("DataCadastro").IsModified = false;
                    }
                }
                return base.SaveChanges();
            }
        }
    }

