//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1 целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("{0} - максимальное число, {1} - минимальное число", num1, num2);
}
else
{
    Console.WriteLine("{0} - максимальное число, {1} - минимальное число", num2, num1);
} 
