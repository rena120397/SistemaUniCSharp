using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegocioWebDAO.Entidades;

namespace NegocioWebDAO.Repositorios
{
    public class EmpleadoDAO : IDisposable
    {
        NegocioWebEntities db = new NegocioWebEntities();
        public int Agregar(Empleado emp)
        {
            return db.usp_EmpleadosInsert(emp.IdEmpleado, emp.Apellidos, emp.Nombre,
                emp.Cargo, emp.FechaNacimiento, emp.FechaContratación, emp.Dirección,
                emp.Ciudad, emp.País, emp.TelDomicilio, emp.Foto);
        }
        public int Editar(Empleado emp)
        {
            return db.usp_EmpleadosUpdate(emp.IdEmpleado, emp.Apellidos, emp.Nombre,
                emp.Cargo, emp.FechaNacimiento, emp.FechaContratación, emp.Dirección,
                emp.Ciudad, emp.País, emp.TelDomicilio, emp.Foto);
        }
        public int Eliminar(int idemp)
        {
            return db.usp_EmpleadosDelete(idemp);
        }
        public usp_EmpleadosSelect_Result  Buscar(int idemp)
        {
            return db.usp_EmpleadosSelect(idemp).SingleOrDefault();
        }
        public List< usp_EmpleadosSelectAll_Result> Listar()
        {
            return db.usp_EmpleadosSelectAll().ToList();
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
        // ~EmpleadoDAO() {
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





