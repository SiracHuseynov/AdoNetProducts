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
    public class CategoryRepository : ICategoryRepository
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

        public Category Get(string command)
        {
            var dt = _appDbContext.Query(command);

            Category category = null;

            foreach (DataRow dr in dt.Rows)
            {
                category = new Category
                {
                    Id = int.Parse(dr[0].ToString()),
                    Name = dr[1].ToString()
                };

            }
            return category;

        }

        public List<Category> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Category> _categories = new List<Category>();

            foreach (DataRow dr in dt.Rows)
            {
                Category category = new Category
                {
                    Id = int.Parse(dr[0].ToString()),
                    Name = dr[1].ToString()
                };

                _categories.Add(category);
            }
            return _categories;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
