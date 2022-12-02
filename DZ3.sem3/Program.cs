//написать программу ,которая принимает на ввод число N и выдает таблицу кубов
Console.WriteLine("Напишите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов числа:");
if(N < 0) N = -N;
else 
if(N == 0)
{
    Console.WriteLine("0");
}
for(int i =1; i <= N; i++)
{
    int InCube = (i*i*i);
    Console.WriteLine($"{InCube}");
}
