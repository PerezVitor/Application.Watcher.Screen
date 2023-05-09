using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Painel.Domain.Entities;
public class ResponseModel : BaseModel
{
    public string? ResponseBody { get; set; }
    public int? ResponseStatus { get; set; }
    public string? Headers { get; set; }
    
    [Column("FinishTime")]
    [JsonIgnore]
    public DateTime DateFinishTime { get; set; }
}
