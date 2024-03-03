using LicenceShop.BaseTests.Builders.Commands.Category;
using Xunit;

namespace LicenceShop.UnitTests.Categories.Commands;

public class UpdateCategoryCommandTests
{
    [Fact]
    public Task UpdateCategoryCommand_UpdateCategoryDto_ReturnCategoryDto()
    {
        const string expectedId = "id";
        const string expectedName = "Cyber-sec";
        const bool expectedActive = true;
        var builder = new UpdateCategoryCommandBuilder();

        // Act
        var createCategoryCommand = builder.Build();

        // Assert
        Assert.NotNull(createCategoryCommand);
        Assert.Equal(expectedId, createCategoryCommand.Category.CategoryId);
        Assert.Equal(expectedName, createCategoryCommand.Category.Name);
        Assert.Equal(expectedActive, createCategoryCommand.Category.Active);
        return Task.CompletedTask;
    }
}