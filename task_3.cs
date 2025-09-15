using System;

class task_3
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Orgial Array :\n");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.Write("Enter element to search: ");
        int x = int.Parse(Console.ReadLine());

        bool found = false;
        foreach (int item in arr)
        {
            if (item == x)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    
    }
}
