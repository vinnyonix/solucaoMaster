using System.ComponentModel;

namespace solucaDomain.Entities.Utilities
{
    public enum TipoDeOcorrenciaPortaria
    {
        [Description("Média")]
        Media,
        Grave,
        [Description("Gravíssima")]
        Gravissima
    }
}