using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NegocioWebDAO.Entidades;

namespace NegocioWebDAO.Repositorios
{
    public class CompañiaDAO:IDisposable
    {
        NegocioWebEntities db = new NegocioWebEntities();
        public int Agregar(Compañías_de_envíos comp)
        {
            return db.usp_Compañías_de_envíosInsert(comp.IdCompañíaEnvíos,comp.NombreCompañía,comp.Teléfono);
        }
        public int Editar(Compañías_de_envíos comp)
        {
            return db.usp_Compañías_de_envíosUpdate(comp.IdCompañíaEnvíos,comp.NombreCompañía,comp.Teléfono);
        }
        public int Eliminar(int idcomp)
        {
            return db.usp_Compañías_de_envíosDelete(idcomp);
        }
        public usp_Compañías_de_envíosSelect_Result Buscar(int idcomp)
        {
            return db.usp_Compañías_de_envíosSelect(idcomp).SingleOrDefault();
        }
        public List<usp_Compañías_de_envíosSelectAll_Result> Listar()
        {
            return db.usp_Compañías_de_envíosSelectAll().ToList();
        }

        public List<usp_PedidosSelectAllByFormaEnvío_Result> ListarP(int idcomp)
        {
            return db.usp_PedidosSelectAllByFormaEnvío(idcomp).ToList();
        }


        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~CompañiaDAO() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
