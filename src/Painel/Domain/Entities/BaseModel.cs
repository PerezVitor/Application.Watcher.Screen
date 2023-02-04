using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Painel.Domain.Entities;
public abstract class BaseModel
{
    [Key]
    public long Id { get; set; }
    public Guid CycleId { get; set; }
    public string ApplicationName { get; set; }
    
    [Column("CreateDate")]
    [JsonIgnore]
    public DateTime Date { get; set; }

    [NotMapped]
    public string CreateDate { get; set; }
}