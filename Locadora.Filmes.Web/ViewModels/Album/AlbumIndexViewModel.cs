using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Album
{
    public class AlbumIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }

        [Display(Name = "Descricão do álbum")]
        public string Descricao { get; set; }

        [Display(Name = "Autor do álbum")]
        public string Autor { get; set; }
    }
}