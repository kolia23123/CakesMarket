using CakesMarket.DBContext;
using CakesMarket.Models;
using System;

namespace CakesMarket.Web.UOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext)); ;
        }
        public void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }
    }
}
