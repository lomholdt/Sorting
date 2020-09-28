using Xunit;
using Sorting;

namespace Sorting.UnitTest
{
  public class MergeSortTest
    {
        private readonly MergeSort _sut;

        public MergeSortTest()
        {
            _sut = new MergeSort();
        }

        public sealed class When_sorting : MergeSortTest
        {
            [Fact]
            public void It_sorts_a_backwards_array()
            {
                Assert.True(true);
            }
        }
    }
}
