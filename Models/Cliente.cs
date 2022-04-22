using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud1.Models
{
    public class Cliente
    {
        public int Id{ get; set; }
        public string Nome{ get; set; }
        public string Cpf{ get; set; }
        public string Telefone{ get; set; }

        public static string ConvertCPF(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
        public static string ConvertTEL(string telefone)
        {
            return Convert.ToUInt64(telefone).ToString(@"(00)00000\-0000");
        }
        public static Cliente ConvertCliente(Cliente c)
        {
            c.Cpf = ConvertCPF(c.Cpf);
            c.Telefone = ConvertTEL(c.Telefone);
            return c;
        }
    }
}
