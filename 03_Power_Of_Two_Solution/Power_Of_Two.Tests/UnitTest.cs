using Xunit;
using System;
using Power_Of_Two;

namespace Power_Of_Two.Tests;

public class UnitTest
{
    // Tests

    [Fact]
    public void PowerOfTwoTrueTest()
    {
        var result = Solution.PowersofTwo(1);
        Assert.True(result);
    }

    [Fact]
    public void PowerOfTwoFalseTest()
    {
        var result = Solution.PowersofTwo(3);
        Assert.False(result);
    }

    [Fact]
    public void PowerOfTwoFalseLongNumberTest()
    {
        var result = Solution.PowersofTwo(124);
        Assert.False(result);
    }

    
}