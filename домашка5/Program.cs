// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int []arr (int n)
{
    int []a = new int [n]; 
    for (int i=0; i<n; i++)
    {
        a[i] =new Random().Next(100,999+1);
        Console.Write($"{a[i]} ");
    }
    return a;
}
Console.WriteLine("введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int []a = arr(N);
Console.WriteLine();
int count =0;
for (int i=0; i<N; i++)
{
 if (a[i]%2==0)
    {
        count++;  
    }   
}
Console.WriteLine(count); 
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int []arr (int n, int x, int z)
{
    int []a = new int [n]; 
    for (int i=0; i<n; i++)
    {
        a[i] =new Random().Next(x,z+1);
        Console.Write($"{a[i]} ");
    }
    return a;
}
Console.WriteLine("введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите min ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите max ");
int Z = Convert.ToInt32(Console.ReadLine());
int []A = arr(N,X,Z);
Console.WriteLine();
int sum =0;
for (int i=0; i<N; i++)
{
 if (i%2==1)
    {
        sum =sum+ A[i];  
    }   
}
Console.WriteLine(sum); 
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76
double []arr (int n, int x, int z)
{
    double []a = new double [n]; 
    for (int i=0; i<n; i++)
    {
        a[i] =new Random().Next(x,z+1)+ new Random().NextDouble();
        Console.Write($"{a[i]} ");
    }
    return a;
}
Console.WriteLine("введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите min ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите max ");
int Z = Convert.ToInt32(Console.ReadLine());
double []A = arr(N,X,Z);
Console.WriteLine();
//поиск максим и мин числа
double Max (double []a)
{
 double max =0;
for (int i=0; i<a.Length; i++)
{
 if (a[i]>max)
    {
        max = a[i];  
    }   
}
return max; 
}
Console.WriteLine(Max(A)+ " максимальное");

double Min (double []a)
{
 double min =a[0];
for (int i=0; i<a.Length; i++)
{
 if (a[i]<min)
    {
        min = a[i];  
    }   
}
return min; 
}
Console.WriteLine(Min(A)+" минимальное");
Console.WriteLine($"{Max(A)-Min(A)} разница между максимальным и минимальным");

