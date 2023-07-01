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
        void Salvar(PessoaDto pessoa);
    }
}
