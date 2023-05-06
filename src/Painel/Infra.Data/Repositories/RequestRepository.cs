using Painel.Domain.Entities;
using Painel.Domain.Interfaces;
using Painel.Infra.Data.Context;

namespace Painel.Infra.Data.Repositories;
public class RequestRepository : BaseRepository<RequestModel>, IRequestRepository
{
    public RequestRepository(ApplicationDbContext dbContext) : base(dbContext.Requests) { }
}