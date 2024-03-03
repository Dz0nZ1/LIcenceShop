using LicenceShop.Application.Category.Commands;
using LicenceShop.Application.Common.Dto.Category;

namespace LicenceShop.BaseTests.Builders.Commands.Category;

public class UpdateCategoryCommandBuilder
{
    private static string CategoryId = "id";
    private static string Name = "Cyber-sec";
    private static bool Active = true;
    private UpdateCategoryDto _updateCategory = new UpdateCategoryDto(CategoryId, Name, Active);

    public UpdateCategoryCommand Build() => new(_updateCategory);  
}