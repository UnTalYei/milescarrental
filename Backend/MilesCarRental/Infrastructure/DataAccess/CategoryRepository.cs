//namespace MilesCarRental.Infrastructure.DataAccess
//{
//    public class CategoryRepository : IRepository<Category>
//    {
//        private readonly MilesCarRentalContext _context;

//        public CategoryRepository(MilesCarRentalContext context)
//        {
//            _context = context;
//        }

//        public async Task<Category> GetByIdAsync(int id)
//        {
//            return await _context.Categories.FindAsync(id);
//        }

//        public async Task<IEnumerable<Category>> GetAllAsync()
//        {
//            return await _context.Categories.ToListAsync();
//        }

//        public async Task AddAsync(Category category)
//        {
//            await _context.Categories.AddAsync(category);
//        }

//        public async Task UpdateAsync(Category category)
//        {
//            _context.Categories.Update(category);
//        }

//        public async Task DeleteAsync(int id)
//        {
//            var category = await _context.Categories.FindAsync(id);
//            _context.Categories.Remove(category);
//        }
//    }

//}
