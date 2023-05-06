using Painel.Domain.Entities;
using System.Linq.Expressions;

namespace Painel.Domain.Interfaces;
public interface IBaseRepository<TClass> where TClass : class
{
    Task<List<TClass>> GetAll(int skip, int take);
    Task<List<TClass>> GetAllFiltered(int skip, int take, Expression<Func<TClass, bool>> action);
    Task<int> GetRecordsTotal();
    Task<int> GetRecordsTotal(Expression<Func<TClass, bool>> action);
    Task<List<TClass>> GetById(long id);
    Task<List<TClass>> GetByCycleId(Guid cycleId);
    Task<List<TClass>> GetBeetweenDates(int skip, int take, DateTime startDate, DateTime endDate);
}
