namespace Togglo.Core.Data.Infrastructure
{
    using System;

    public interface IDbFactory : IDisposable
    {
       ToggloEntities Init();
    }
}
