using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public class Usuario
    {
        public int id { get; set; }
        public string? nome { get; set; } //"?" permite o valor nulo
        public string? login {  get; set; }
        public string? senha { get; set; }
        public DateTime dataCadastro { get; set; }

        public static List<Usuario>
            ListaUsuarios = new List<Usuario>();
    }
}
