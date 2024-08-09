using AlgorithmLibrary;
using FluentAssertions;

namespace tests;

public class SearchAlgorithmTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 8)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 6)]
    public void BinarySearchSucceedsWhenTargetIsInArray(int[] array, int target)
    {
        var sut = new SearchAlgorithms();

        var index = sut.BinarySearch(array, target);

        array.Should().HaveElementAt(index, target);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0)]
    public void BinarySearchFailsWhenTargetIsNotInArray(int[] array, int target)
    {
        var sut = new SearchAlgorithms();

        var index = sut.BinarySearch(array, target);

        index.Should().Be(-1);
    }
}
