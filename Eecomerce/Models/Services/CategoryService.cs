using Eecomerce.Models.Entities;
using Eecomerce.Models.Repositories.IRepositories;
using Eecomerce.Models.Services.IServices;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Eecomerce.Models.Services
{
    public class CategoryService:ICategoryService
    {
        private ModelStateDictionary? _modelState;
        private ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }
       
        public List<Category> GetCategoryList()
        {
            return _repository.ToList();
        }
    }
}
