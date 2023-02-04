namespace Painel.Application.DTOs;
public abstract class BaseOutput<TClass>
where TClass : class
{
    public BaseOutput()
    {
        data = new List<TClass>();
        recordsTotal = 0;
    }

    public List<TClass> data { get; private set; }
    public int recordsTotal { get; private set; }
    public int recordsFiltered { get; private set; }
    public string draw { get; private set; }

    public void AddData(TClass data) => this.data.Add(data);
    public void AddData(List<TClass> data) => this.data.AddRange(data);
    public void SetRecordsTotal(int recordsTotal = 1) => this.recordsTotal = recordsTotal;

    public virtual void FormatOutput(string draw)
    {
        this.draw = draw;
        this.recordsFiltered = recordsTotal;
    }
}
