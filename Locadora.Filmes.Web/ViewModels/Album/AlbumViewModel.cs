using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }

        [MaxLength(1000, ErrorMessage ="A descrição deve ter no máximo 1000 caracteres")]
        [Display(Name = "Descrição do álbum")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome do autor deve ter no máximo 100 caracteres")]
        [Display(Name = "Autor do álbum")]
        public string Autor { get; set; }
    }
}