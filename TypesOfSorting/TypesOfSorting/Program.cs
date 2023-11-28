using System;
using System.Reflection.Metadata;
class Program45
{
    static int q;

    static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
        q++;
        q++;
        q++;
    }
    static int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        q++;
        for (var i = minIndex; i < maxIndex; i++)
        {
            q++;
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }

    //быстрая сортировка
    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        q++;
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    static int[] QuickSort(int[] array)
    {
        return QuickSort(array, 0, array.Length - 1);
    }

    static void Main1(string[] args)
    {
        Console.Write("N = ");
        var len = Convert.ToInt32(Console.ReadLine());
        q++;
        var a = new int[len];
        q++;
        for (var i = 0; i < a.Length; ++i)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("{0}", string.Join(", ", QuickSort(a)));
        Console.WriteLine("{0}", q);
        Console.ReadLine();
    }
}
//пузырьковая
class prograsm
{
    static int q;
    static void BubbleSort(int[] inArray)
    {
        for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                q++;
                q++;
                if (inArray[j] > inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                    q++;
                    q++;
                    q++;
                }
            }
    }
    static void Main3(string[] args)
    {
        Console.WriteLine("Введите");
        string[] nums = Console.ReadLine().Split(new char[] { ',' });
        int[] intArray = new int[nums.Length];
        q++;
        for (int i = 0; i < nums.Length; i++)
        {
            q++;
            intArray[i] = int.Parse(nums[i]);
        }
        BubbleSort(intArray);
        Console.WriteLine("\r\nОтсортированный массив:");
        foreach (int value in intArray)
        {

            Console.Write($"{value} ");
        }
        Console.WriteLine("{0}", q);
        Console.WriteLine("присвоение: {0}", q);
    }
}
//простыми вставками

class Program1
{
    static int q;
    //метод обмена элементов
    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
        q++;
        q++;
        q++;
    }
    static int[] InsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            q++;
            var key = array[i];
            q++;
            var j = i;
            q++;
            while ((j > 1) && (array[j - 1] > key))
            {
                Swap(ref array[j - 1], ref array[j]);
                j--;
            }

            array[j] = key;
            q++;
        }

        return array;
    }

    static void Main36(string[] args)
    {
        Console.Write("Введите элементы массива: ");
        var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        var array = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            array[i] = Convert.ToInt32(parts[i]);
        }

        Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", InsertionSort(array)));
        Console.WriteLine("присвоений: {0}", q);
        Console.ReadLine();
    }
}
//пирамидальная


class Program
{
    static int q;
    static Int32 add2pyramid(Int32[] arr, Int32 i, Int32 N)
    {
        Int32 imax;
        Int32 buf;
        if ((2 * i + 2) < N)
        {
            if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
            else imax = 2 * i + 1;
            q++;
            q++;
        }
        else imax = 2 * i + 1;
        q++;
        if (imax >= N) return i;
        if (arr[i] < arr[imax])
        {
            buf = arr[i];
            q++;
            arr[i] = arr[imax];
            arr[imax] = buf;
            q++;
            q++;
            q++;
            if (imax < N / 2) i = imax;
        }
        return i;
    }

    static void Pyramid_Sort(Int32[] arr, Int32 len)
    {
        //1
        for (Int32 i = len / 2 - 1; i >= 0; --i)
        {
            q++;
            long prev_i = i;
            q++;
            q++;
            q++;
            i = add2pyramid(arr, i, len);
            if (prev_i != i) ++i;
        }

        //2
        Int32 buf;
        for (Int32 k = len - 1; k > 0; --k)
        {
            q++;
            q++;
            q++;
            q++;
            buf = arr[0];
            arr[0] = arr[k];
            arr[k] = buf;
            Int32 i = 0, prev_i = -1;
            while (i != prev_i)
            {
                prev_i = i;
                q++;
                q++;
                i = add2pyramid(arr, i, k);
            }
        }
    }

    static void Main(string[] args)
    {
        Int32[] arr = new Int32[100];
        q++;
        //заполняем случайными числами
        Random rd = new Random();
        q++;
        for (Int32 i = 0; i < arr.Length; ++i)
        {
            q++; q++;
            arr[i] = rd.Next(1, 101);
        }
        System.Console.WriteLine("The array before sorting:");
        foreach (Int32 x in arr)
        {
            System.Console.Write(x + " ");
        }
        //сортировка
        Pyramid_Sort(arr, arr.Length);

        System.Console.WriteLine("\n\nThe array after sorting:");
        foreach (Int32 x in arr)
        {
            System.Console.Write(x + " ");
        }
        System.Console.WriteLine("\n\nPress the <Enter> key");
        System.Console.ReadLine();
    }
}

//сортировка Шелла

class ShellSortAlgorithm : ISortingAlorithm
{
    public int ComparisonCounter { get; private set; } = 0;
    public int AssignmentCounter { get; private set; } = 0;

    private void ResetCounters()
    {
        ComparisonCounter = 0;
        AssignmentCounter = 0;
    }

    public int[] Sort(int[] array)
    {
        ResetCounters();

        array = (int[])array.Clone();

        int j;

        for (int step = array.Length / 2; step > 0; step /= 2)
        {
            ComparisonCounter++;

            for (int i = step; i < array.Length; i++)
            {
                int value = array[i];

                for (j = i; j >= step; j -= step)
                {
                    ComparisonCounter++;
                    if (value < array[j - step])
                    {
                        AssignmentCounter++;
                        array[j] = array[j - step];
                    }
                    else
                    {
                        break;
                    }
                }
                AssignmentCounter++;
                array[j] = value;
            }
        }
        return array;
    }
}

interface ISortingAlorithm
{
    int ComparisonCounter { get; }
    int AssignmentCounter { get; }

    int[] Sort(int[] array);
}