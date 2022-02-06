//0. Вывести квадрат числа


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
int result = 1;

while (result <= number) {   
    result ++;
    if(result % 2 == 0){
        Console.WriteLine(result);
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

string[] WeekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
/*int[] WeekDaysNum = new int[WeekDays.Length];
for(int i = 0; i < WeekDays.Length; i++) {
    WeekDaysNum[i] = int.Parse(WeekDays[i]);
}
for(int i = 0; i < WeekDaysNum.Length; i++) {
    Console.WriteLine(WeekDaysNum[i]);
}*/
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 | day == 7) {
  Console.WriteLine("День недели номер " + day + " является выходным");  
} else if (day == 2 | day == 1 | day == 3 | day == 4 | day == 5) {
    Console.WriteLine("Этот день - будний");
} else {
    Console.WriteLine("Дня недели с таким номером нет.");
}




/*17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Задать номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D*/
