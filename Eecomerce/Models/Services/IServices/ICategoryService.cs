using Eecomerce.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Eecomerce.Models.Services.IServices
{
    public interface ICategoryService
    {
        public List<Category> GetCategoryList();
    }
}
