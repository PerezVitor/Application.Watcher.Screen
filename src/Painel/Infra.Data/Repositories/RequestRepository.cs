using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;
using Painel.Infra.Data.Context;
using Painel.Infra.Data.Interfaces;

namespace Painel.Infra.Data.Repositories;
public class RequestRepository : IRequestRepository
{
    private readonly ApplicationDbContext dbContext;
    public RequestRepository(ApplicationDbContext dbContext)
        => this.dbContext = dbContext;

    public async Task<List<RequestModel>> GetAll(int page, int itens)
        => await dbContext.Requests.Skip(page).Take(itens).ToListAsync();

    public async Task<RequestModel> GetByCycleId(Guid cycleId)
        => await dbContext.Requests.Where(row => row.CycleId == cycleId).FirstOrDefaultAsync();

    public async Task<RequestModel> GetById(long id)
        => await dbContext.Requests.Where(row => row.Id == id).FirstOrDefaultAsync();

    public async Task<int> GetRecordsTotal()
        => await dbContext.Requests.CountAsync();
}
