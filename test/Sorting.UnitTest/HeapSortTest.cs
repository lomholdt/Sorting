using System.Linq;
using Xunit;

namespace Sorting.UnitTest
{
  public abstract class HeapSortTest
  {
    private readonly HeapSort _sut;

    public HeapSortTest()
    {
        _sut = new HeapSort();
    }

    public sealed class When_creating_instance : HeapSortTest
    {
      [Fact]
      public void It_sorts_an_array_of_integers()
      {
        var actual = new[] { 5, 4, 3, 2, 1 };

        var expected = new[] { 1, 2, 3, 4, 5 };

        _sut.Sort(actual);

        Assert.Equal(expected, actual);
      }

      [Theory]
      [InlineData(new[] {4, 3, 2, 1})]
      [InlineData(new[] {1})]
      [InlineData(new[] {5, 4, 3, 2, 1})]
      [InlineData(new[] {5, 5, 5, 5})]
      [InlineData(new[] {7, 9, 13, 42})]
      [InlineData(new[] {7, 9, 13, 42, 112, 8, 1, 14, 100, -1})]
      public void It_Sorts(int[] actual)
      {
        var expected = actual.OrderBy(i => i);

        _sut.Sort(actual);

        Assert.Equal(expected, actual);
      }
    }
  }
}
