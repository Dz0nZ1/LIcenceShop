using LicenceShop.Application.Common.Dto.LicenceType;
using LicenceShop.Application.LicenceType.Commands;

namespace LicenceShop.BaseTests.Builders.Commands.LicenceType;

public class UpdateLicenceTypeCommandBuilder
{
    private static string LicenceTypeId = "id";
    private static string Name = "Premium";
    private static bool Active = true;
    private UpdateLicenceTypeDto _updateLicenceType = new UpdateLicenceTypeDto(LicenceTypeId, Name, Active);

    public UpdateLicenceTypeCommand Build() => new(_updateLicenceType);  
}