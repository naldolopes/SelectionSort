namespace MyProject;
class Program
{

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min_index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min_index])
                {
                    min_index = j;
                }
            }

            int temp = array[i];
            array[i] = array[min_index];
            array[min_index] = temp;
        }
    }


    static void Main(string[] args)
    {
        int[] array = { 4, 2, 6, 5, 1, 3 };

        Console.WriteLine("\nArray before Selection Sort:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        SelectionSort(array);

        Console.WriteLine("\nArray after Selection Sort:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n");
    }
}