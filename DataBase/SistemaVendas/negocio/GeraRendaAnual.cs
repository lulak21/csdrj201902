using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using NHibernate;

namespace SistemaVendas.Negocio
{
    public static class GeraRendaAnual
    {
        public static double calcularRendaPorAnoVendedor(int idVendedor, int ano, ISession _session)
        {

            string query = "select sum(vv.valor)  from venda v inner join vendavendedor vv on vv.IdVenda = v.Idvenda where vv.IdVendedor = :idVendedor";

            double valorComissao = _session.CreateSQLQuery(query).SetParameter("idVendedor", idVendedor)
                    .UniqueResult<double>();

           
            return valorComissao;
        }
    }
}
