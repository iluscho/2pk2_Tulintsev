// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 10 чисел через enter");
int a = 0;
double[] mass = new double[10];
double plus = 0;
double umnoj = 1;

for (int i = 0; i < 10; i++)
{
mass[a] = Convert.ToDouble(Console.ReadLine());
a++;
}

for (int i = 0; i < 10; i++)
{
    plus += mass[i];
}
Console.WriteLine($"Результат сложения: {plus}");

for (int i = 0; i < 10; i++)
{
    umnoj *= mass[i];
}
Console.WriteLine($"Результат умножения: {umnoj}");

Console.Write("Массив: ");
foreach (int i in mass)
{
    Console.Write($"{i} ");
}

