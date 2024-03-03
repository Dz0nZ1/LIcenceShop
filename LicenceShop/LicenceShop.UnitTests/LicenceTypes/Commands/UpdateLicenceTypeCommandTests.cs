using LicenceShop.BaseTests.Builders.Commands.LicenceType;
using Xunit;

namespace LicenceShop.UnitTests.LicenceTypes.Commands;

public class UpdateLicenceTypeCommandTests
{
    [Fact]
    public Task UpdateLicenceTypeCommand_UpdateLicenceTypeDto_ReturnLicenceTypeDto()
    {
        const string expectedId = "id";
        const string expectedName = "Premium";
        const bool expectedActive = true;
        var builder = new UpdateLicenceTypeCommandBuilder();

        // Act
        var createVendorCommand = builder.Build();

        // Assert
        Assert.NotNull(createVendorCommand);
        Assert.Equal(expectedId, createVendorCommand.LicenceType.LicenceTypeId);
        Assert.Equal(expectedName, createVendorCommand.LicenceType.Name);
        Assert.Equal(expectedActive, createVendorCommand.LicenceType.Active);
        return Task.CompletedTask;
    }
}