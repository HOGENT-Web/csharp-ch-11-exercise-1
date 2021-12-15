using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Shouldly;

namespace IntegrationTests;

[Parallelizable(ParallelScope.Self)]
public class ProductDetailTests : PageTest
{
    [Test]
    public async Task Show_Product_Detail_OnLoad()
    {
        await Page.GotoAsync($"{TestHelper.BaseUri}/product/1");
        await Page.WaitForSelectorAsync("data-test-id=product-detail-title");
        var productTitle = await Page.TextContentAsync("data-test-id=product-detail-title");
        productTitle.ShouldNotBeEmpty();
    }
}
