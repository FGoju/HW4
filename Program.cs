/*
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Nums (int a, int b)

{
    int exponentiation = a;
    for(int i = 2; i<=b; i++)
    exponentiation = exponentiation * a;
    return exponentiation;
}

Console.WriteLine(Nums(3, 5));
Console.WriteLine(Nums(2, 4));
*/

/*
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0) 
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine (sum);

int sumnum(int num)
{
    int n_sum = 0;

    for (int i = num; num != 0; num /= 10)
    n_sum +=num%10;
    return n_sum;
}

// Console.WriteLine ...
*/

/*
// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран

int[] arr(int num)
{
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(0, 10);
    }
    return array;
}
arr(8);

void PrintArray (int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.WriteLine($"{array2[i]} ");
}
PrintArray(arr(8));
*/


