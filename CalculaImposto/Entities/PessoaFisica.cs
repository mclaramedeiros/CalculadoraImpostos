using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto.Entities
{
    public class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }
        public PessoaFisica() { }
        public PessoaFisica(string name, double rendaAnual, double gastoSaude) : base(name, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcularImposto()
        {
            if (RendaAnual < 20.000)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
        }
    }
}
