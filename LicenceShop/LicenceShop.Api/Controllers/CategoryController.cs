using LicenceShop.Application.Category.Commands;
using LicenceShop.Application.Category.Queries;
using LicenceShop.Application.Common.Constants;
using LicenceShop.Application.Common.Dto.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LicenceShop.Api.Controllers;

[Route("[controller]")]
public class CategoryController : ApiControllerBase
{
    [AllowAnonymous]
    [HttpGet("GetOneCategory")]
    public async Task<ActionResult<CategoryDetailsDto>> GetOneCategory([FromQuery] GetOneCategoryQuery query) =>
        Ok(await Mediator.Send(query));
    
    [AllowAnonymous]
    [HttpGet("GetPageableCategory")]
    public async Task<ActionResult<CategoryPageableDto>> GetPageableCategory([FromQuery] GetPageableCategoryQuery query) =>
        Ok(await Mediator.Send(query));

    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPost("CreateCategory")]
    public async Task<ActionResult<string>> CreateCategory(CreateCategoryCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPut("UpdateCategory")]
    public async Task<ActionResult<string>> UpdateCategory(UpdateCategoryCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpDelete("DeleteCategory")]
    public async Task<ActionResult<string>> DeleteCategory(DeleteCategoryCommand command) =>
        Ok(await Mediator.Send(command));
    
}