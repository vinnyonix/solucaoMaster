using solucaoDomain.Entities.Utilities;
using System;

namespace solucaoDomain.Entities
{
    public class Reservas
    {
        public int IDReservas { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataReserva { get; set; }
        public Turno Turno { get; set; }
        public int IDMorador { get; set; }
        public int IDEvento { get; set; }
    }
}
