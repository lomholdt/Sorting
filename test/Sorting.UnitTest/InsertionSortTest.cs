using System.Linq;
using Xunit;

namespace Sorting.UnitTest
{
  public abstract class InsertionSortTest
  {
    private readonly int[] _expected = new[] { 1,2,3,4,5 };

    private readonly InsertionSort _sut;

    public InsertionSortTest()
    {
        _sut = new InsertionSort();
    }

    public sealed class When_creating_instance : InsertionSortTest
    {
      [Fact]
      public void It_sorts_a_backwards_array()
      {
        var actual = new[] { 5, 4, 3, 2, 1 };

        _sut.Sort(actual);

        Assert.Equal(_expected, actual);
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
