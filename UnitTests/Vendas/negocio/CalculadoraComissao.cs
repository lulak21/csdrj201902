using System;

namespace Vendas.negocio
{
    public class CalculadoraComissao { 
         public static double calcularCincoPorcento(int venda)
        {
            return calcular(venda);
        }

        public static double calcularSeisPorcento(int venda)
        {
            return calcular(venda);
        }

        public static double calcularsemprejuizo(double venda)
        {

            return calcular(venda);
        }

        public static double calcular(double venda)
        {
            if (venda <= 10000)
            {
                return Math.Floor(100 * venda * 0.05) / 100;
            }else 
            {
                return venda * 0.06;
            }
            
        }


    }
}