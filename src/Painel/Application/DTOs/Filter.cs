namespace Painel.Application.DTOs;
public record Filter(string? cycleId, string? initialDate, string? finalDate, int page = 1, int pageSize = 10) { }
