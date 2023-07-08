using AutoMapper;
using SenaiApi.Domen.Entidades;
using SenaiApi.Domen.NovaPasta;

namespace SenaiApi.Service.Mapper
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper() {
            CreateMap<EnderecoDto, Endereco>();
        }
    }
}
