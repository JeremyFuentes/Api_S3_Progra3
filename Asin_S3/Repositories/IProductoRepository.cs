using Asin_S3.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asin_S3.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> Get();
        Task<Producto?> GetById(int id);
        Task Add(Producto producto);
        void Update(Producto producto);
        void Delete(Producto entity);
        Task Save();
    }
}
