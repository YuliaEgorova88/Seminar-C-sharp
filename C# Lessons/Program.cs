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

while (result <= number && result != 0) {   
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
//12. Удалить вторую цифру трёхзначного числа
//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//14. Найти третью цифру числа или сообщить, что её нет
