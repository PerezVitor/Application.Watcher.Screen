using Microsoft.EntityFrameworkCore;
using Painel.Application.Extensions;
using Painel.Domain.Entities;
using Painel.Domain.Interfaces;
using System.Linq.Expressions;

namespace Painel.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        private readonly DbSet<TEntity> DbSet;

        public BaseRepository(DbSet<TEntity> dbSet) => DbSet = dbSet;

        public async Task<List<TEntity>> GetAll(int skip, int take)
            => await DbSet.Pagination(skip, take).ToListAsync();

        public async Task<List<TEntity>> GetAllFiltered(int skip, int take, Expression<Func<TEntity, bool>> action)
            => await DbSet.Where(action).Pagination(skip, take).ToListAsync();

        public async Task<List<TEntity>> GetBeetweenDates(int skip, int take, DateTime startDate, DateTime endDate)
            => await DbSet.Where(row => row.Date.IsBetween(startDate, endDate)).Pagination(skip, take).ToListAsync();

        public async Task<List<TEntity>> GetByCycleId(Guid cycleId)
            => await GetAllAsync(row => row.CycleId == cycleId);

        public async Task<List<TEntity>> GetById(long id)
            => await GetAllAsync(row => row.Id == id);     
        
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> action)
            => await DbSet.Where(action).ToListAsync();

        public async Task<int> GetRecordsTotal()
            => await DbSet.CountAsync();

        public async Task<int> GetRecordsTotal(Expression<Func<TEntity, bool>> action)
            => await DbSet.CountAsync(action);
    }
}
