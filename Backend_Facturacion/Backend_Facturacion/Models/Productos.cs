using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Facturacion.Models
{
    public class Productos
    {
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        public string Producto { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public int Cantidad_Bodega { get; set; }
    }
}