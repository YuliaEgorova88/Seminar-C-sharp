﻿//0. Вывести квадрат числа


/*Console.Write("Введите число, квадрат кторого будем искать: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(n * n);*/




//1. По двум заданным числам проверять является ли первое квадратом второго

/*Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n == n2 * n2) {
Console.Write("Число " + n + " является квадратом числа " + n2);
}
else {
   Console.Write("Число " + n + " не является квадратом числа " + n2); 
}*/




//2. Даны два числа. Показать большее и меньшее число

/*Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n > n2){
    Console.WriteLine("Число "  + n  + " большее");
    Console.Write("Число "  + n2  + " меньшее");
}
else {
    Console.WriteLine("Число "  + n2  + " большее");
    Console.Write("Число "  + n  + " меньшее");
}*/




//3. По заданному номеру дня недели вывести его название

/*Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) {
  Console.WriteLine("Понедельник");  
} else if (day == 2) {
   Console.WriteLine("Вторник");  
} else if (day == 3) {
   Console.WriteLine("Среда");  
} else if (day == 4) {
   Console.WriteLine("Четверг");  
} else if (day == 5) {
   Console.WriteLine("Пятница");  
} else if (day == 6) {
   Console.WriteLine("Суббота");  
} else if (day == 7) {
   Console.WriteLine("Воскресенье");  
} else {
    Console.WriteLine("Дня недели с таким номером нет.");
}*/




//4. Найти максимальное из трех чисел

/*Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max;

if (n > n2 && n > n3) {
    max = n;
    Console.WriteLine("Максимальное число " + n);
}
else if (n2 > n && n2 > n3) {
    max = n2;
    Console.WriteLine("Максимальное число " + n2);
}
else {
  Console.WriteLine("Максимальное число " + n3);  
}*/





//5. Написать программу вычисления значения функции y = f(a)

// y = a^2 + 2

/*double function(double a) 
{
    return a * a + 2;
}

Console.WriteLine("Введите знаение переменной a");
double a = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Значение y {function(a)}");*/





//6. Выяснить является ли число чётным

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("Число " + num + " четное");
}
else {
    Console.WriteLine("Число " + num + " нечетное"); 
}*/




//7. Показать числа от -N до N

/*Console.Write("Введите число: ");
int nMax = Convert.ToInt32(Console.ReadLine());
int nMin;
nMin = -nMax;

while (nMin <= nMax) {
    Console.WriteLine(nMin);
    nMin++;
}*/




//8. Показать четные числа от 1 до N

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 2;

while (result <= number) {   
        Console.WriteLine(result);
    result +2;
    }
}*/


//9. Показать последнюю цифру трёхзначного числа

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Последняя цифра числа " + number + " равна " + number % 10);*/





//10. Показать вторую цифру трёхзначного числа

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Предпоследняя цифра числа " + number + " равна " + number % 100 / 10);*/





//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

/*Console.WriteLine("Введите число от 10 до 99: ");
int num = int.Parse(Console.ReadLine());

int first = num / 10;
int second = num % 10;

if (first > second) {
    Console.Write("Наибольша цифра числа " + num + " = " + first);
}
else {
  Console.Write("Наибольша цифра числа " + num + " = " + second);
}*/





//12. Удалить вторую цифру трёхзначного числа

/*int Number = new Random().Next(100, 999);
Console.WriteLine("Вторая цифра трехзначного числа: " + Number + " это цифра " + Number %100 / 10);
int num1 = Number / 100;
int num2 = Number % 10;
Console.WriteLine("Удаляем вторую цифру числа " + Number + " получаем число " + num1 + num2);*/
//Console.WriteLine("Первая цифра числа " + Number + " это " + num1);
//Console.WriteLine("Последняя цифра числа " + Number + " это " + num2);





//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

/*int Number1 = new Random().Next(1, 100);
int Number2 = new Random().Next(1, 100);
Console.WriteLine("Первое заданное число: " + Number1);
Console.WriteLine("Второе заданное число: " + Number2);

if(Number1 < Number2) {
    Console.Write("Число " + Number1 + " меньше числа  " +  Number2);
}
else if(Number1 % Number2 == 0) {
    Console.WriteLine("Число " + Number1 + " кратно числу " + Number2);
}
else {
    Console.Write("Заданное число " + Number1 + " не кратно числу " + Number2 + " ,остаток от деления = " +  Number1 % Number2);
}*/





//14. Найти третью цифру числа или сообщить, что её нет

/*int number = new Random().Next(1, 5000);

if (number < 100)
    Console.WriteLine("Третья цифра в числе " + number + " отсуствует");
else if(number >= 100 && number <= 999)
{
    Console.WriteLine("Третья цифра числа " + number + " это " + number % 10);
}
else {
    Console.WriteLine("Третья цифра числа " +  number + " это " + number % 100 / 10);
}*/





//Почувствуй себя джуном*
//15. Дано число. Проверить кратно ли оно 7 и 23

//Вариант 1: 
/*int Number = new Random().Next(1, 100);

if(Number % 7 == 0 && Number % 23 == 0) 
Console.WriteLine("Число " + Number + " кратно обоим числам: и 7 и 23 ");
else if(Number % 7 == 0)
{
    Console.WriteLine("Число " + Number + " кратно числу 7, но не кратно 23");
}
else if(Number % 23 == 0)
{
    Console.WriteLine("Число " + Number + " кратно числу 23, но не кратно 7");
}
else
{
    Console.Write("Число " + Number + " не кратно обоим числам : ни 7, ни 23");
}*/

//Вариант 2: 

//int Number1 = new Random().Next(1, 5000); //Такой  вариант тоже возможен 
/*int Number1 = 500;
for(int i = 1; i < Number1; i++) {
    if(i % 7 == 0 && i % 23 == 0)
    Console.WriteLine($"Число {i} кратно числам 7 и 23");
}*/




//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

//string[] WeekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//int n = WeekDays.Length;
/*int[] WeekDaysNum = new int[WeekDays.Length];
for(int i = 0; i < WeekDays.Length; i++) {
    WeekDaysNum[i] = int.Parse(WeekDays[i]);
}
for(int i = 0; i < WeekDaysNum.Length; i++) {
    Console.WriteLine(WeekDaysNum[i]);
}*/
/*Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 | day == 7) {
  Console.WriteLine("День недели номер " + day + " является выходным");  
} else if (day == 2 | day == 1 | day == 3 | day == 4 | day == 5) {
    Console.WriteLine("Этот день - будний");
} else {
    Console.WriteLine("Дня недели с таким номером нет.");
}*/




//17. По двум заданным числам проверять является ли одно квадратом другого

 
/*int a = new Random().Next(1, 99);
Console.WriteLine(a);
int b = new Random().Next(1, 99);
Console.WriteLine(b);

if (a == b*b || b == a*a)
{
    Console.WriteLine("Одно число из двух явно является квадратом другого");
}

else if(a == b * b) {
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else if(b == a * a) {
    Console.WriteLine("Число " + b + " является квадратом числа " + a);
}
else {Console.WriteLine("Квадратов тут не найдено");
}*/


//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// НЕ(Х или(||) Y) = НЕх и(&&) НЕy

//bool x = false;     //Вырыжение получается истинным при любых значениях y и x
//bool y = false;

//bool x = false;     //Вырыжение получается истинным при любых значениях y и x
//bool y = true;

//bool x = true;      //Вырыжение получается истинным при любых значениях y и x
//bool y = false;

/*bool x = true;        //Вырыжение получается истинным при любых значениях y и x
bool y = true;

Console.WriteLine(!(x || y));
Console.WriteLine(!x && !y);
if((!(x || y)) == (!x && !y)) {
    Console.WriteLine("Выражение " + " (!(x || y)) == (!x && !y)) " + " истинно");
}
else {
    Console.WriteLine("Выражение не истинно");
}*/


//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


//Первый вариант

/*int x = new Random().Next(-99, 99);
Console.WriteLine(x);
int y = new Random().Next(-99, 99);
Console.WriteLine(y);

if (x ==0 || y ==0)
{
    Console.WriteLine("Одна из точек равна нулю");
}
else if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка в первой четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка во второй четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка в четвертой четверти четверти");
    }
    else Console.WriteLine("Точка в третьей четверти");


//Второй вариант

Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine("I четверть");
                else if (y < 0)
                    Console.WriteLine("IV четверть");
            }
            else if (x < 0)
            {
                if (y > 0)
                    Console.WriteLine("II четверть");
                else if (y < 0)
                    Console.WriteLine("III четверть");
            }

            Console.ReadLine();*/

//20. Задать номер четверти, показать диапазоны для возможных координат


/*Console.WriteLine("Задайте номер четверти: ");
int number =Convert.ToInt32(Console.ReadLine());

if(number == 1) {
    Console.WriteLine("Диапозон для возможных координат: Х от 1 до бесконечности, Y от 1 до бесконечности ");
}
else if(number == 2) {
    Console.WriteLine("Диапозон для возможных координат: Х от -1 до бесконечности, Y от 1 до бесконечности ");
}
else if(number == 3) {
    Console.WriteLine("Диапозон для возможных координат: Х от -1 до бесконечности, Y от -1 до бесконечности ");
}
else if(number == 4) {
    Console.WriteLine("Диапозон для возможных координат: Х от 1 до бесконечности, Y от -1 до бесконечности ");
}
else {
    Console.WriteLine("Вы ввели неверный номкр четверти.");
}*/


//21. Программа проверяет пятизначное число на палиндромом.

/*int a = 51015; //new Random().Next(10000, 99999);
Console.WriteLine(a);

if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10) 
{
    Console.WriteLine("Число палиндром");
}
else Console.WriteLine("Число не палиндром");



//Программа проверяет пятизначное число на палиндромом.
int number = new Random().Next(10000, 99999);
String s = number.ToString();
Console.WriteLine("Число: " + number);
if (s[0] == s[4] && s[1] == s[3])
{
    Console.WriteLine("Число - палиндром");
}
else
    Console.WriteLine("Число - не палиндром");*/


//22. Найти расстояние между точками в пространстве 2D/3D

//2D

/*double AB1;
double AB2;
int Xb = 4;
int Xa = 1;
int Yb = 7;
int Ya = 9;
int stepen = 2;
int arg1 = Xb - Xa;
int arg2 = Yb - Ya;

AB1 = Math.Pow(arg1, stepen);
AB2 = Math.Pow(arg2, stepen);

double result = Math.Sqrt(AB1 + AB2);

Console.WriteLine(result);*/

//3D

/*double AB1;
double AB2;
double AB3;
int Xb = 3;
int Xa = 5;
int Yb = 6;
int Ya = 2;
int Zb = 7;
int Za = 9;

int stepen = 2;
int arg1 = Xb - Xa;
int arg2 = Yb - Ya;
int arg3 = Zb - Za;

AB1 = Math.Pow(arg1, stepen);
AB2 = Math.Pow(arg2, stepen);
AB3 = Math.Pow(arg3, stepen);

double result = Math.Sqrt(AB1 + AB2 + AB3);

Console.WriteLine(result);*/


//Почувствуй себя мидлом*

//23. Показать таблицу квадратов чисел от 1 до N

/*int N = new Random().Next(1, 19);
Console.WriteLine(N);

for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"{i} * {i} = {i*i}");
}



Console.WriteLine("Введите кол-во чисел для вывода:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Число" + "\t");
            for (int i = 1; i <= N; i++)
                Console.Write(i + "\t");
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
                Console.Write(i * i + "\t");

            Console.ReadLine();*/


//24. Найти кубы чисел от 1 до N

/*int number = new Random().Next(1, 10);
Console.WriteLine(number);

for (int i = 0; i <= number; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
}*/

//25. Найти сумму чисел от 1 до А

/*Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int result = 0;
for(int i = 1; i <= A; i++) 
{
   result = (A * (A + 1)) / 2;
}
Console.WriteLine(result);*/

//26. Возведите число А в натуральную степень B используя цикл



/*27. Определить количество цифр в числе
28. Подсчитать сумму цифр в числе
29. Написать программу вычисления произведения чисел от 1 до N
30. Показать кубы чисел, заканчивающихся на четную цифру

Почувствуй себя сеньором*
31. Задать массив из 8 элементов и вывести их на экран
32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
34. Написать программу замену элементов массива на противоположные
35. Определить, присутствует ли в заданном массиве, некоторое число
36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Почувствуй себя лидом*
41. Выяснить являются ли три числа сторонами треугольника
42. Определить сколько чисел больше 0 введено с клавиатуры
43. Написать программу преобразования десятичного числа в двоичное
44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
45. Показать числа Фибоначчи
46. Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
47. Написать программу копирования массива*/
