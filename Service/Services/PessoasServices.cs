using AutoMapper;
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
        private IMapper _mapper;
        private IPessoaRepositorio _pessoaRepositorio;

        public PessoasServices(IMapper mapper, IPessoaRepositorio pessoaRepositorio)
        {
            _mapper = mapper;
            _pessoaRepositorio = pessoaRepositorio;
        }

         public List<Pessoa> BuscarTodos()
        {
            return _pessoaRepositorio.PegarTodasAsPessoas();
        }
        public bool Salvar(PessoaDto pessoaDto)
        {
            var pessoa = _mapper.Map<Pessoa>(pessoaDto);
            return _pessoaRepositorio.SalvarPessoa(pessoa);
        }
    }
}
