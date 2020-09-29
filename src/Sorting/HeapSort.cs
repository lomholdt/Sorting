namespace Sorting
{
    public class HeapSort : ISort
    {
        public void Sort(int[] arr)
        {
            int count = arr.Length;

            for (int i = count / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, count, i);
            }

            for (int i = count - 1; i > 0; i--)
            {
                int temp = arr[0]; 
                arr[0] = arr[i]; 
                arr[i] = temp; 
    
                Heapify(arr, i, 0); 
            }
        }

        private void Heapify(int[] arr, int count, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < count && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < count && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, count, largest);
            }
        }

        private void SiftDown(int[] arr, int start, int end)
        {

        }
    }
}
