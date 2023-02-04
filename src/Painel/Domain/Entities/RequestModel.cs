using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Painel.Domain.Entities;
public class RequestModel : BaseModel
{
    public string RequestBody { get; set; }
    public string QueryString { get; set; }
    public string Path { get; set; }
    public string Headers { get; set; }
    public string Method { get; set; }
    public string Host { get; set; }
    public string IpAddress { get; set; }

    [Column("StartTime")]
    [JsonIgnore]
    public DateTime DateStartTime { get; set; }

    [NotMapped]
    public string StartTime { get; set; }
}
