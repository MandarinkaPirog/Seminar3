//Задача 21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

int[] num1 = new int[3];
int[] num2 = new int[3];
Console.Write("Введите координаты точки А:");
Console.Write("X=");
num1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
num1[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z=");
num1[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B:");
Console.Write("X=");
num2[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
num2[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z=");
num2[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Расстояние между точками в 3D пространстве:" + num3(num1,num2));
double num3 (int [] arrayA,int [] arrayB)
{
double longNumber= Math.Sqrt(Math.Pow(arrayB[0]- arrayA[0],2)+Math.Pow(arrayB[1]- arrayA[1],2)
+Math.Pow(arrayB[2]- arrayA[2],2));
return Math.Truncate(100* longNumber)/100;
}


 