using Painel.Application.DTOs;
using Painel.Application.Interfaces;
using Painel.Infra.Data.Interfaces;

namespace Painel.Application.Services;
internal class RequestService : IRequestService
{
    private readonly IRequestRepository _repository;
    private readonly RequestOutput _output;
    public RequestService(IRequestRepository repository, RequestOutput output)
    {
        _repository = repository;
        _output = output;
    }

    public async Task<RequestOutput> GetAll(int skip, int take)
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

    public async Task<RequestOutput> GetByCycleId(Guid cycleId)
    {
        var data = await _repository.GetByCycleId(cycleId);

        if (data is not null)
        {
            _output.AddData(data);
            _output.SetRecordsTotal();
        }

        return _output;
    }

    public async Task<RequestOutput> GetById(long id)
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