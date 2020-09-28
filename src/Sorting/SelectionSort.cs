namespace Sorting
{
  public class SelectionSort : ISort
  {
    public void Sort(int[] arr)
    {
      for (var i = 0; i < arr.Length; i++)
      {
        var min = i;
        for (var j = i + 1; j < arr.Length; j++)
        {
          if (arr[min] > arr[j])
          {
            min = j;
          }
        }

        if (min != i)
        {
          var low = arr[min];
          arr[min] = arr[i];
          arr[i] = low;
        }
      }
    }
  }
}
