namespace solucaoData.Migrations
{
    using Context;
    using solucaoDomain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<solucaoData.Context.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(solucaoData.Context.Contexto context)
        {
            Random random = new Random();

            var c1 = new Classificado
            {
                Titulo = "T�tulo 1",
                DataCadastro = DateTime.Now,
                Descricao = "Longa Descri��o 1",
                Preco = Convert.ToDecimal(random.Next(1000)),
                Status = true
            };

            var c2 = new Classificado
            {
                Titulo = "T�tulo 2",
                DataCadastro = DateTime.Now,
                Descricao = "Longa Descri��o 2",
                Preco = Convert.ToDecimal(random.Next(1000)),
                Status = false
            };

            var c3 = new Classificado
            {
                Titulo = "T�tulo 3",
                DataCadastro = DateTime.Now,
                Descricao = "Longa Descri��o 3",
                Preco = Convert.ToDecimal(random.Next(1000)),
                Status = true
            };

            var c4 = new Classificado
            {
                Titulo = "T�tulo 4",
                DataCadastro = DateTime.Now,
                Descricao = "Longa Descri��o 4",
                Preco = Convert.ToDecimal(random.Next(1000)),
                Status = false
            };

            var c5 = new Classificado
            {
                Titulo = "T�tulo 5",
                DataCadastro = DateTime.Now,
                Descricao = "Longa Descri��o 5",
                Preco = Convert.ToDecimal(random.Next(1000)),
                Status = false
            };

            context.Classificados.Add(c1);
            context.Classificados.Add(c2);
            context.Classificados.Add(c3);
            context.Classificados.Add(c4);
            context.Classificados.Add(c5);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
