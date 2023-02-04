namespace Painel.Application.Extensions;
public static class ControllerExtension
{
    public static string GetDraw(this HttpRequest request)
        => request.Form["draw"].FirstOrDefault();
    
    public static int GetSkip(this HttpRequest request) 
        => int.TryParse(request.Form["start"].FirstOrDefault(), out int start) ? start : 0;

    public static int GetPageSize(this HttpRequest request) 
        => int.TryParse(request.Form["length"].FirstOrDefault(), out int pageSize) ? pageSize : 0;
        
    public static string GetSortColumn(this HttpRequest request) 
        => request.Form["columns[" + request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

    public static string GetSortColumnDirection(this HttpRequest request) 
        => request.Form["order[0][dir]"].FirstOrDefault();
}