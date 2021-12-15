using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Shouldly;

namespace IntegrationTests;

[Parallelizable(ParallelScope.Self)]
public class ProductIndexTests : PageTest
{
    [Test]
    public async Task Show_Index_With_25_Items_On_Load()
    {
        await Page.GotoAsync(TestHelper.BaseUri);
        await Page.WaitForSelectorAsync("data-test-id=product-overview");
        var amountOfProducts = await Page.Locator("data-test-id=product-item").CountAsync();
        amountOfProducts.ShouldBe(25);
    }

    [Test]
    public async Task Show_Index_With_Filtered_Items_After_Filter()
    {
        await Page.GotoAsync(TestHelper.BaseUri);
        await Page.WaitForSelectorAsync("data-test-id=product-overview");

        // Click in the search filter
        await Page.ClickAsync("data-test-id=product-filter-search");
        // Type in the search
        await Page.FillAsync("data-test-id=product-filter-search", "Gloves");
        // Press Enter
        await Page.PressAsync("data-test-id=product-filter-search", "Enter");

        var amountOfProducts = await Page.Locator("data-test-id=product-item").CountAsync();
        amountOfProducts.ShouldBe(4);
    }
}
