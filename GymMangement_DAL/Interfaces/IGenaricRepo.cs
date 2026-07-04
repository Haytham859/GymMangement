using GymMangement_DAL.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GymMangement_DAL.Interfaces
{
    public interface IGenaricRepo<TEntity> where TEntity : BaseEntity, new()
    {

        Task<TEntity?> GetByIdAsync(int id,CancellationToken cancellationToken=default);

        Task<IEnumerable<TEntity?>> GetAllAsync(bool track = true, CancellationToken cancellationToken = default);

        Task<int> AddAsync(TEntity entity);

        Task<int> DeleteAsync(TEntity entity);

        Task<int> UpdateAsync(TEntity entity);
        Task<bool> AnyAsync(Expression<Func<TEntity,bool>>predicate,CancellationToken cancellationToken=default);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool tracking=false,CancellationToken cancellationToken = default);




    }
}
