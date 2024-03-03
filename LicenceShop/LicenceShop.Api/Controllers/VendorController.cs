using LicenceShop.Application.Common.Constants;
using Microsoft.AspNetCore.Mvc;
using LicenceShop.Application.Common.Dto.Vendor;
using LicenceShop.Application.Vendor.Commands;
using LicenceShop.Application.Vendor.Queries;
using Microsoft.AspNetCore.Authorization;

namespace LicenceShop.Api.Controllers;

[Route("[controller]")]
public class VendorController : ApiControllerBase
{
    [AllowAnonymous]
    [HttpGet("GetOneVendor")]
    public async Task<ActionResult<VendorDetailsDto>> GetVendor([FromQuery] GetOneVendorQuery query) =>
        Ok(await Mediator.Send(query));
    
    [AllowAnonymous]
    [HttpGet("GetAllVendors")]
    public async Task<ActionResult<VendorListDto>> GetAllVendors([FromQuery] GetAllVendorsQuery query) =>
        Ok(await Mediator.Send(query));

    [Authorize(Roles = $"{LicenceShopAuthorization.Marketer}, {LicenceShopAuthorization.Customer}")]
    [HttpGet("GetVendorsPageable")]
    public async Task<ActionResult<VendorPageableDto>> GetAllVendorsPageable([FromQuery] GetVendorsPageableQuery query) =>
        Ok(await Mediator.Send(query));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPost("CreateVendor")]
    public async Task<ActionResult<string>> CreateVendor(CreateVendorCommand command) => 
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpPut("UpdateVendor")]
    public async Task<ActionResult<string>> UpdateVendor(UpdateVendorCommand command) => 
        Ok(await Mediator.Send(command));
    
    [Authorize(Roles = LicenceShopAuthorization.Marketer)]
    [HttpDelete("DeleteVendor")]
    public async Task<ActionResult<string>> DeleteVendor(DeleteVendorCommand command) =>
        Ok(await Mediator.Send(command));

}