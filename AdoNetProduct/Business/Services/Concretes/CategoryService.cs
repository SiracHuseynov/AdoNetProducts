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
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository = new CategoryRepository();
        public void AddCategory(Category category)
        {
            string command = $"Insert into Categories (Name) Values ('{category.Name}')";
            _categoryRepository.Add(command);
        }

        public void DeleteCategory(int id)
        {
            string command = $"Delete from Categories where id = {id}";
            _categoryRepository.Delete(command);
        }

        public List<Category> GetAllCategory()
        {
            string command = $"Select * from Categories";
            return _categoryRepository.GetAll(command);
        }

        public Category GetCategory(int id)
        {
            string command = $"Select * from Categories where id = {id}";
            return _categoryRepository.Get(command);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            string command = $"Select * from Categories where id = {id}";
            Category category = _categoryRepository.Get(command);

            if (category == null) throw new NullReferenceException();

            category.Name = newCategory.Name;

            string updateCommand = $"Update Categories Set Name = '{category.Name}' where id = {id}";
            _categoryRepository.Update(updateCommand);

        }
    }
}
