using Painel.Domain.Entities;
using Painel.Domain.Interfaces;
using Painel.Infra.Data.Context;

namespace Painel.Infra.Data.Repositories;
public class LoggerRepository : BaseRepository<LoggerModel>, ILoggerRepository
{
    public LoggerRepository(ApplicationDbContext dbContext) : base(dbContext.Logs) { }
}