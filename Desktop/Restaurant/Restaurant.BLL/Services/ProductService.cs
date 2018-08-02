using Restaurant.DAL;
using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.BLL
{
    public class ProductService : IProductService
    {
        private RestaurantDataStore _dataStore;

        public ProductService(RestaurantDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void Add(ProductDTO product)
        {
            string productName = product.Name;
            if (_dataStore.Products.Get(p => p.Name == productName).Any())
            {
                throw new DublicateException($"Product with '{productName}' name already exists!");
            }

            Product efProduct = new Product { Name = productName };
            _dataStore.Products.Create(efProduct);
        }

        public ICollection<ProductDTO> All()
        {
            List<Product> efProductList = _dataStore.Products.Get().ToList();
            ICollection<ProductDTO> productList =
                efProductList.Select(p => new ProductDTO { Name = p.Name }).ToList();
            return productList;
        }

        public void Dispose()
        {
            _dataStore.Dispose();
        }
    }

}
