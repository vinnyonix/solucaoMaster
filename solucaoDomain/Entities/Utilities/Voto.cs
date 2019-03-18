using System.ComponentModel;

namespace solucaoDomain.Entities.Utilities
{
    public enum Voto
    {
        Sim,
        [Description("Não")]
        Nao,
        [Description("Abstenção")]
        Abstencao
    }
}
