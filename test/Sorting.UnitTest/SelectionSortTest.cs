using System.Linq;
using Xunit;

namespace Sorting.UnitTest
{
  public abstract class SelectionSortTest
  {
    private readonly SelectionSort _sut;

    public SelectionSortTest()
    {
        _sut = new SelectionSort();
    }

    public sealed class When_creating_instance : SelectionSortTest
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
      public void It_Sorts(int[] actual)
      {
        var expected = actual.OrderBy(i => i);

        _sut.Sort(actual);

        Assert.Equal(expected, actual);
      }
    }
  }
}
