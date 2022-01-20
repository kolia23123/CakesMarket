using System;
using System.Collections.Generic;
using System.Text;

namespace CakesMarket.Models
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
