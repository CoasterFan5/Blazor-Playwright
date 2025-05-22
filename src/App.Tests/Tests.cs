using Microsoft.Playwright.Xunit; // These two are very important
using System.Threading.Tasks; // This is the async keyword

namespace App.Tests; // will vary depending on project name

// Name does not matter here
// Notice how we extend PageTest, which is different than a normal bUnit or xUnit test.
public class ReallyGoodTest() : PageTest
{
    [Fact] // declares a method as a test
    //Another name that does not matter
    public async Task PageHasBody()
    {
        await Page.GotoAsync("http://localhost:5155");
        await Expect(Page.Locator("body")).ToBeAttachedAsync();
    }
    
}
