//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result=1;
while (result<number)
{
    Console.WriteLine(result+1);
    result=result+2;
}
