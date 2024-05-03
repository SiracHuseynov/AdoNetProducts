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
    public class CategoryController
    {
        ICategoryService _categoryService = new CategoryService();

        public void Add()
        {
            Console.Write("Category adi daxil edin: ");
            string categoryName = Console.ReadLine();

            Category category = new Category()
            {
                Name = categoryName
            };

            _categoryService.AddCategory(category);
        }

        public void Delete()
        {
            GetAll();
            int id;
            do
            {
                Console.Write("Category Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));
            _categoryService.DeleteCategory(id);
        }

        public void Update()
        {
            GetAll();
            int id;
            do
            {
                Console.Write("Category Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

            Console.Write("Category adi daxil edin: ");
            string categoryName = Console.ReadLine();

            Category newCategory = new Category()
            {
                Name = categoryName
            };

            _categoryService.UpdateCategory(id, newCategory);
        }

        public void GetAll()
        {
            foreach(var item in _categoryService.GetAllCategory())
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }

        public void Get()
        {
            int id;
            do
            {
                Console.Write("Category Id daxil edin: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

            Category category = _categoryService.GetCategory(id);

            Console.WriteLine($"{category.Id} - {category.Name}");

        }
    }
}
