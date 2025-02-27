using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            double tarifaDiaria = 95.0;
            double custoPorKm = 0.35;
            double custoTotal = (dias * tarifaDiaria) + ((quilometragemFinal - quilometragemInicial) * custoPorKm);
            return custoTotal;
        }
    }
}
