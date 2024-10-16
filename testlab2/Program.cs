using System;
using testlab2;

Console.WriteLine("Введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Class1 cl = new Class1();
if (cl.IsPalindrome(number1) || cl.IsPalindrome(number2))
{
    Console.WriteLine("Хотя бы одно из чисел является палиндромом.");
}
else
{
    Console.WriteLine("Ни одно из чисел не является палиндромом.");
}