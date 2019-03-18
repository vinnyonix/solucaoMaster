using System.ComponentModel;

namespace solucaDomain.Entities.Utilities
{
    public enum Cargo
    {
        [Description("Analista de Sistemas")]
        Analista,
        [Description("Arquiteto de Sistemas")]
        Arquiteto,
        Programador,
        Advogado,
        Juiz,
        Promotor,
        Digitador,
        [Description("Assistente Administrativo")]
        Assistente,
        Supervisor,
        Gerente,
        Diretor,
        Contador,
        Economista,
    }
}