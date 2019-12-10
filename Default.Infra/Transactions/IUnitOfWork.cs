namespace Default.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
