namespace netstarttest;

public class UnitTest1
{
    [Fact]
    public void DemoTest()
    {
        int i = 1;
        bool result = false;
        if (i == 1) result = true;
        Assert.True(result, "Value should be equal to 1.");
    }
}
