

using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers;

public class ListController : BaseCRUDController<List, int, CreateListDto, ListUpdateDTO, ListProfileDto>
{
    public ListController(IListService service) : base(service)
    {
    }
}