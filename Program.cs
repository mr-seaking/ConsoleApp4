using System;

class Program
{
    static void Main()
    {
        
        int[] myArray = new int[0];
        
        Num_enter(ref myArray, myArray.Length);
        
    }

    static void Resize(ref int[] array, int newSize)
    {
        int[] newArray = new int[newSize];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];     
        }
        
        Num_enter(ref newArray, array.Length);
    }
    static void Num_enter(ref int[] myArray, int i)
    {
        
        Console.WriteLine("установлен размер массива: " + myArray.Length);

        for (int j = 0+i; j < myArray.Length; j++)
        {
            
            
            Console.WriteLine("Введите число:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                myArray[j] = num;
            }


        }
        Resize(ref myArray, (myArray.Length + 1)*2);
    }
}