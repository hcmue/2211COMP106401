using Microsoft.AspNetCore.Mvc;
using MyLayoutTemplate.Repositories;

namespace MyLayoutTemplate.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _repo;

        public CategoryViewComponent(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(_repo.GetAll());
        }
    }
}
