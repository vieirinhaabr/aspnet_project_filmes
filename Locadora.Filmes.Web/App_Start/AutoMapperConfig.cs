using AutoMapper;
using Locadora.Filmes.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}