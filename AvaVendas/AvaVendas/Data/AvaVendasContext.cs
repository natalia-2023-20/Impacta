using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvaVendas.Models;

namespace AvaVendas.Data
{
    public class AvaVendasContext : DbContext
    {
        public AvaVendasContext (DbContextOptions<AvaVendasContext> options)
            : base(options)
        {
        }

        public DbSet<AvaVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<AvaVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<AvaVendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<AvaVendas.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<AvaVendas.Models.Vendas> Vendas { get; set; } = default!;
    }
}
