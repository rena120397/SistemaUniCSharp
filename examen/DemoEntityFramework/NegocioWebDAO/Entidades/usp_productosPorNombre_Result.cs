//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NegocioWebDAO.Entidades
{
    using System;
    
    public partial class usp_productosPorNombre_Result
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> PrecioUnidad { get; set; }
        public string CantidadPorUnidad { get; set; }
        public Nullable<short> Stock { get; set; }
        public string Categoria { get; set; }
        public string foto { get; set; }
    }
}
