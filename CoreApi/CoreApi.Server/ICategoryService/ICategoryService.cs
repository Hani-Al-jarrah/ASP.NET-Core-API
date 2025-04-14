using CoreApi.Server.Models;

namespace CoreApi.Server.ICategoryService
{
    //public class ICategoryService
    //{
    //}
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category? GetById(int id);
        Category? GetByName(string name);
        Category? GetFirst();
        bool Delete(int id);
    }
}
