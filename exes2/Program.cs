﻿// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
System.Console.WriteLine("Случайное рандомное число : " + number);

int result = (number / 100) * 10 + number % 10;

System.Console.WriteLine("Чило без второго символа : " + result);