using Entytess;

namespace repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategory();
    }
}