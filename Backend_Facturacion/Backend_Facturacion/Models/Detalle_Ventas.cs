using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Facturacion.Models
{
    public class Detalle_Ventas
    {
        [Key]
        public int Id_Detalle { get; set; }
        [Required]
        public Ventas ventas { get; set; }
        [Required]
        public Productos productos { get; set; }
    }
}
