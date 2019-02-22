using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendas.negocio;

namespace TestProject
{
    [TestClass]
    public class CalculadoraComissaoUnitTest
    {
        [TestMethod]
        public void vendaDeCincoMilRetornaDuzentosECinquenta()
        {
            int venda    = 5000;
            int comissao = 250;

            var retorno = CalculadoraComissao.calcularCincoPorcento(venda);
            Assert.AreEqual(comissao, retorno);
        }

        [TestMethod]
        public void vendaMaisDeDezMilRetornaNovecentos()
        {
            int venda = 15000;
            int comissao = 900;

            var retorno = CalculadoraComissao.calcularSeisPorcento(venda);
            Assert.AreEqual(comissao, retorno);
        }

        [TestMethod]
        public void empresanaolevaprejuizo()
        {
            double venda = 55.59;
            double comissao = 2.77;

            var retorno = CalculadoraComissao.calcularsemprejuizo(venda);
            Assert.AreEqual(comissao, retorno);
        }
        [TestMethod]
        public void vendaDezmileum()
        {
            int venda = 10001;
            double comissao = 600.06;

            var retorno = CalculadoraComissao.calcular(venda);
            Assert.AreEqual(comissao, retorno);
        }

    }


}
