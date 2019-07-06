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
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Detalles_de_pedidos = new HashSet<Detalles_de_pedido>();
        }
    
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdCategoría { get; set; }
        public string CantidadPorUnidad { get; set; }
        public Nullable<decimal> PrecioUnidad { get; set; }
        public Nullable<short> UnidadesEnExistencia { get; set; }
        public Nullable<short> UnidadesEnPedido { get; set; }
        public Nullable<int> NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }
        public string foto { get; set; }
    
        public virtual Categorías Categorías { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalles_de_pedido> Detalles_de_pedidos { get; set; }
        public virtual Proveedore Proveedore { get; set; }
    }
}