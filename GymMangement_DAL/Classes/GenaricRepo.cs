using GymMangement_DAL.Interfaces;
using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GymMangement_DAL.Classes
{
    public class GenaricRepo<TEntity> : IGenaricRepo<TEntity> where TEntity : BaseEntity, new()
    {

        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _set;
        public GenaricRepo(AppDbContext contxt)
        {
            _context = contxt;
            _set = _context.Set<TEntity>(); 
        }

        public async Task<int> AddAsync(TEntity entity)
        {
         _context.Set<TEntity>().Add(entity);

            return await _context.SaveChangesAsync(); 
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _set.AsNoTracking().AnyAsync(predicate, cancellationToken);

        }

        public async Task<int> DeleteAsync(TEntity entity)
        {

            _set.Remove(entity);
            return await _context.SaveChangesAsync();

        }

        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = false, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = tracking ? _set : _set.AsNoTracking();

return await query.FirstOrDefaultAsync(predicate);

        }

        public async Task<IEnumerable<TEntity?>> GetAllAsync(bool track = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = track ? _set : _set.AsNoTracking();

            return await query.ToListAsync();


        }

        public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _set.FindAsync(id);

        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            _set.Update(entity);

            return await _context.SaveChangesAsync();
        }
    }
}
