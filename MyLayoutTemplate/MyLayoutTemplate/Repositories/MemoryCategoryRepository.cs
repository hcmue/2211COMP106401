using MyLayoutTemplate.Models;

namespace MyLayoutTemplate.Repositories
{
    public class MemoryCategoryRepository : ICategoryRepository
    {
        static List<CategoryModel> _categories = new List<CategoryModel>()
        {
            new CategoryModel{Id = 1, Name = "Phone" },
            new CategoryModel{Id = 2, Name = "Tablet" },
            new CategoryModel{Id = 2, Name = "Laptop" }
        };

        public List<CategoryModel> GetAll()
        {
            return _categories;
        }

        public int? Add(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        public CategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
