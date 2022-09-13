//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
void Cube(int num)
{
  int index=1;
  while (index<=num)  
  {
    Console.Write(+Math.Pow(index,3) +",");
    index++;
  }
}
