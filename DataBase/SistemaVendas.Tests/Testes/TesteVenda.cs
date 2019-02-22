using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using NUnit.Framework;
using NHibernate;
using SistemaVendas.Negocio;
using SistemaVendas.Model;
using SistemaVendas;

namespace TestProject1.Testes
{
    [TestFixture]
    public class TesteVenda : TesteBase
    {
        private ISession _session;
        
        [SetUp]
        public void Initialize()
        {
            _session = Contexto.SessionFactory.OpenSession();
        }

        [Test]
        public void TotalVendedorUm()
        {
            var ano = 2018;
            var idVendedor = 1;
            GeradorRelatorio gr = new GeradorRelatorio();
            Assert.AreEqual(100, gr.TotalVendasAnualPorVendedor(ano, idVendedor, _session));
        }
        [Test]
        public void TotalVendedor100SemVenda2018()
        {
            var ano = 2018;
            var idVendedor = 100;
            GeradorRelatorio gr = new GeradorRelatorio();
            Assert.AreEqual(0, gr.TotalVendasAnualPorVendedor(ano, idVendedor, _session));
        }
        [Test]
        public void TotalVendedor100ComVenda2019()
        {
            var ano = 2019;
            var idVendedor = 100;
            GeradorRelatorio gr = new GeradorRelatorio();
            Assert.AreEqual(1000, gr.TotalVendasAnualPorVendedor(ano, idVendedor, _session));
        }
        [Test]
        public void TotalVendedor200ComVenda2019()
        {
            var ano = 2019;
            var idVendedor = 200;
            GeradorRelatorio gr = new GeradorRelatorio();
            Assert.AreEqual(12555.59, gr.TotalVendasAnualPorVendedor(ano, idVendedor, _session));
        }
        [Test]
        public void TotalVendedor300ComVenda2018()
        {
            var ano = 2018;
            var idVendedor = 300;
            GeradorRelatorio gr = new GeradorRelatorio();
            Assert.AreEqual(15000, gr.TotalVendasAnualPorVendedor(ano, idVendedor, _session));
        }
    }
}
