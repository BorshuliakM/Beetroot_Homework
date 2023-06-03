﻿using Xunit;
using MethodsHomework;

namespace MethodsTest;
public class Tests
{
    [Theory]
    [InlineData(5, 10, 10)]
    [InlineData(15, 8, 15)]
    [InlineData(-5, -10, -5)]
    public void Max_TwoIntegers_ReturnsMaximum(int a, int b, int expected)
    {
        // Act
        int result = Methods.Max(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 10, 15, 15)]
    [InlineData(15, 8, 20, 20)]
    [InlineData(-5, -10, -15, -5)]
    public void Max_ThreeIntegers_ReturnsMaximum(int a, int b, int c, int expected)
    {
        // Act
        int result = Methods.Max(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 10, 5)]
    [InlineData(15, 8, 8)]
    [InlineData(-5, -10, -10)]
    public void Min_TwoIntegers_ReturnsMinimum(int a, int b, int expected)
    {
        // Act
        int result = Methods.Min(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 10, 15, 5)]
    [InlineData(15, 8, 20, 8)]
    [InlineData(-5, -10, -15, -15)]
    public void Min_ThreeIntegers_ReturnsMinimum(int a, int b, int c, int expected)
    {
        // Act
        int result = Methods.Min(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 10, true)]
    [InlineData(2, 10, false)]
    [InlineData(5, 5, true)]
    public void TrySumIfOdd_ReturnsTrueIfSumIsOdd(int a, int b, bool expected)
    {
        // Act
        bool result = Methods.TrySumIfOdd(a, b, out _);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Hello", 3, "HelloHelloHello")]
    [InlineData("ABC", 0, "")]
    [InlineData("", 5, "")]
    public void Repeat_ReturnsRepeatedString(string X, int N, string expected)
    {
        // Act
        string result = Methods.Repeat(X, N);

        // Assert
        Assert.Equal(expected, result);
    }
}