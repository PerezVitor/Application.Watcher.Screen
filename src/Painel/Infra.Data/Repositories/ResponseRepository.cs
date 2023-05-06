using Painel.Domain.Entities;
using Painel.Domain.Interfaces;
using Painel.Infra.Data.Context;

namespace Painel.Infra.Data.Repositories;
public class ResponseRepository : BaseRepository<ResponseModel>, IResponseRepository
{
    public ResponseRepository(ApplicationDbContext dbContext) : base(dbContext.Responses) { }
}