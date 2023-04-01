// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// // int[] GenerateArray(int size, int leftRange, int rightRange)
// // {
// //     int[] array = new int[size];
// //     var rand = new Random();
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
// //     }
// //     return array;
// // }


int[] GenerateArray(int size)
{
    int[] array = new int[size];

For (i =0; i++; i<size)
{Console.WriteLine ("введите число");
array[i]=convertToInt32(console.ReadLine());}
}

void ShowArray(int[] array)
 {
     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
 }

Void Positive (int[] array)
{For (i =0; i++; i<size) 
{int Quantity =0;
If Array[i]>0
{
Quantity ++;
Return Quantity;
}}

int[] myArray = GenerateArray(5);
ShowArray(MyArray);


Console.WriteLine ($"{Quantity} чисел больше 0 было введено");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями 
//  у = k1 * x + b1, y = k2 * × + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// у = k1 * x + b1,
// y = k2 * × + b2

// 5х+2=9х+4
// 4х=-2
// Х=-0,5
// У=5*(-0,5)+2=-0,5