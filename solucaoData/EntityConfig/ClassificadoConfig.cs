using solucaoDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace solucaoData.EntityConfig
{
    public class ClassificadoConfig : EntityTypeConfiguration<Classificado>
    {
        public ClassificadoConfig()
        {
            HasKey(c => c.IDClassificado);

            Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
