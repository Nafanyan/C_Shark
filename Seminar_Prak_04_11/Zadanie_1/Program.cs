
// 0. Вывести квадрат числа
/*
int kvadrat (int number)
{
    number = number * number;
    return number;
}
void Print (int number)
{
    Console.WriteLine(number);

}
int one = 10;
int two = 5;
int three = 15;
one = kvadrat(one);
Print(one);
two = kvadrat(two);
Print(two);
three = kvadrat(three);
Print(three);
*/

//1. По двум заданным числам проверять является ли первое квадратом второго
/*
void Check (int a, int b)
{
    if (a*a == b)
    {
        Console.WriteLine($"{a} является квадратом {b}");
    }
    else
    {
        Console.WriteLine($"{a} не является квадратом {b}");
    }

}
int one = 3;
int two = 9;
int three = 16;
int four = 4;
Check(one,two);
Check(two,three);
*/
//2. Даны два числа. Показать большее и меньшее число
/*
void Check(int one_check, int two_check)
{
if(one_check > two_check)
{
    Console.WriteLine($"Наибольшее {one_check}, меньшее {two_check}");
}
else
{
    Console.WriteLine($"Наибольшее {two_check}, меньшее {one_check}");
}
}

int one = 10;
int two = 20;
int three = 21;
int four = 2;
Check(one,two);
Check(three,four);
*/

//3. По заданному номеру дня недели вывести его название
/*
void seven_day(int day)
{
    if (day == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (day == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (day == 3)
    {
        Console.WriteLine("Среда");
    }
    if (day == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (day == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (day == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (day == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    if (day < 1 || day > 7)
    {
        Console.WriteLine("Номера такого дня недели нет");
    }
}

int one_day = 6;
int two_day = 1;
int three_day = 0;
seven_day(one_day);
seven_day(three_day);
seven_day(two_day);
*/
/*
 //4. Найти максимальное из трех чисел
 void srav (int one, int two, int three)
 {
    if (one > two && one > three)
    {
        Console.WriteLine($"Максимальное {one}");
    }
    if (two > one && two > )
    {
        Console.WriteLine($"Максимальное {two}");
    }
    if (three > one && three > two)
    {
        Console.WriteLine($"Максимальное {three}");
    }
}
int one = 12;
int two = 10;
int three = 5;
srav(one, two, three);

*/
/*
//5. Написать программу вычисления значения функции y=f(a)
double a = 0;
double y = Math.Cos(a);
Console.WriteLine(y);
*/
/*
 //6. Выяснить является ли число чётным
string chet (int number)
{
    string text;
    if (number % 2 == 0)
    {
        text = $"{number} четное число";
    }
    else
    {
        text = $"{number} не четное число";
    }
    return text;
}
int one = 12;
int two = 10;
int three = 9;
Console.WriteLine(chet(one));
Console.WriteLine(chet(two));
Console.WriteLine(chet(three));
*/
//7. Показать числа от -N до N
/*
void Print_number(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
      Console.Write($"{i} ");
    }
}
int start_N = - 100;
int end_N = 100;
Print_number(start_N, end_N);
*/
