namespace ProvaGithubActions.Tests;

public sealed class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(1 + 1 == 2);
    }
    
    [Fact]
    public void Test2()
    {
        Assert.False(1 + 1 == 2);
    }
}