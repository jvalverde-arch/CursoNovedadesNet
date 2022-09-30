﻿using ProductService.Models;

namespace ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);

        void Save();
    }
}
