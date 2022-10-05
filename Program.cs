/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Решаем с помощью "/" и "%", со строками не работаем 

Console.WriteLine("Введите число:");
int number1 = int.Parse(Console.ReadLine()!);
int num2 = number1 % 100;
int num3 = num2 / 10;
Console.WriteLine($"Вторая цифра {number1} {num3}");*/

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000) 

Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 / 10;
int num3 = num1 / 100;
if ((num1 >= 100) && (num1 <= 999))
{
    Console.WriteLine(num1 % 10);
}
else if ((num1 >= 1000) && (num1 <= 9999))
{
    Console.WriteLine(num2 % 10);
}
else if ((num1 >= 10000) && (num1 <= 100000))
{
    Console.WriteLine(num3 % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}*/

/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Обязательно сделать проверку на ввод чисел меньше 1 и больше 7*/



Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 == 1){
    Console.WriteLine("Понедельник нет");
}
else if (num1 == 2){
    Console.WriteLine("Вторник нет");
}
else if (num1 == 3){
    Console.WriteLine("Среда нет");
}
else if (num1 == 4){
    Console.WriteLine("Четверг нет");
}
else if (num1 == 5){
    Console.WriteLine("Пятница нет");
}
else if (num1 == 6){
    Console.WriteLine("Суббота да");
}
else if (num1 == 7){
    Console.WriteLine("Воскресенье да");
}
else{
    Console.WriteLine("Error");
}