using SenaiApi.Domen.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domen.Entidades
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DataInsercao { get; set; }

        public  TipoSexoEnum SexoEnum { get; set; }
        public Endereco Endereco { get; set; }
    }
}
