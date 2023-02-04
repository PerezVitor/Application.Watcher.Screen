namespace Painel.Infra.Data.Interfaces;
public interface IBaseRepository<TClass> where TClass : class
{
    Task<List<TClass>> GetAll(int skip, int take);
    Task<int> GetRecordsTotal();
    Task<TClass> GetById(long id);
    Task<TClass> GetByCycleId(Guid cycleId);
}
