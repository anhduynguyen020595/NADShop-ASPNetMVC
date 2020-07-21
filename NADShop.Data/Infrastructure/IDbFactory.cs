using System;

namespace NADShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NADShopDbContext Init();
    }
}