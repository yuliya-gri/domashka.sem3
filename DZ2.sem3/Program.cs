//Напишите программу, которая на вход принимает пятизначное число и проверяет,является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10000;
int num2 = num%10000/1000;
int num4 = num%100/10;
int num5 = num%10;

if (num1 == num5 && num2 == num4) 
{
    Console.WriteLine("Данное число палиндром");
}

else
{
    
    Console.WriteLine("Данное число не палиндром");
}