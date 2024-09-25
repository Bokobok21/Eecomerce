using Eecomerce.Models.Entities;

namespace Eecomerce.Models.Repositories.IRepositories
{
    public interface ICategoryRepository
    {
        bool Add(Category entity);
        List<Category> ToList();

    }
}
