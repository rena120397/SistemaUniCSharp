using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegocioWebDAO.Entidades;
using System.Data.SqlClient;

namespace NegocioWebDAO.Repositorios
{
  public  class PedidoDAO
    {
        NegocioWebEntities db = new NegocioWebEntities();
        public List<usp_pedidosPorFecha_Result> ListarPedidosxFecha(DateTime fechainicio,
                                                                                                                  DateTime fechafin,
                                                                                                                  string cliente)
        {
            return db.usp_pedidosPorFecha( fechainicio, fechafin,cliente).ToList();
        }

        public int ActualizarCostoCargoPedido(decimal cargo, int idpedido)
        {
            string sql = "Update Pedidos set cargo=@cargo where idpedido=@idpedido";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@cargo",cargo),
                new SqlParameter("@idpedido",idpedido)
            };
            return   db.Database.ExecuteSqlCommand(sql, parametros);
        }
    }
}
