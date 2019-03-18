using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoDomain.Entities
{
    public class Login
    {
        public int IDLogin { get; set; }
        public string Email { get; set; }
        public DateTime DataUltimoAcesso { get { return this.DataUltimoAcesso; } set { value = DateTime.Now; } }        
    }
}
