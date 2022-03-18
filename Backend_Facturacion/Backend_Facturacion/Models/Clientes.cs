using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Facturacion.Models
{
    public class Clientes
    {
        [Key]
        public int Id_Cliente { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public int Edad { get; set; }
        public Int64 Telefono { get; set; }
    }
}
