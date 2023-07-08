using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domen.Entidades
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set;}
        public long PessoaId { get; set; }
    }
}
