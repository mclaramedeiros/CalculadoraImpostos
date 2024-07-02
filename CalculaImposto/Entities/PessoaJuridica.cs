using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }
        PessoaJuridica() { }

        public PessoaJuridica(string name, double rendaAnual, int numFuncionarios) : base (name,  rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double CalcularImposto()
        {
            if (NumFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
