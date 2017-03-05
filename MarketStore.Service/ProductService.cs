using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarketStore.Cache;
using MarketStore.Domain;


namespace MarketStore.Service
{
    public class ProductService : IProductService
    {
        private readonly IDataProvider DataProvider;

        public ProductService(IDataProvider dataProvider)
        {
            DataProvider = dataProvider;
        }

        public async Task DeleteProduct(int id)
        {
            await DataProvider.DeleteProduct(id);
        }

        public async Task<ProductModel> GetProduct(int id)
        {
            return await DataProvider.GetProduct(id);
        }

        public async Task<ICollection<ProductModel>> GetProducts()
        {
            return await DataProvider.GetProducts();
        }

        public async Task<ProductModel> UpdateProduct(ProductModel product)
        {
            return await DataProvider.UpdateProduct(product);
        }
    }
}
