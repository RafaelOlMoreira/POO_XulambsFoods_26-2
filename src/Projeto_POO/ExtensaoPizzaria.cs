using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods {
    public static class ExtensaoPizzaria {
        public static double Valor(this EBorda borda) {
            return borda switch {
                EBorda.Chocolate => 8,
                EBorda.Cheddar => 10,
                EBorda.Requeijao => 7,
                _ => 0
            };
        }

        public static double Valor(this ESobremesa sobremesa)
        {
            return sobremesa switch
            {
                ESobremesa.BrigadeiroColher => 8,
                ESobremesa.Pudim => 10,
                ESobremesa.DoceDeLeite => 9,
                _ => 0
            };
        }

        public static double Valor(this EBebida bebida)
        {
            return bebida switch
            {
                EBebida.AguaCasa => 0,
                EBebida.AguaComGas => 4,
                EBebida.ChaComGas => 6,
                EBebida.Sucos => 9,
                EBebida.Cervejas => 15,
                EBebida.Vinho => 18,
                _ => 0
            };
        }

        public static ETaxaEntrega DefinirEntrega(this double distancia)
        {
            return distancia switch
            {
                (<= 4)          => ETaxaEntrega.Curta,
                (> 4 and <= 8)  => ETaxaEntrega.Media,
                (> 8)           => ETaxaEntrega.Longa
            };
        }
        public static double ValorTaxa(this ETaxaEntrega distancia)
        {
            return distancia switch
            {
                ETaxaEntrega.Curta => 0,
                ETaxaEntrega.Media => 5,
                ETaxaEntrega.Longa => 8,
                _ => 0
            };
        }
    }
}
