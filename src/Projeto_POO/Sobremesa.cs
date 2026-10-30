using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class Sobremesa : Produto
    {
        private ESobremesa _tipo;

        public Sobremesa(ESobremesa tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo.Valor();
        }

        public override string ToString()
        {
            StringBuilder cupom = new StringBuilder("Xulambs Sobremesa!\n");
            cupom.AppendLine("==================");
            cupom.AppendLine($"Sobremesa: {_tipo}");
            cupom.AppendLine($"TOTAL: {CalcularValorFinal():C2}");
            cupom.AppendLine("==================");
            return cupom.ToString();
        }
    }
}
