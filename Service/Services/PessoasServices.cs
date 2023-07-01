using SenaiApi.Domen.Entidades;
using SenaiApi.Domen.NovaPasta;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Services
{
    public class PessoasServices : IPessoasServices
    {
        private IPessoaRepositorio _pessoaRepositorio;

        public PessoasServices(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

         public List<Pessoa> BuscarTodos()
        {
            return _pessoaRepositorio.PegarTodasAsPessoas();
        }
        public void Salvar(PessoaDto pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
