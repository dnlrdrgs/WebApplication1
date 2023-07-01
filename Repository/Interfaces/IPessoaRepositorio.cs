using SenaiApi.Domen.Entidades;
using SenaiApi.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Interfaces
{
    public interface IPessoaRepositorio
    {
        public List<Pessoa> PegarTodasAsPessoas();

    }
}
