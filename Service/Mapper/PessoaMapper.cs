using AutoMapper;
using SenaiApi.Domen.Entidades;
using SenaiApi.Domen.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Mapper
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper() 
        {
            CreateMap<PessoaDto, Pessoa>();
        }
    }
}
