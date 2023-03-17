//Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел
 //в массиве.

//[345, 897, 568, 234] -> 2
/*
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array= GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]"); 
FindEven(Array);
int[] GetArray(int size, int min, int max)
{
 
 int[] result = new int[size];
 for(int i = 0; i < result.Length; i++)
   {
   result[i] = new Random().Next(min, max+ 1);
   }
      return result;
 }
 void FindEven(int[] MyArray)
 {
   int  count = 0;
   for(int i = 0; i < MyArray.Length; i++)
   { 
   if(MyArray[i] %2  == 0)
   {  
   count = count + 1;
   }
   }
   Console.WriteLine($"Чётных чисел {count}");
}
   
 //Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
int sumEven = 0;
Console.WriteLine($"[{string.Join(", ", numbers)}]");
for (int j = 0; j < numbers.Length; j+=2)
   { 
    sumEven = sumEven + numbers[j];
   }  
   Console.WriteLine($"сумма цифар на нечет поз:  {sumEven} ");

void FillArray(int[] numbers)
{
   for(int i = 0; i < numbers.Length; i++)
   {
    numbers[i] = new Random().Next(-10,20);
   }
}

           
//Задача 38: Задайте массив вещественных чисел. Найдите разницу
 //между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
*/
int[] array = FillArray(5, 10, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");
int[]FillArray(int size, int MinValue, int MaxValue)
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue+1);
        
    }
    return result;
}

double max = array[0];
double min = array[0];
//int j = 1;
for (int j = 0; j < array.Length; j++)
{
if(array[j] > max) max = array[j];
 if(array[j] < min) min = array[j];
 } 
 

 Console.Write($" Максимальное  = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
       
