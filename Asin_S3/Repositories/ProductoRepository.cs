using Asin_S3.Context;
using Asin_S3.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Asin_S3.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ProductoContext _context;

        public ProductoRepository(ProductoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> Get() => await _context.Productos.ToListAsync();

        public async Task<Producto?> GetById(int id) => await _context.Productos.FindAsync(id);

        public async Task Add(Producto producto) => await _context.Productos.AddAsync(producto);

        public void Update(Producto entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Producto entity) => _context.Productos.Remove(entity);

        public async Task Save() => await _context.SaveChangesAsync();
    }
}
