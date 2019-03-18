using System.ComponentModel;

namespace solucaDomain.Entities.Utilities
{
    public enum EstadoCivil
    {
        [Description("Solteiro(a)")]
        Solteiro,

        [Description("Casado(a)")]
        Casado,

        [Description("Divorciado(a)")]
        Divorciado,

        [Description("Viúvo(a)")]
        Viuvo
    }
}