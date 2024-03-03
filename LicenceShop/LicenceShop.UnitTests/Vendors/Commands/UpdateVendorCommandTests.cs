using LicenceShop.BaseTests.Builders.Commands.Vendors;
using Xunit;

namespace LicenceShop.UnitTests.Vendors.Commands;

public class UpdateVendorCommandTests
{
    [Fact]
    public Task UpdateVendorCommand_UpdateVendorDto_ReturnVendorDto()
    {
        const string expectedId = "id";
        const string expectedName = "Microsoft";
        const bool expectedActive = true;
        var builder = new UpdateVendorsCommandBuilder();

        // Act
        var createVendorCommand = builder.Build();

        // Assert
        Assert.NotNull(createVendorCommand);
        Assert.Equal(expectedId, createVendorCommand.Vendor.VendorId);
        Assert.Equal(expectedName, createVendorCommand.Vendor.Name);
        Assert.Equal(expectedActive, createVendorCommand.Vendor.Active);
        return Task.CompletedTask;
    }
}