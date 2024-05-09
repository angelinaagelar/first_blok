/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 // для второго массива мы введем рандом сайз и тогла if цикл уйдет*/

 System.Console.WriteLine("Введите размер массива: ");
 int size = Convert.ToInt32(Console.ReadLine());
 string[] array  = new string[size];
 void FillingArray()
{ for (int i = 0; i < array.Length; i++)
 {
    System.Console.Write("Введите элемент массива: ");
    array[i] = Console.ReadLine();
 }
}
void PrintingArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
FillingArray ();
PrintingArray();
Console.WriteLine(" ");
int size2 = new Random().Next(1, 4);
string[] array2 = new string[size2];

 void FillingSecondArray()
    {
        Random rnd = new Random();
        for (int j = 0; j < size2; j++)
        {
            array2[j] = array[rnd.Next(0, array.Length)];
        }
    }
System.Console.WriteLine("Новым массив из менее или равным 3 элементам: ");
    void PrintingSecondArray()
    {
        for (int j = 0; j < size2; j++)
        {
          
          Console.Write(array2[j] + " ");
        }
   }
    
FillingSecondArray();
PrintingSecondArray();


