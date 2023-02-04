using Painel.Application.Extensions;

namespace Painel.Application.DTOs;
public class LogOutput : BaseOutput<Domain.Entities.LoggerModel> 
{
    public override void FormatOutput(string draw)
    {
        base.FormatOutput(draw);

        if (!data.Any())
            return;

        foreach (var item in data)
        {
            item.CreateDate = item.Date.FormatDate();
            item.Timestamp = item.DateTimestamp.FormatDate();
        }
    }
}