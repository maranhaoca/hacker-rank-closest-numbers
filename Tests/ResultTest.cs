using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int>() { 5, 2, 3, 4, 1 };

        var expected = new List<int>() { 1, 2, 2, 3, 3, 4, 4, 5 };
        List<int> actual = Result.closestNumbers(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var arr = new List<int>() { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };

        var expected = new List<int>() { -20, 30 };
        List<int> actual = Result.closestNumbers(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var arr = new List<int>() { -520, -470, -20, 30 };

        var expected = new List<int>() { -520, -470, -20, 30 };
        List<int> actual = Result.closestNumbers(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var arr = new List<int>() { 5,4,3,2 };

        var expected = new List<int>() { 2,3,3,4,4,5 };
        List<int> actual = Result.closestNumbers(arr);

        Assert.Equal(expected, actual);
    }
}