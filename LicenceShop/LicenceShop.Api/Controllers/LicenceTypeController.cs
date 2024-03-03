using LicenceShop.Application.Common.Constants;
using LicenceShop.Application.Common.Dto.LicenceType;
using LicenceShop.Application.LicenceType.Commands;
using LicenceShop.Application.LicenceType.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LicenceShop.Api.Controllers;

[Route("[controller]")]
public class LicenceTypeController : ApiControllerBase
{
    [AllowAnonymous]
    [HttpGet("GetOneLicenceType")]
    public async Task<ActionResult<LicenceTypeDetailsDto>> GetOneLicenceType([FromQuery] GetOneLicenceTypeQuery query) =>
        Ok(await Mediator.Send(query));
    
    [AllowAnonymous]
    [HttpGet("GetPageableLicenceType")]
    public async Task<ActionResult<LicenceTypePageableDto>> GetPageableLicenceType([FromQuery] GetLicenceTypePageableQuery query) =>
        Ok(await Mediator.Send(query));

    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPost("CreateLicenceType")]
    public async Task<ActionResult<string>> CreateLicenceType(CreateLicenceTypeCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPut("UpdateLicenceType")]
    public async Task<ActionResult<string>> UpdateLicenceType(UpdateLicenceTypeCommand command) =>
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpDelete("CreateLicenceType")]
    public async Task<ActionResult<string>> DeleteLicenceType(DeleteLicenceTypeCommand command) =>
        Ok(await Mediator.Send(command));
    
}