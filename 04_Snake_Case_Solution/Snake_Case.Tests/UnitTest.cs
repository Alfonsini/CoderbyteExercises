using Xunit;
using System;
using Snake_Case;

namespace Snake_Case.Tests;

public class UnitTest
{
    // Tests

    [Fact]
    public void Snake_CaseTrueTest()
    {
        var result = Solution.SnakeCase("cats AND*Dogs-are Awesome");
        Assert.Equal("cats_and_dogs_are_awesome", result);
    }

    [Fact]
    public void Snake_CaseFalseTest()
    {
        var result = Solution.SnakeCase("a b c d-e-f%g");
        Assert.Equal("a_b_c_d_e_f_g", result);
    }

    [Fact]
    public void Snake_CaseFalseLongNumberTest()
    {
        var result = Solution.SnakeCase("dogs-are-pets");
        Assert.Equal("dogs_are_pets", result);
    }


}