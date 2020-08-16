namespace RG2System_Garage.Infra.Repositories.Transactions
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
