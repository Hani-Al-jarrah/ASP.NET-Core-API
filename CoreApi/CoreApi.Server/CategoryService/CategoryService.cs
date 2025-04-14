using CoreApi.Server.Models;

namespace CoreApi.Server.CategoryService
{
    public class CategoryService : CoreApi.Server.ICategoryService.ICategoryService
    {
        private readonly MyDbContext _context;

        public CategoryService(MyDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category? GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Category? GetByName(string name)
        {
            return _context.Categories.FirstOrDefault(c => c.Name == name);
        }

        public Category? GetFirst()
        {
            return _context.Categories.FirstOrDefault();
        }

        public bool Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
