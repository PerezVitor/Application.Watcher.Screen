using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Painel.Domain.Entities;
public class LoggerModel : BaseModel
{
    public string Message { get; set; }
    public string CallingFrom { get; set; }
    public string CallingMethod { get; set; }
    public int LineNumber { get; set; }
    public string LogLevel { get; set; }

    [Column("Timestamp")]
    [JsonIgnore]
    public DateTime DateTimestamp { get; set; }

    [NotMapped]
    public string Timestamp { get; set; }
}
