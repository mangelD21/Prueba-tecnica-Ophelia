using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_Facturacion.Models;

namespace Backend_Facturacion.Data
{
    public class Backend_FacturacionContext : DbContext
    {
        public Backend_FacturacionContext (DbContextOptions<Backend_FacturacionContext> options)
            : base(options)
        {
        }

        public DbSet<Backend_Facturacion.Models.Clientes> Clientes { get; set; }

        public DbSet<Backend_Facturacion.Models.Productos> Productos { get; set; }

        public DbSet<Backend_Facturacion.Models.Ventas> Ventas { get; set; }

        public DbSet<Backend_Facturacion.Models.Detalle_Ventas> Detalle_Ventas { get; set; }
    }
}
