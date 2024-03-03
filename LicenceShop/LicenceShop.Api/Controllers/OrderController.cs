using LicenceShop.Application.Common.Constants;
using LicenceShop.Application.Common.Dto.Order;
using LicenceShop.Application.Order.Commands;
using LicenceShop.Application.Order.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LicenceShop.Api.Controllers;


[Route("[controller]")]
public class OrderController : ApiControllerBase
{
    [Authorize(Roles = LicenceShopAuthorization.Customer)]
    [HttpGet("GetOrdersPageable")]
    public async Task<ActionResult<OrderPageableDto>> GetOrdersPageable([FromQuery] GetOrderPageableQuery query) =>
        Ok(await Mediator.Send(query));
    [Authorize(Roles = LicenceShopAuthorization.Customer)]
    [HttpGet("GetOneOrder")]
    public async Task<ActionResult<OrderDetailsDto>> GetOneOrder([FromQuery] GetOneOrderQuery query) =>
        Ok(await Mediator.Send(query));
    
    // [Authorize(Roles = LicenceShopAuthorization.Customer)]
    [HttpPost("CreateOrder")]
    public async Task<ActionResult<string>> CreateOrder(CreateOrderCommand command) => Ok(await Mediator.Send(command));
    


}