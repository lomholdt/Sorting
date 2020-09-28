namespace Sorting
{
  public class InsertionSort : ISort
  {
    public void Sort(int[] arr)
    {
      for (var i = 0; i < arr.Length; i++)
      {
        var current = arr[i];
        var currentIndex = i;

        while (currentIndex > 0 && arr[currentIndex - 1] > current)
        {
          arr[currentIndex]  = arr[currentIndex - 1];
          currentIndex--;
        }

        arr[currentIndex] = current;
      }
    }
  }
}
