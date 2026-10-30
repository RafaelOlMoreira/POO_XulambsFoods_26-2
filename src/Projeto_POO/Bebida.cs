using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Bebida : Produto
    {
        private EBebida _tipo;

        public Bebida(EBebida tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo.Valor();
        }

        public override string ToString()
        {
            StringBuilder cupom = new StringBuilder("Xulambs Bebida!\n");
            cupom.AppendLine("================");
            cupom.AppendLine($"Bebida: {_tipo}");
            cupom.AppendLine($"TOTAL: {CalcularValorFinal():C2}");
            cupom.AppendLine("================");
            return cupom.ToString();
        }
    }
}
