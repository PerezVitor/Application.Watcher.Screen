using Painel.Application.DTOs;
using Painel.Application.Interfaces;
using Painel.Infra.Data.Interfaces;

namespace Painel.Application.Services;
internal class LoggerService : ILoggerService
{
    private readonly ILoggerRepository _repository;
    private readonly LogOutput _output;

    public LoggerService(ILoggerRepository repository, LogOutput output)
    {
        _repository = repository;
        _output = output;
    }

    public async Task<LogOutput> GetAll(int skip, int take)
    {
        int recordsTotal = await _repository.GetRecordsTotal();
        _output.SetRecordsTotal(recordsTotal);

        if (recordsTotal > 0)
        {
            var data = await _repository.GetAll(skip, take);
            _output.AddData(data);
        }

        return _output;
    }

    public async Task<LogOutput> GetByCycleId(Guid cycleId)
    {
        var data = await _repository.GetByCycleId(cycleId);

        if (data is not null)
        {
            _output.AddData(data);
            _output.SetRecordsTotal();
        }

        return _output;
    }

    public async Task<LogOutput> GetById(long id)
    {
        var data = await _repository.GetById(id);
        
        if (data is not null)
        {
            _output.AddData(data);
            _output.SetRecordsTotal();
        }

        return _output;
    }
}