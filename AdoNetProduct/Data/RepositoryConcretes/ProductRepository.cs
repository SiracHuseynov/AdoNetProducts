using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes
{
    public class ProductRepository : IProductRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Product Get(string command)
        {
            var dt = _appDbContext.Query(command);

            Product product = null;

            foreach(DataRow dr in dt.Rows)
            {
                product = new Product
                {
                    Id = int.Parse(dr[0].ToString()),
                    Name = dr[1].ToString(),
                    Price = double.Parse(dr[2].ToString()),
                    Description = dr[3].ToString(),
                    CategoryId = int.Parse(dr[4].ToString())
                };
            }

            return product;
        }

        public List<Product> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> _products = new List<Product>();

            foreach(DataRow dr in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(dr[0].ToString()),
                    Name = dr[1].ToString(),
                    Price = double.Parse(dr[2].ToString()),
                    Description = dr[3].ToString(),
                    CategoryId = int.Parse(dr[4].ToString())
                };
                _products.Add(product); 
            }
            return _products;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
