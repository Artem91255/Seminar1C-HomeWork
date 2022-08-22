// Задача 5: Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

int y = -1*x;

while(y<=x)
{
    Console.Write(y + ", ");
    y++;
}