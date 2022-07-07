using System.Text.RegularExpressions;

namespace NewLetsPet.Services.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Regex regex = new Regex(@"^\(?\d{2}\)? ?\d{4,5}[ -]?\d{4}$", RegexOptions.Multiline);
    }
}
