using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetProduct.Controllers
{
    public class ProductController
    {
        IProductService _productService = new ProductService();
        public void Add()
        {
            double price;
            int categoryId;
            Console.Write("Product adi daxil edin: ");

            string productName = Console.ReadLine();
            do
            {
                Console.Write("Product price daxil edin: ");
            }
            while (!double.TryParse(Console.ReadLine(), out price));

            Console.Write("Product description daxil edin: ");
            string descripton = Console.ReadLine();

            do
            {
                Console.Write("Product CategoryId daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out categoryId));

            Product product = new Product()
            {
                Name = productName,
                Price = price,
                Description = descripton,
                CategoryId = categoryId
            };

            _productService.AddProduct(product);
        }

        public void Delete()
        {
            GetAll();
            int id;
            do
            {
                Console.Write("Product Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

            _productService.DeleteProduct(id);
        }

        public void Update()
        {
            GetAll();
            int id;
            do
            {
                Console.Write("Product Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

            double price;
            int categoryId;
            Console.Write("Product adi daxil edin: ");

            string productName = Console.ReadLine();
            do
            {
                Console.Write("Product price daxil edin: ");
            }
            while (!double.TryParse(Console.ReadLine(), out price));

            Console.Write("Product description daxil edin: ");
            string descripton = Console.ReadLine();

            do
            {
                Console.Write("Product CategoryId daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out categoryId));

            Product newProduct = new Product()
            {
                Name = productName,
                Price = price,
                Description = descripton,
                CategoryId = categoryId
            };


            _productService.UpdateProduct(id, newProduct);
        }

        public void GetAll()
        {
            foreach (var item in _productService.GetAllProducts())
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Description} - {item.CategoryId}");
            }
        }

        public void Get()
        {
            int id;
            do
            {
                Console.Write("Product Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

            Product product = _productService.GetProduct(id);

            Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Description} - {product.CategoryId}");

        }
    }
}
