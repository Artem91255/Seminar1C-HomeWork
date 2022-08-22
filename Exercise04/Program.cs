// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = 2;
if(x==y)
{
    Console.WriteLine(y);
}
while(y<x)
{
    Console.Write(y + ", ");
    y=y+2;
    
}
