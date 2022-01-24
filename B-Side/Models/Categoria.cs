using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B_Side.Models
{
    public class Categoria
    {
        //Propiedades de la clase.
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción es un campo requerido.")]
        public string Descripcion { get; set; }

        //Referencias en la base de datos.
        public ICollection<Producto> Productos { get; set; }
    }
}
