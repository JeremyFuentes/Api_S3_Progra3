using Asin_S3.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Asin_S3.Context
{
    public class ProductoContext : DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
