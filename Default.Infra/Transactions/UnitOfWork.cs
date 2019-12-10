using Default.Infra.Persistence.EF;
using System;

namespace Default.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _defaultContext;

        public UnitOfWork(DefaultContext defaultContext)
        {
            _defaultContext = defaultContext;
        }

        public void Commit()
        {
            _defaultContext.SaveChanges();
        }
    }
}
