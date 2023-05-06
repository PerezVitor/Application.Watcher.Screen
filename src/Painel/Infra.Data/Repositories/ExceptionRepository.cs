using Painel.Domain.Entities;
using Painel.Domain.Interfaces;
using Painel.Infra.Data.Context;

namespace Painel.Infra.Data.Repositories;
public class ExceptionRepository : BaseRepository<ExceptionModel>, IExceptionRepository
{
    public ExceptionRepository(ApplicationDbContext dbContext) : base(dbContext.Exceptions) { }
}
