namespace NADShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NADShopDbContext dbContext;

        public NADShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NADShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}