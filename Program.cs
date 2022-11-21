﻿// Урок 3. Базовые алгоритмы. Продолжение

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999)
{
  int a = num / 10000;
  int b = num % 10;
  int c = (num / 1000) - (num / 10000) * 10;
  int d = num % 100 / 10;
  if (a == b && c == d)
  {
     Console.WriteLine("является палиндромом"); 
  }
  else
  Console.WriteLine("не является палиндромом");  
}
else
Console.WriteLine("Вы ввели не пятизначное число!");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125