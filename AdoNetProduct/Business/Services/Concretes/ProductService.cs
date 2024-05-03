using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository = new ProductRepository();
        public void AddProduct(Product product)
        {
            string command = $"Insert into Products (Name, Price, Description, CategoryId) Values ('{product.Name}', {product.Price}, '{product.Description}', {product.CategoryId})";
            _productRepository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"Delete from Products where id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllProducts()
        {
            string command = "Select * from Products";
            return _productRepository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"Select * from Products where id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            string command = $"Select * from Products where id = {id}";
            Product product = _productRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;
            product.Price = newProduct.Price;
            product.Description = newProduct.Description;
            product.CategoryId = newProduct.CategoryId;

            string updateCommand = $"Update Products Set Name = '{product.Name}', Price = {product.Price}, Description = '{product.Description}', CategoryId = {product.CategoryId} where id = {id}";
            _productRepository.Update(updateCommand);
        }
    }
}
