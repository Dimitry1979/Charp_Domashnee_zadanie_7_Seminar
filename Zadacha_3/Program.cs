// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использвать циклы
    
 class Program
 {
    static void PrintArray(int[] myArray, int i = 0)
    {
        if (i < myArray.Length)
           {
           Console.WriteLine(myArray[i]);
           
           PrintArray(myArray,i+1);
           }
    }


static void Main(string[] args)
{
    int[] myArray = { 5, 3, 2 };

    PrintArray(myArray);
    }


 }