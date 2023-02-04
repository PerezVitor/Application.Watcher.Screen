using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;
using Painel.Infra.Data.Context;
using Painel.Infra.Data.Interfaces;

namespace Painel.Infra.Data.Repositories;
internal class LoggerRepository : ILoggerRepository
{
    private readonly ApplicationDbContext dbContext;
    public LoggerRepository(ApplicationDbContext dbContext)
        => this.dbContext = dbContext;

    public async Task<List<LoggerModel>> GetAll(int page, int itens)
        => await dbContext.Logs.Skip(page).Take(itens).ToListAsync();

    public async Task<LoggerModel> GetByCycleId(Guid cycleId)
        => await dbContext.Logs.Where(row => row.CycleId == cycleId).FirstOrDefaultAsync();

    public async Task<LoggerModel> GetById(long id)
        => await dbContext.Logs.Where(row => row.Id == id).FirstOrDefaultAsync();

    public async Task<int> GetRecordsTotal()
        => await dbContext.Logs.CountAsync();
}
