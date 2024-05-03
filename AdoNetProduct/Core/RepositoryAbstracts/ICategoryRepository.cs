using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstracts
{
    public interface ICategoryRepository
    {
        void Add(string command);
        void Delete(string command);
        void Update(string command);
        Category Get(string command);
        List<Category> GetAll(string command);


    }
}
