using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Generica.Entity
{
    public abstract class LocadoraEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public LocadoraEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
        }

        protected abstract void ConfigurarChaveEstrangeira();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarNomeTabela();
    }
}
