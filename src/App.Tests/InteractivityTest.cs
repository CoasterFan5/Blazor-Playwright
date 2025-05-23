using Microsoft.Playwright.Xunit; // These two are very important
using System.Threading.Tasks; // This is the async keyword

namespace App.Tests;

public class GreatTest() : PageTest
{
    [Fact]
    public async Task InteractiveTest()
    {


        await Page.GotoAsync("http://localhost:5155/Inputs");
        await Expect(Page.GetByTestId("blazorReady")).ToBeAttachedAsync();



        await Expect(Page.GetByTestId("i1")).ToBeVisibleAsync();
        await Expect(Page.GetByTestId("i2")).ToBeVisibleAsync();
        await Expect(Page.GetByTestId("b3")).ToBeVisibleAsync();
        await Expect(Page.GetByTestId("message")).ToBeHiddenAsync();

        await Page.GetByTestId("i1").FillAsync("c");
        await Page.GetByTestId("i2").FillAsync("d");
        await Page.GetByTestId("b3").ClickAsync();
        await Expect(Page.GetByTestId("message")).ToContainTextAsync("success");

    }

}
