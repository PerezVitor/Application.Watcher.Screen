using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;
using Painel.Infra.Data.Context;
using Painel.Infra.Data.Interfaces;

namespace Painel.Infra.Data.Repositories;
public class ExceptionRepository : IExceptionRepository
{
    private readonly ApplicationDbContext dbContext;
    public ExceptionRepository(ApplicationDbContext dbContext)
        => this.dbContext = dbContext;

    public async Task<List<ExceptionModel>> GetAll(int skip, int take)
        => await dbContext.Exceptions.Skip(skip).Take(take).ToListAsync();

    public async Task<ExceptionModel> GetByCycleId(Guid cycleId)
        => await dbContext.Exceptions.Where(row => row.CycleId == cycleId).FirstOrDefaultAsync();

    public async Task<ExceptionModel> GetById(long id)
        => await dbContext.Exceptions.Where(row => row.Id == id).FirstOrDefaultAsync();

    public async Task<int> GetRecordsTotal() 
        => await dbContext.Exceptions.CountAsync();
}
