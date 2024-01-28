using Data_Layer;

namespace Persistence
{
    public class UnitOfWork
    {
        private readonly AppDbContext _context;
        public UserRepository Users { get; private set; }
        public UserRateRepository UserRates { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Users = new UserRepository(_context);
            UserRates = new UserRateRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
