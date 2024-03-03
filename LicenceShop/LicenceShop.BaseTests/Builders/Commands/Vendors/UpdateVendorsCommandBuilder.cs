using LicenceShop.Application.Common.Dto.Vendor;
using LicenceShop.Application.Vendor.Commands;

namespace LicenceShop.BaseTests.Builders.Commands.Vendors;

public class UpdateVendorsCommandBuilder
{
    private static string VendorId = "id";
    private static string Name = "Microsoft";
    private static bool Active = true;
    private UpdateVendorDto _updateVendor = new UpdateVendorDto(VendorId, Name, Active);

    public UpdateVendorCommand Build() => new(_updateVendor);  
}