using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarketStore.Domain;

namespace MarketStore.Service
{
    public interface IProductService
    {
        Task<ICollection<ProductModel>> GetProducts();

        Task<ProductModel> GetProduct(int id);

        Task<ProductModel> UpdateProduct(ProductModel product);

        Task DeleteProduct(int id);
    }
}
