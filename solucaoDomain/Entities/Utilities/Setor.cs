using System.ComponentModel;

namespace solucaDomain.Entities.Utilities
{
    public enum Setor
    {
        Administrativo,
        [Description("Jurídico")]
        Juridico,
        Financeiro,
        [Description("Tecnologia da Informação")]
        TI,
        [Description("Recursos Humanos")]
        RG
    }
}