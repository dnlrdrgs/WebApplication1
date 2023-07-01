using SenaiApi.Domen.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domen.NovaPasta
{
    public class PessoaDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public TipoSexoEnum SexoEnum { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}
