using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;
using Painel.Infra.Data.Context;
using Painel.Infra.Data.Interfaces;

namespace Painel.Infra.Data.Repositories;
internal class ResponseRepository : IResponseRepository
{
    private readonly ApplicationDbContext dbContext;
    public ResponseRepository(ApplicationDbContext dbContext) 
        => this.dbContext = dbContext;

    public async Task<List<ResponseModel>> GetAll(int page, int itens) 
        => await dbContext.Responses.Skip(page).Take(itens).ToListAsync();

    public async Task<ResponseModel> GetByCycleId(Guid cycleId) 
        => await dbContext.Responses.Where(row => row.CycleId == cycleId).FirstOrDefaultAsync();

    public async Task<ResponseModel> GetById(long id) 
        => await dbContext.Responses.Where(row => row.Id == id).FirstOrDefaultAsync();

    public async Task<int> GetRecordsTotal()
        => await dbContext.Responses.CountAsync();
}
