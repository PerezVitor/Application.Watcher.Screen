using Microsoft.EntityFrameworkCore;
using Painel.Domain.Entities;

namespace Painel.Infra.Data.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) 
        => ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

    public DbSet<RequestModel> Requests { get; set; }
    public DbSet<ResponseModel> Responses { get; set; }
    public DbSet<ExceptionModel> Exceptions { get; set; }
    public DbSet<LoggerModel> Logs { get; set; }
}