using Xunit;
using Array.diff;

namespace Array.diff.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] A = {1, 2, 3, 4, 5, 6, 7, 8};
        int[] B = {2, 5, 6, 6, 7, 8};
        int[] expected = {1, 3, 4};

        // Act
        var C = Kata.ArrayDiff(A, B);

        // Assert
        Assert.Equal(C, expected);
    }
}
