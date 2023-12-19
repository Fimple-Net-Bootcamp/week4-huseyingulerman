using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Interfaces;
using week4_huseyingulerman.Core.Repositories;

namespace week4_huseyingulerman.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
        IGenericRepository<T> GetRepository<T>() where T : class, IEntity;
    }
}
