using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Dominio
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }

        public string Autor { get; set; }
    }
}
