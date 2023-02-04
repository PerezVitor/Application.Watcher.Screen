using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Painel.Domain.Entities;
public class ExceptionModel : BaseModel
{
    public string Message { get; set; }
    public string TypeOf { get; set; }
    public string Source { get; set; }
    public string Path { get; set; }
    public string Method { get; set; }
    public string QueryString { get; set; }
    public string RequestBody { get; set; }
    public string StackTrace { get; set; }

    [Column("OcurredAt")]
    [JsonIgnore]
    public DateTime DateOcurredAt { get; set; }

    [NotMapped]
    public string OcurredAt { get; set; }
}
