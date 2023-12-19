using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.Interfaces;
using week4_huseyingulerman.Core.Result.Abstract;

namespace week4_huseyingulerman.Core.Services
{
    public interface IService<TEntity, TRequest, TResponse> where TEntity : IEntity where TRequest : class where TResponse : class
    {
        Task<IAppResult<TResponse>> AddAsync(TRequest request);
        Task<IAppResult<IEnumerable<TResponse>>> AddRangeAsync(IEnumerable<TRequest> requests);
        Task<IAppResult<NoContentDTO>> UpdateAsync(TRequest request);
        Task<IAppResult<NoContentDTO>> RemoveAsync(int id);
        Task<IAppResult<NoContentDTO>> RemoveRangeAsync(IEnumerable<int> ids);
        Task<IAppResult<IEnumerable<TResponse>>> Where(Expression<Func<TEntity, bool>> expression);
        Task<IAppResult<TResponse>> GetByIdAsync(int id);
        Task<IAppResult<IEnumerable<TResponse>>> GetAllAsync();
        Task<IAppResult<IEnumerable<TResponse>>> GetAllActiveAsync();
    }
}
