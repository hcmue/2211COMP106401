using MyLayoutTemplate.Models;

namespace MyLayoutTemplate.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryModel> GetAll();
        CategoryModel GetById(int id);
        int? Add(CategoryModel model);
        bool Update(CategoryModel model);
        bool Delete(int id);
    }
}
