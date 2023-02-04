namespace Painel.Application.Interfaces;
public interface IBaseService<TClass> where TClass : class
{
    Task<TClass> GetAll(int skip, int take);
    Task<TClass> GetById(long id);
    Task<TClass> GetByCycleId(Guid cycleId);
}
