using SenaiApi.Domen.Entidades;
using SenaiApi.Repository.Contexts;
using SenaiApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Repositorio
{
    public class PessoaRepositorio : GenericRepository<Pessoa>, IPessoaRepositorio
    {
        public PessoaRepositorio(ApiContext context) : base(context) { }

        public List<Pessoa> PegarTodasAsPessoas()
        {
            return GetAll().ToList();
        }

    }
}
