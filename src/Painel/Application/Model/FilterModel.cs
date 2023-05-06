using Painel.Application.DTOs;
using Painel.Application.Extensions;
using Painel.Domain.Entities;
using System.Linq.Expressions;

namespace Painel.Application.Model;
public class FilterModel
{
    readonly string? cycleId;
    readonly string? initialDate;
    readonly string? finalDate;
    readonly int page;
    readonly int pageSize;

    public FilterModel(Filter filter)
    {
        this.cycleId = filter.cycleId;
        this.initialDate = filter.initialDate;
        this.finalDate = filter.finalDate;
        this.page = filter.page;
        this.pageSize = filter.pageSize;
    }

    internal int GetStartItem() => (page - 1) * pageSize;
    internal int GetTotalPages(int totalItems) => (int)Math.Ceiling((decimal)totalItems / pageSize);
    internal bool HasFilters() => HasCycleId() || HasDates();
    internal bool HasCycleId() => cycleId is not null;
    internal bool HasDates() => initialDate is not null || finalDate is not null;
    private Guid GetCycleId() => Guid.TryParse(cycleId, out Guid resultCycleId) ? resultCycleId : Guid.Empty;
    private static DateTime GetDate(string? date) => DateTime.TryParse(date, out DateTime resultDate) ? resultDate : DateTime.Now;

    internal Expression<Func<TClass, bool>> GetFilters<TClass>() where TClass : BaseModel
    {
        if (HasCycleId())
            return x => x.CycleId == GetCycleId();

        return x => x.Date >= GetDate(initialDate) && x.Date <= GetDate(finalDate);
    }
}
