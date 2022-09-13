//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);
if (num1[0]==num1[4] && num1[1]==num1[3])
{
   Console.Write("Введенное число - палиндром");
}
else
{
Console.Write("Введенное число - не палиндром");
}