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
} else if (day < 6 && day > 0) {
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

//bool x = false;     
//bool y = false;

//bool x = false;     
//bool y = true;

//bool x = true;      
//bool y = false;

/*bool x = true;        
bool y = true;

Console.WriteLine(!(x || y));
Console.WriteLine(!x && !y);
if((!(x || y)) == (!x && !y)) {
    Console.WriteLine("Выражение " + " (!(x || y)) == (!x && !y)) " + " истинно");
}
else {
    Console.WriteLine("Выражение не истинно");
}
//bool x = false;     
//bool y = false;
if((!(x || y)) == (!x && !y)) {
    Console.WriteLine($"Выражение {(!(x || y)) == (!x && !y))} истинно для {x}, {y}");
}
//bool x = false;     
//bool y = true;
if((!(x || y)) == (!x && !y)) {
    Console.WriteLine($"Выражение {(!(x || y)) == (!x && !y))} истинно для {x}, {y}");
}
//bool x = true;      
//bool y = false;
if((!(x || y)) == (!x && !y)) {
    Console.WriteLine($"Выражение {(!(x || y)) == (!x && !y))} истинно для {x}, {y}");
}
/*bool x = true;        
bool y = true;

if((!(x || y)) == (!x && !y)) {
    Console.WriteLine($"Выражение {(!(x || y)) == (!x && !y))} истинно для {x}, {y}");
}
*/

//variant!!!
/*bool[] all = {true, false};

bool result = true;

for(int i = 0; i <all.Length; i++)
{
    for(int j = 0; j <all.Length; j++)
    {
        if( !(all[i] || all[j]) == (!all[i] && !all[j]))
        {
            Console.WriteLine($"Для набора x = {all[i]}, y = {all[j]} выражение истинно");
        }
        else
        {
            Console.WriteLine($"Для набора x = {all[i]}, y = {all[j]} выражение ложно");
            result = false;
            break;
        }

    }
}

if(result)
{
    Console.WriteLine($"Доказано что утверждение истинно");
} else
{
    Console.WriteLine($"Доказано что утверждение ложно");
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

/*Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int res = 1;

for(int i = 0; i < B; i++) {
    res *= A; 
}
Console.WriteLine("{0} в степени {1} = {2} ", A, B, res);*/


//27. Определить количество цифр в числе

//int a = 1000; //new Random().Next (1,9999);
//string s = a.ToString();
//Console.WriteLine(s.Length);


/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 0;

while (number >= 1)
{
    number = number / 10;
    i++;
}
Console.WriteLine("Количество цифр в заданном числе равно " + i);*/

//28. Подсчитать сумму цифр в числе


/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int summ = 0;

while(number > 0) {
    summ += number % 10;
    number = number / 10;
}

Console.WriteLine(summ);*/

//29. Написать программу вычисления произведения чисел от 1 до N

/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());


int Factor(int num) {
    int result = 1;
    for(int i = 1; i <= num; i++) {
        result *= i;
    }
    return result;
}

Console.WriteLine(Factor(number));*/



//30. Показать кубы чисел, заканчивающихся на четную цифру

/*int number = new Random().Next(1, 100);
Console.WriteLine(number);

Console.WriteLine("Число, взятое для подсчетов " + number);
for (int i = 1; i <= number; i++)
{ 
    if(i*i*i % 10 % 2 == 0){
        Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
    }
    
}*/

/*****
for (int i = 2; i <= number; i+=2)
{
Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
}*/


//Почувствуй себя сеньором*

//31. Задать массив из 8 элементов и вывести их на экран

//int[] massive = { 8, 6, 9, 3, 0, 1, 4, 2 };

//for (int i = 0; i < array.Length; i++)
//{
// Console.Write(array[i] + " ");
//}*/

/*void function(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    Console.WriteLine(array[i]);
}
function(massive);*/




//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

/*int[] MyArray = new int[8];

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0, 2);
        index++; 
    }
}

FillArray(MyArray);
for (int i = 0; i < MyArray.Length; i++)
{
   Console.Write(MyArray[i] + " ");
}

*/



/*33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

/*int[] mat = new int[12];
int sumP = 0;
int sumN = 0;
for (int i = 0; i < mat.Length; i++)
{
    mat[i] = new Random().Next(0, 10);
    Console.Write(mat[i] + ";");
}
Console.WriteLine();
for (int i = 0; i < mat.Length; i++)
{
    if (mat[i] > 0)
        sumP = sumP + mat[i];
    else
        sumN = sumN + mat[i];
}
Console.WriteLine($"Сумма положительных элементов = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов = {sumN}");*/



//34. Написать программу замену элементов массива на противоположные

/*void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-20, 10);
        index++;
    }
}

void PrintArray(int[] array2)
{
    int count = array2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array2[position]);
        position++;
    }
}

void ChangeElements(int[] array3)
{
    int count = array3.Length;
    int position = 0;
    while (position < count)
    {
        array3[position] = -array3[position];
        Console.WriteLine(array3[position]);
        position++;
    }
}



int[] array = new int[10];

FillArray(array);

PrintArray(array);
Console.WriteLine();

ChangeElements(array);
Console.WriteLine();*/


//35. Определить, присутствует ли в заданном массиве, некоторое число

/*int[] mat = new int[12];

Console.WriteLine("Массив");
for (int i = 0; i < mat.Length; i++)
{
    mat[i] = new Random().Next(0, 10);
    Console.Write(mat[i] + ";");
}
Console.WriteLine();
Console.WriteLine("Введите искомое число");
int x=int.Parse(Console.ReadLine());
bool exist=false;
for (int i = 0; i < mat.Length; i++)
{
    if (mat[i]==x)
    {
        exist=true;
        break;
    }
}
if (exist) Console.WriteLine($"В массиве присутствует искомое число {x}");
else Console.WriteLine($"В массиве  не присутствует искомое число {x}");*/


//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

/*void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 500);
        index++;
    }
}

void ArrayPrint(int[] even)
{
    int count = even.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(even[position]);
        position++;
    }
}

void ArrayEven(int[] even)
{
    int count = even.Length;
    int pos = 0;
    int resultPos = 0;
    int resultNeg = 0;
    while (pos < count)
    {
        if (even[pos] % 2 == 0)
        {
            resultPos++;
        }
        else if (even[pos] % 2 == 1)
        {
            resultNeg++;
        }

        pos++;
    }
    Console.WriteLine("Кол-во четных чисел в массиве = " + resultPos);
    Console.WriteLine("Кол-во нечетных чисел в массиве = " + resultNeg);

}

int[] array = new int[5];

FillArray(array);


ArrayPrint(array);
Console.WriteLine();

ArrayEven(array);
Console.WriteLine();*/


//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


/*int[] array = new int [123];

for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(0, 1000);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine();
int count = 0;
for(int i = 0; i<array.Length; i++)
{
    if(array[i]>=10 && array[i]<=99) 
    {
        count++;
        Console.Write(array[i] + " ");
    }

}
Console.WriteLine("\n Количество элементов из диапазона 10 - 99 равно " + count);*/


//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции


/*void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 50);
        index++;
    }
}

void ArrayPrint(int[] even)
{
    int count = even.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(even[position]);
        position++;
    }
}

void SummArray(int[] numbers)
{
    int count = numbers.Length;
    int i = 1;
    int summ = 0;

    while (i < count)
    {
        summ += numbers[i];
        i = i + 2;
    }
    Console.WriteLine("Сумма чисел, стоящих на нечетной позиции в массиве = " + summ);
}

int[] array = new int[10];

FillArray(array);


ArrayPrint(array);
Console.WriteLine();

SummArray(array);
Console.WriteLine();*/



//39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/*int[] array = new int [8];
int result = 1;
for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(1, 100);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine();
for (int i = 0; i< (array.Length+1)/2;i++)
{
    result = array[i]*array[array.Length-1-i];
    Console.WriteLine($"Произведение {array[i]} и {array[array.Length-1-i]} = {result}");
}*/



//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


/*void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void ArrayPrint(int[] even)
{
    int count = even.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(even[position]);
        position++;
    }
}*/

/*void MaxArray(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    Console.WriteLine("Максимальный элемент в массиве = " + max);
}

void MinArray(int[] numbers)
{
    int min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }

    Console.WriteLine("Минимальный элемент в массиве = " + min);
}*/


/*void MinMaxArray(int[] numbers)
{
    int max = numbers[0];
    int min = numbers[0];
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
    Console.WriteLine("Минимальный элемент в массиве = " + min);
    Console.WriteLine("Максимальный элемент в массиве = " + max);
    result = max - min;
    Console.WriteLine("Разница минимального и максимального элементов массива = " + result);
}



int[] array = new int[5];

FillArray(array);


ArrayPrint(array);
Console.WriteLine();

MinMaxArray(array);
Console.WriteLine();*/
/*MinArray(array);
Console.WriteLine();

MaxArray(array);
Console.WriteLine();*/

//variant!!!
/*for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] > max)
max = numbers[i];
if (numbers[i] < min)
min = numbers[i];
}


Console.WriteLine("Разница минимального и максимального элементов массива = " + (max - min));*/



/*Почувствуй себя лидом*

41. Выяснить являются ли три числа сторонами треугольника

Random rand = new Random();
int a = 55; //rand.Next(1, 50);
Console.WriteLine(a);
int b = 6; //rand.Next(1, 50);
Console.WriteLine(b);
int c = 8; //rand.Next(1, 50);
Console.WriteLine(c);

if ((a + b > c) && (b + c > a) && (a + c > b)) Console.WriteLine("Числа являются сторонами треугольника");
else Console.WriteLine("Числа не являются сторонами треугольника");*/


//42.Определить сколько чисел больше 0 введено с клавиатуры



/*Console.WriteLine("Введите числа через пробел: ");
string text = Console.ReadLine();



var data = text.Split(" ")
               .Select(Int32.Parse)
               .ToArray();

int count = 0;

for (int i = 0; i < data.Length; i++)
{
    if (data[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Чисел больше 0 введено с клавиатуры: " + count);*/


/*43. Написать программу преобразования десятичного числа в двоичное

//variant1:
int a = new Random().Next(1, 100);
string result = " ";
while (a > 0)
{
    result = (a % 2) + result;
    a = a / 2;
}
Console.WriteLine(result);*/

//variant2:


/*Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int b;
string result = " ";
while (num > 0)
{
    num /= 2;
    b = num % 2;
    result = b + result;
}

result += num;
int number = int.Parse(result.Replace(" ", ""));
Console.WriteLine(number);*/


//44.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

/*   y = k1 * x + b1
     y = k2 * x + b2

      y = (k1 * x + b1) - (k2 * x + b2) 


k1 * x - k2 * x = b2 - b1
x * (k1 - k2) = b2 - b1

x = (b2 - b1) / (k1 -k2)

y = (k1 * ((b2 - b1) / (k1 - k2))) + b1*/


/*
double y;
double x;

double b1 = new Random().Next(1, 6);
double k1 = new Random().Next(1, 7);
double b2 = new Random().Next(1, 5);
double k2 = new Random().Next(1, 8);

Console.WriteLine("b1 = " + b1);
Console.WriteLine("k1 = " + k1);
Console.WriteLine("b2 = " + b2);
Console.WriteLine("k2 = " + k2);


x = (b2 - b1) / (k1 - k2);
y = (k2 * x) + b2;


Console.WriteLine();
Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("Координаты точки пересечения двух прямых: " + "(" + x + " ; " + y + ")");*/


/*45. Показать числа Фибоначчи

int num = 10;
            int f1 = 1;
            int f2 = 1;
            int result;

            for (int i = 0; i < num; i++)
            {
                result = f1 + f2;
                Console.Write(result + " ");

                f1 = f2;
                f2 = result;
            }
            
       
int a=0;
int b=1;
int count=10;
for (int i = 0; i < count; i++)
{
    Console.Write($"{a}, {b}, ");
    a=a+b;
    b=b+a;
} */


//46. Написать программу масштабирования фигуры

/*Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/


/*using System.Linq;

string FigureHeights = "(0,0) (2,0) (2,2) (0,2)"
                        .Replace("(", "")
                        .Replace(")", "");
Console.WriteLine(FigureHeights);

var coeff = 2;
var data = FigureHeights.Split(" ")
                         .Select(item => item.Split(','))
                         .Select(elem => (x: int.Parse(elem[0]), y: int.Parse(elem[1])))
                         .Select(point => (point.x * coeff, point.y * coeff))
                         .ToArray();



for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);

}*/



/*47. Написать программу копирования массива


void FillArray (int[] arrays)
{
    for (int i = 0; i < arrays.Length; i++)
    arrays[i] = new Random().Next(100, 1000);
}
void PrintArray (int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "   ");        
    }
    Console.WriteLine();
}
void CopyArray (int[] arr, int[] arrays)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arrays[i] = arr[i];        
    }
    Console.WriteLine();
}
int[] array = new int[8];
int[] newArray = new int[array.Length];
FillArray(array);
PrintArray(array);
CopyArray(array, newArray);
//newArray = array;
PrintArray(newArray);
newArray[3] = 0;
PrintArray(array);
PrintArray(newArray);
*/


//Двумерные массивы
//48. Показать двумерный массив размером m×n заполненный целыми числами

/*void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100) ; // заполняем числами [0,100)
        }
    }
}
int[,] array = new int[3,4];
FillArray(array);
PrintArray(array);*/



//49. Показать двумерный массив размером m×n заполненный вещественными числами

/*Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

double[,] NewArray(int a, int b)
{
    double[,] array = new double[a, b];
    return array;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().Next(1, 10) + new Random().NextDouble()), 4);
        }

    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


double[,] array = NewArray(num1, num2);
FillArray(array);
PrintArray(array);*/



/*50. В двумерном массиве n×k заменить четные элементы на противоположные


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
    }
}
Console.WriteLine();
PrintArray(array);*/



//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n


/*
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }



Console.WriteLine();
PrintArray(array);*/


/*
52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i+=2)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
        array[i, j] = array[i, j] *  array[i, j];
    }
}
Console.WriteLine();
PrintArray(array);
*/



//53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
/*
int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число: ");
int numberPosition = int.Parse(Console.ReadLine());

void FindElement(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"Число {num} находится в строке {i + 1} и столбце {j + 1}");
                count++;
            }
        }
    if (count == 0) Console.WriteLine($"Числа {num} нет в массиве.");
}

int[,] MyArray = NewArray(num1, num2);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
FindElement(MyArray, numberPosition);*/

/*
54. В матрице чисел найти сумму элементов главной диагонали

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(i==j) 
        {
            sum += array[i, j];
        }
    }
}
Console.WriteLine(sum);


ВАРИАНТ КОРОЧЕ!!!!
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int sum = 0;
int size = 0;
if ( m > n) size = m;
else size = m;
for (int i = 0; i < array.GetLength(0); i++)
{
 sum += array[i, i];
}
Console.WriteLine(sum);
*/



//55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
/*
Console.WriteLine("Введите количество строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int coll = int.Parse(Console.ReadLine());

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArraySecond(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        Console.Write($"{matr[i]} ");
    }
}

int[] Average(int[,] array)
{
    int[] array1 = new int[array.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        array1[i] = sum / array.GetLength(1);
        sum = 0;
    }
    return array1;
}

int[,] MyArray = NewArray(str, coll);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
PrintArraySecond(Average(MyArray));*/

/*
56. Написать программу, которая обменивает элементы первой строки и последней строки

for (int i = 0; i < array.GetLength(1); i++)
{
    int num = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = num;
}

от vadik sergeev для Все (10:32)




void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}


int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
int k=0;
for (int i = 0; i < array.GetLength(1); i++)
{
    int num = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = num;
}
Console.WriteLine();
PrintArray(array);*/


/*
//57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    return matr;
}

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

Console.WriteLine("Введите количество строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int coll = int.Parse(Console.ReadLine());

int[,] ReplaceElement(int[,] array, int num)
{
    int score = 0;
    for (int a = (array.GetLength(1) - 1); a != 0; a--)
        for (int i = 0; i < a; i++)
        {
            if (array[num, i] < array[num, i + 1])
            {
                score = array[num, i + 1];
                array[num, i + 1] = array[num, i];
                array[num, i] = score;
            }
        }
    return array;
}

int[,] ReplaceAllElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) ReplaceElement(array, i);
    return array;
}

int[,] MyArray = NewArray(str, coll);
PrintArray(FillArray(MyArray));
Console.WriteLine();
PrintArray(ReplaceAllElements(MyArray));
*/


/*58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}

if (n == m)
{
    for (int i = 0; i < array.GetLength(1); i++)

        for (int j = 0; j < i; j++)
        {
            int num = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = num;
        }
}
else
{
    Console.WriteLine("Поменять местами строки и столбцы нельзя. Матрица не квадратная");
}

Console.WriteLine();
PrintArray(array);

//////////////////////////////////////////////
for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j]=array[j,i];
        }
    }
    PrintArr(mass);


*/
//59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
/*
//Console.WriteLine("Введите количество строк");
int str = 3;//int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
int coll = 7;//int.Parse(Console.ReadLine());

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] SummElements(int[,] array)
{
    int[] array1 = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array1[i] = sum;
        sum = 0;
    }
    return array1;
}

int MinimalElement(int[] array)
{
    int minValue = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minValue < array[1])
        {
            minValue = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

void PrintMinElement(int[,] array, int[] array1)
{
    array1 = SummElements(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[MinimalElement(array1), j]} ");
    }
    Console.WriteLine($" Сумма данной строки: {array1[MinimalElement(array1)]}");
}

int[,] MyArray = NewArray(str, coll);
int[] Amount = new int[MyArray.GetLength(0)];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
PrintMinElement(MyArray, Amount);


*//*
60. Составить частотный словарь элементов двумерного массива
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: Есть набор данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }
частотный массив может быть представлен так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
Если набор данных - таблица
1, 2, 3
4, 6, 1
2, 1, 6
на выходе ожидаем получить
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
Пример частотного массива для текстовых данных: Входные данные:
Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.
Частотный анализ может выглядеть так
Символ пробел/space встречается 41 раз. Частота 12.28%
Символ о встречается 38 раз.  Частота 11.38%
Символ и встречается 26 раз.  Частота 7.78%
Символ т встречается 25 раз.  Частота 7.49%
Символ е встречается 23 раза. Частота 6.89%
Символ с встречается 21 раз.  Частота 6.29%
Символ н встречается 20 раз.  Частота 5.99%
Символ а встречается 20 раз.  Частота 5.99%
Символ в встречается 16 раз.  Частота 4.79%
Символ р встречается 12 раз.  Частота 3.59%
Символ л встречается 10 раз.  Частота 2.99%
Символ к встречается 9 раз.   Частота 2.69%
Символ д встречается 9 раз.   Частота 2.69%
Символ п встречается 6 раз.   Частота 1.80%
Символ я встречается 6 раз.   Частота 1.80%
Символ м встречается 6 раз.   Частота 1.80%
Символ ь встречается 5 раз.   Частота 1.50%
Символ ы встречается 5 раз.   Частота 1.50%
Символ з встречается 4 раза.  Частота 1.20%
Символ х встречается 3 раза.  Частота 0.90%
Символ ш встречается 3 раза.  Частота 0.90%
Символ ф встречается 3 раза.  Частота 0.90%
Символ ч встречается 3 раза.  Частота 0.90%
Символ й встречается 3 раза.  Частота 0.90%
Символ , встречается 3 раза.  Частота 0.90%
Символ щ встречается 2 раза.  Частота 0.60%
Символ ю встречается 2 раза.  Частота 0.60%
Символ у встречается 2 раза.  Частота 0.60%
Символ г встречается 2 раза.  Частота 0.60%
Символ ж встречается 1 раз.   Частота 0.30%
Символ э встречается 1 раз.   Частота 0.30%
Символ – встречается 1 раз.   Частота 0.30%
Символ б встречается 1 раз.   Частота 0.30%
Символ ц встречается 1 раз.   Частота 0.30%
Символ . встречается 1 раз.   Частота 0.30%
url


void frequencyOutputArray(int[,] arr, int[,] arrOutput)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int count = 0;
            for (int m = i; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    if (arr[m, n] == arr[i, j]) count++;                    
                }
            }
            for (int d = 0; d <= index; d++)
            {
                if (d == index)
                {
                    arrOutput[index, 0] = arr[i, j];
                    arrOutput[index, 1] = count;
                    index++;
                    break;
                }
                if (arr[i, j] == arrOutput[d, 0] && arrOutput[d, 1] > 0) break;                
            }

        }
    }
}
от Stanislav для Все (11:35)
int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] frequencyAnalysArray = new int[array.GetLength(0) * array.GetLength(1), 2];
от Stanislav для Все (11:35)
frequencyOutputArray(array, frequencyAnalysArrays);
sortArray(frequencyAnalysArrays);
for (int i = 0; i < frequencyAnalysArrays.GetLength(0) && frequencyAnalysArrays[i, 1] > 0; i++)
    Console.WriteLine($"{frequencyAnalysArrays[i, 0]} встречается {frequencyAnalysArrays[i, 1]} раз");
от Stanislav для Все (11:35)
void sortArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        int min = arr[j, 0];
        for (int n = j + 1; n < arr.GetLength(0); n++)
        {
            if (arr[n, 0] < min && arr[n, 1] > 0)
            {
                arr[j, 0] = arr[n, 0];
                arr[n, 0] = min;
                min = arr[j, 1];
                arr[j, 1] = arr[n, 1];
                arr[n, 1] = min;
                min = arr[j, 0];
            }
        }
    }
}
////////////////////////////полное верное решение!!!!!!!!!!!!

// Составить частотный словарь элементов двумерного массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // заполняем числами [0,10)
        }
    }
}

void frequencyOutputArray(int[,] arr, int[,] arrOutput)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int count = 0;
            for (int m = i; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    if (arr[m, n] == arr[i, j]) count++;
                }
            }
            for (int d = 0; d <= index; d++)
            {
                if (d == index)
                {
                    arrOutput[index, 0] = arr[i, j];
                    arrOutput[index, 1] = count;
                    index++;
                    break;
                }
                if (arr[i, j] == arrOutput[d, 0] && arrOutput[d, 1] > 0) break;
            }

        }
    }
}

void sortArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        int min = arr[j, 0];
        for (int n = j + 1; n < arr.GetLength(0); n++)
        {
            if (arr[n, 0] < min && arr[n, 1] > 0)
            {
                arr[j, 0] = arr[n, 0];
                arr[n, 0] = min;
                min = arr[j, 1];
                arr[j, 1] = arr[n, 1];
                arr[n, 1] = min;
                min = arr[j, 0];
            }
        }
    }
}

int[,] array = new int[3, 3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[,] frequencyAnalysArrays = new int[array.GetLength(0) * array.GetLength(1), 2];

frequencyOutputArray(array, frequencyAnalysArrays);
sortArray(frequencyAnalysArrays);
for (int i = 0; i < frequencyAnalysArrays.GetLength(0) && frequencyAnalysArrays[i, 1] > 0; i++)
    Console.WriteLine($"{frequencyAnalysArrays[i, 0]} встречается {frequencyAnalysArrays[i, 1]} раз");


   // Составить частотный словарь элементов двумерного массива

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 6;
int n = 6;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();
от Albert для Все (12:22)
int[,] dictionary = new int[m * n, 2];

int k = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int r = 0; r < k; r++)
        {
            if (dictionary[r, 0] == array[i, j])
            {
                dictionary[r, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            dictionary[k, 0] = array[i, j];
            dictionary[k, 1]++;
            k++;
        }      
    }
}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write(dictionary[i, j] + " ");
    }
    Console.WriteLine();
} */

/*
//61. Найти произведение двух матриц

//Console.WriteLine("Введите количество строк");
int str = 3;//int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
int coll = 4;//int.Parse(Console.ReadLine());

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-5, 10);
        }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixSolution(int[,] array1, int[,] array2)
{
    int[,] item = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int a = 0; a < array1.GetLength(1); a++)
                item[i, j] += array1[i, a] * array2[a, j];
    return item;
}

int[,] MyArray1 = NewArray(coll, str);
int[,] MyArray2 = NewArray(str, coll);
FillArray(MyArray1);
FillArray(MyArray2);
PrintArray(MyArray1);
Console.WriteLine();
PrintArray(MyArray2);
Console.WriteLine();
PrintArray(MatrixSolution(MyArray1, MyArray2));

*/
//62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int y = 3;
int x = 5;

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

(int minStr, int minCol, int minValue) FindMin(int[,] array)
{
    int minValue = array[0, 0];
    int minStr = 0;
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                minStr = i;
                minCol = j;
            }
        }
    return (minStr, minCol, minValue);
}

int[,] ReWrite(int[,] array, int a, int b)
{
    int[,] newArray = new int[(array.GetLength(0) - 1), (array.GetLength(1) - 1)];
    int l = 0;
    int k = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if (k == a && (k < array.GetLength(0) - 1)) k++;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (l == b && (l < array.GetLength(1) - 1)) l++;
            newArray[i, j] = array[k, l];
            if (l < (array.GetLength(1) - 1)) l++;
        }
        if (k < array.GetLength(0) - 1) k++;
        l = 0;
    }
    return newArray;
}

int[,] MyArray = NewArray(y, x);
int[] Summ = new int[MyArray.GetLength(0)];
FillArray(MyArray);
Console.WriteLine();
PrintArray(MyArray);
Console.WriteLine();
(int minStr, int minCol, int minValue) result = FindMin(MyArray);
Console.WriteLine("Минимальный элемент массива: " + result.Item3);
Console.WriteLine();

PrintArray(ReWrite(MyArray, result.minStr, result.minCol)); */



//63.Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
/*

int y = 3;
int x = 3;
int z = 3;


int[,,] NewArray(int y, int x, int z)
{
    int[,,] array = new int[y, x, z];
    return array;
}

int[,,] FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 99);
            }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}  ");
            }
        Console.WriteLine();
    }
}
int[,,] MyArray = NewArray(y, x, z);

FillArray(MyArray);
PrintArray(MyArray);*/


/*64. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int row = 9;
int[,] triangle = new int[row, row];
const int cellWidth = 1;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] =
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            //if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            if (triangle[i, j] % 2 != 0) Console.WriteLine("*");

            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);

        Console.WriteLine();
    }
}

Console.ReadLine();
FillTriangle();
//PrintTriangle();
Console.ReadLine();
Magic();*/



/*
//65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 


//Console.WriteLine("Введите количество строк");
int str = 3;//int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
int coll = 3;//int.Parse(Console.ReadLine());

int[,] mass = new int[str, coll];

int[,] FillArray(int[,] array)
{
    int numbers = 1;
    int num = array.GetLength(0);
    if (num % 2 != 0) array[num / 2, num / 2] = num * num;
    for (int i = 0; i < (num / 2); i++)
    {
        for (int j = i; j < (num - i); j++)    //(num - i) - чтобы с каждым разом сторона становилась меньше
        {
            array[i, j] = numbers;
            numbers++;
        }
        for (int k = 1; k < (num - i - i); k++)// начинаем с первого эл. т.k. нулевой уже записан
        {
            array[k + i, (num - i) - 1] = numbers;// (num - i) - 1 - отнимаем 1 чтоб не выходило за рамки массива
            numbers++;
        }
        for (int l = (num - 2) - i; l >= i; l--) // (num - 2) - i - отнимаем 1 чтоб не выходило за рамки массива и еще одну 1 
        {
            array[(num - i) - 1, l] = numbers;
            numbers++;
        }
        for (int m = ((num - i) - 2); m > i; m--)
        {
            array[m, i] = numbers;
            numbers++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(mass));*/



//Рекурсия
//66. Показать натуральные числа от 1 до N, N задано
/*
void PrintNum(int n)
{
    if (n < 1) return;
    PrintNum(n - 1);
    Console.Write(n + " ");
}

PrintNum(10);*/


//67. Показать натуральные числа от N до 1, N задано
/*
void PrintNum(int n)
{
    if (n >= 1) return;
    Console.Write(n + " ");
    PrintNum(n + 1);

}

PrintNum(-10);*/


//68. Показать натуральные числа от M до N, N и M заданы

/*

void PrintNum(int m, int n)
{
    if (n < m) return;
    PrintNum(m, n - 1);
    //Console.Write(n + " ");
    Console.Write($"{n} ");

}

Console.Write("Input number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());

PrintNum(m, n);
*/


//69. Найти сумму элементов от M до N, N и M заданы
/*
//Console.Write("Input number M: ");
int m = 1;//int.Parse(Console.ReadLine());
//Console.Write("Input number N: ");
int n = 5;//int.Parse(Console.ReadLine());

int SummNumber(int m, int n)
{
    if (m == n) return n;
    else
    {
        if (m > n) return m + SummNumber((m - 1), n);
        else return m + SummNumber((m + 1), n);
    }
}

Console.WriteLine(SummNumber(m, n));


*/

//70. Найти сумму цифр числа
/*

int PrintNum(int number)
{
    if (number < 1) return 0;
    return PrintNum(number / 10) + number % 10;


}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Summ of digits: {PrintNum(number)}");
*/

/*
//71. Написать программу вычисления функции Аккермана

// A(m,n) =    if m = 0             n+1
//             if m > 0  n = 0      a(m-1,1)
//             if m > 0, n > 0       A(m-1, A(m, n -1)) 

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt16(Console.ReadLine());

if (n < 0 || m < 0) Console.WriteLine("Введите положительные числа.");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}

Console.WriteLine(AkkermanFunction(n, m));
*/


//72. Написать программу возведения числа А в целую стень B
/*
Console.Write("Input number A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input number B: ");
int b = int.Parse(Console.ReadLine());

int StepenPrint(int a, int b)
{
    if (b < 1) return 1;
    return a * (StepenPrint(a, b - 1));
}

Console.WriteLine($"Число {a} в степени {b} = {StepenPrint(a, b)}");

*/
//73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

/*
int SumPare(int a, int b, int c)
{
    if (c < 4) return (a + b);
    Console.Write(a + b + " ");
    return SumPare(b, a + b, c - 1);
}


Console.WriteLine("Введите число 1:");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int numB = int.Parse(Console.ReadLine());
int count = 10;

Console.Write(SumPare(numA, numB, count - 1));
*/
/*
Variant 2!!!!!

int SummPare (int n, int a, int b)
{
    if (n < 4) 
        return (a + b);

    Console.Write(a + b + " ");
    return SummPare(n - 1, b, a + b);
}

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());

int n = 10;

Console.Write(num1 + " " + num2 + " ");
Console.Write(SummPare(n, num1, num2));


//74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

Console.WriteLine("Введите количество символов в слове: ");
int num = int.Parse(Console.ReadLine());
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
Console.WriteLine();
FindWords("аисв", new char[num]);
*/


/*Почувствуй себя ничтожеством(или нетъ)
75. Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
Пример:
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
Какие ошибки могут возникнуть при обработке наборов данных?

///////////!!!!!!!!!!!!!!!!!!!!
int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
int[] result=new int[info.Length];
int k=0;//счетчик количества цифр в data
Console.WriteLine("Цифры в data в двоичном выражении:");
for (int i = 0; i < info.Length; i++) // разбиваем data на числа в длвочном коде на основе количества бит из info
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[k+j]+" ");
    }
    k+=info[i];
    Console.Write(";");
}
k=0;
for (int i = 0; i < info.Length; i++)//преобразуем выделенные числа в десятичные
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i]+=data[k+j]*(int) Math.Pow(2,info[i]-1-j);
    }
    k+=info[i];
}
Console.WriteLine();
Console.WriteLine("Цифры в data в десятичном выражении:");

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]+" ");
}
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

int[] dataOne = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] infoOne = { 2, 3, 3, 1 };
int n = 0;
void PrintNum(int[] data, int[] info)
{
    for (int i = 0; i < info.Length; i++)
    {
        int number = 0;
        for (int k = n; k < n + info[i]; k++)
        {
            number = number + (int)Math.Pow(2, (n + info[i] - k - 1)) * data[k];
        }
        Console.Write(number + " ");
        n = n + info[i];
    }
}
PrintNum(dataOne, infoOne);





76. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
Например для N = 50, M получается 6
Одно из решений :
Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48
Ещё одно решение:
Группа 1: 1 
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 16 24 36 40 
Группа 6: 32 48

Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰*/


Console.Write("Введите N: ");
int num = Int32.Parse(Console.ReadLine());


FuncGroup(num);


void FuncGroup(int num)
{
    int group = 0;
    for (int i = 1; i <= num; i++)
    {
        if (i == Math.Pow(2, group))
        {
            Console.WriteLine();
            group++;
            Console.Write($"Группа {group}: ");
        }
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}