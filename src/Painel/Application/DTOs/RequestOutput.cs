using Painel.Application.Extensions;

namespace Painel.Application.DTOs;
public class RequestOutput : BaseOutput<Domain.Entities.RequestModel> 
{
    public override void FormatOutput(string draw)
    {
        base.FormatOutput(draw);

        if (!data.Any())
            return;

        foreach (var item in data)
        {
            item.CreateDate = item.Date.FormatDate();
            item.StartTime = item.DateStartTime.FormatDate();
        }
    }
}
