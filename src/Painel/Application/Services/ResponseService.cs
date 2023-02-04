using Painel.Application.DTOs;
using Painel.Application.Interfaces;
using Painel.Infra.Data.Interfaces;

namespace Painel.Application.Services;
internal class ResponseService : IResponseService
{
    private readonly IResponseRepository _repository;
    private readonly ResponseOutput _output;
    public ResponseService(IResponseRepository repository, ResponseOutput output)
    {
        _repository = repository;
        _output = output;
    }

    public async Task<ResponseOutput> GetAll(int skip, int take)
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

    public async Task<ResponseOutput> GetByCycleId(Guid cycleId)
    {
        var data = await _repository.GetByCycleId(cycleId);

        if (data is not null)
        {
            _output.AddData(data);
            _output.SetRecordsTotal();
        }

        return _output;
    }

    public async Task<ResponseOutput> GetById(long id)
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