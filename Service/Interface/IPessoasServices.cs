using SenaiApi.Domen.Entidades;
using SenaiApi.Domen.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Interface
{
    public interface IPessoasServices
    {
        public List<Pessoa> BuscarTodos();
        void Salvar(PessoaDto pessoa);
    }
}
