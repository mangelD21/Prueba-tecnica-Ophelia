using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Facturacion.Models
{
    public class Ventas
    {
        [Key]
        public int Id_Venta { get; set; }
        [Required]
        public string Producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public int Total { get; set; }
    }
}
