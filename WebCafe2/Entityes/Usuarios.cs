using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCafe2.Entityes
{
    public class Usuarios
    {
        public string Code { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Aniversario { get; set; }
    }
}
