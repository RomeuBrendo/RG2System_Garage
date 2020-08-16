namespace RG2System_Garage.Infra.Repositories.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RB2System_GarageContext _context;

        public UnitOfWork(RB2System_GarageContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
