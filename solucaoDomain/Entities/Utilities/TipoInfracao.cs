using System.ComponentModel;

namespace solucaDomain.Entities.Utilities
{
    public enum TipoInfracao
    {
        Leve,
        [Description("Média")]
        Media,
        Grave,
        [Description("Gravíssima")]
        Gravissima
    }
}