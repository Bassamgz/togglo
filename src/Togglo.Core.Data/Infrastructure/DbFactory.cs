namespace Togglo.Core.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ToggloEntities dbContext;

        public ToggloEntities Init()
        {
            return this.dbContext ?? (this.dbContext = new ToggloEntities());
        }

        protected override void DisposeCore()
        {
            if (this.dbContext != null)
            {
                this.dbContext.Dispose();
            }
        }
    }
}
