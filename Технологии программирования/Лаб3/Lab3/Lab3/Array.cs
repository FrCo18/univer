namespace Sorting
{
    class ArraySort
    {
        public int[] a;
        public ArraySort() //конструктор
        {
        }

        private static void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }

        public void selectSort(int[] a, ref int sr, ref int obm)
        {
            int max;
            int length = a.Length;
            for (int i = 0; i < length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < length; j++)
                {
                    sr++;
                    if (a[j] > a[max])
                    {
                        max = j;
                    }
                }
                sr++;
                if (max != i)
                {
                    swap(ref a[i], ref a[max]);
                    obm++;
                }
            }
        }

        public void insertSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int cur = a[i];
                int j = i;
                while (j > 0 && cur > a[j - 1])
                {
                    sr++;
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
            }
            sr++;
        }

        public void bubbleSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    sr++;
                    if (a[j] < a[j + 1])
                    {

                        swap(ref a[j], ref a[j + 1]);
                        obm++;
                    }
                }
            }
        }

        public void bubbleSortRecursive(int[] a, int n, ref int sr, ref int obm)
        {
            // Base case
            if (n == 1)
            {
                return;
            }

            int count = 0;
            // One pass of bubble sort. After
            // this pass, the largest element
            // is moved (or bubbled) to end.
            for (int i = 0; i < n - 1; i++)
            {
                sr++;
                if (a[i] < a[i + 1])
                {
                    swap(ref a[i], ref a[i + 1]);
                    count++;
                    obm++;
                }
            }

            // Check if any recursion happens or not
            // If any recursion is not happen then return
            if (count == 0)
            {
                return;
            }

            bubbleSortRecursive(a, a.Length, ref sr, ref obm);
        }


        //метод возвращающий индекс опорного элемента
        public int Partition(int[] array, int minIndex, int maxIndex, ref int sr, ref int obm)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                sr++;
                if (array[i] > array[maxIndex])
                {
                    pivot++;
                    swap(ref array[pivot], ref array[i]);
                    obm++;
                }
            }

            pivot++;
            swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        private int[] quickSort(int[] array, int minIndex, int maxIndex, ref int sr, ref int obm)
        {

            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex, ref sr, ref obm);
            quickSort(array, minIndex, pivotIndex - 1, ref sr, ref obm);
            quickSort(array, pivotIndex + 1, maxIndex, ref sr, ref obm);

            return array;
        }

        public int[] quickSort(int[] array, ref int sr, ref int obm)
        {
            return quickSort(array, 0, array.Length - 1, ref sr, ref obm);
        }
    }
}
