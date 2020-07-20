namespace NADShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}