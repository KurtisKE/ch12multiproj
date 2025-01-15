using ch12.Logic;

namespace ch12.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = Class1.Add(1,5);
        Assert.Equal(8,result);
    }
}
