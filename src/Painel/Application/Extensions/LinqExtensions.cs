namespace Painel.Application.Extensions;
public static class LinqExtensions
{
    public static IQueryable<TSource> Pagination<TSource>(this IQueryable<TSource> source, int skip, int take)
        => source.Skip(skip).Take(take);
}
