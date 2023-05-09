using Microsoft.AspNetCore.Mvc;
using Painel.Application.DTOs;
using Painel.Application.Model;
using Painel.Domain.Entities;
using Painel.Domain.Interfaces;

namespace Painel.Controllers;
public abstract class BaseController<TClass> : Controller where TClass : BaseModel
{
    private readonly IBaseRepository<TClass> _repository;
    private FilterModel? FilterModel { get; set; }
    protected BaseController(IBaseRepository<TClass> repository) => _repository = repository;

    public async Task<IActionResult> List(Filter filter)
    {
        try
        {
            FilterModel = new FilterModel(filter);

            SetFilterViewBag(filter);
            ViewBag.TotalPages = FilterModel.GetTotalPages(await GetTotalItens());

            return View(await GetItensToShow(filter));
        }
        catch (Exception ex)
        {
            return View(new List<TClass>());
        }
    }

    private void SetFilterViewBag(Filter filter)
    {
        ViewBag.CycleId = filter.cycleId;
        ViewBag.InitialDate = filter.initialDate;
        ViewBag.finalDate = filter.finalDate;
        ViewBag.CurrentPage = filter.page;
        ViewBag.PageSize = filter.pageSize;
    }

    private async Task<List<TClass>> GetItensToShow(Filter filter)
    {
        int skip = FilterModel.GetStartItem();
        int take = filter.pageSize;

        if (FilterModel.HasFilters())
            return await _repository.GetAllFiltered(skip, take, FilterModel.GetFilters<TClass>());

        return await _repository.GetAll(skip, take);
    }

    private async Task<int> GetTotalItens()
    {
        return FilterModel?.HasFilters() == true
            ? await _repository.GetRecordsTotal(FilterModel.GetFilters<TClass>())
            : await _repository.GetRecordsTotal();
    }

    public async Task<IActionResult> Details(long? id)
    {
        if (id is null || _repository is null)
            return NotFound();

        TClass? exceptionModel = (await _repository.GetById(id.Value)).FirstOrDefault();

        if (exceptionModel is null)
            return NotFound();

        return View(exceptionModel);
    }
}
