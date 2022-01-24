using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B_Side.Models
{
    public class Detalle
    {
        //Propiedades de la clase.
        public int Id { get; set; }

        [Display(Name = "Núm.Pedido")]
        public int PedidoId { get; set; }

        [Display(Name = "Id.Producto")]
        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Descuento { get; set; }

        //Referencias en la base de datos.
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
