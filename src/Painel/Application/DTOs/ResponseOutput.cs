using Painel.Application.Extensions;

namespace Painel.Application.DTOs;
public class ResponseOutput : BaseOutput<Domain.Entities.ResponseModel> 
{
    public override void FormatOutput(string draw)
    {
        base.FormatOutput(draw);

        if (!data.Any())
            return;

        foreach (var item in data)
        {
            item.CreateDate = item.Date.FormatDate();
            item.FinishTime = item.DateFinishTime.FormatDate();
        }
    }
}