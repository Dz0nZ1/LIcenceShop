using LicenceShop.Application.Common.Constants;
using LicenceShop.Application.Common.Dto.Licence;
using LicenceShop.Application.Licence.Commands;
using LicenceShop.Application.Licence.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LicenceShop.Api.Controllers;

[Route("[controller]")]
public class LicenceController : ApiControllerBase
{
    [AllowAnonymous]
    [HttpGet("GetOneLicence")]
    public async Task<ActionResult<LicenceDetailsDto>> GetOneLicence([FromQuery] GetOneLicenceQuery query) =>
        Ok(await Mediator.Send(query));
        
    [AllowAnonymous]
    [HttpGet("GetLicencePageable")]
    public async Task<ActionResult<LicencePageableDto>> GetLicencePageable([FromQuery] GetLicencePageableQuery query) =>
        Ok(await Mediator.Send(query));
    
    // [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPost("CreateLicence")]
    public async Task<ActionResult<string>> CreateLicence(CreateLicenceCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPut("UpdateLicence")]
    public async Task<ActionResult<string>> UpdateLicence(UpdateLicenceCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpDelete("DeleteLicence")]
    public async Task<ActionResult<string>> DeleteLicence(DeleteLicenceCommand command) =>
        Ok(await Mediator.Send(command));

}