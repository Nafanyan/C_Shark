

// 0. Вывести квадрат числа

// int kvadrat (int number)
// {
//     return number * number;
// }
// int one = 10;
// Console.WriteLine(kvadrat(one));


//1. По двум заданным числам проверять является ли первое квадратом второго

// bool Check (int a, int b)
// {
//    return a == b*b;
// }
// int one = 4;
// int two = 16;
// Console.WriteLine(Check(one,two));




//2. Даны два числа. Показать большее и меньшее число
// string Check (int a, int b)
// {
//     if (a > b)
//     {
//         return $"{a}>{b}";
//     }
//     else
//     {
//         return $"{b}>{a}";
//     }
// }
// int one = 3;
// int two = 9;
// int three = 16;
// Console.WriteLine(Check(one,two));
// Console.WriteLine(Check(two,three));



//3. По заданному номеру дня недели вывести его название

// string seven_day(int number_day)
// {
//     string[] day = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//     return day[number_day];
// }

// int one_day = 6;
// int two_day = 1;
// int three_day = 0;
// Console.WriteLine(seven_day(one_day));
// Console.WriteLine(seven_day(two_day));
// Console.WriteLine(seven_day(three_day));

 //4. Найти максимальное из трех чисел
//  int srav (int one, int two, int three)
//  {
//      int number = 0;
//     if (one > two && one > three)
//     {
//         number = one;
//     }
//     if (two > one && two > three)
//     {
//         number = two;
//     }
//     if (three > one && three > two)
//     {
//         number = three;
//     }
//     return number;
// }
// int one_number = 12;
// int two_number = 10;
// int three_number = 5;
// Console.WriteLine(srav(one_number, two_number, three_number));



//5. Написать программу вычисления значения функции y=f(a)
// double Cosinus (double arg)
// {
//     return Math.Cos(arg);
// }
// double a = 0;
// Console.WriteLine(Cosinus(a));


 //6. Выяснить является ли число чётным
// bool chet (int number)
// {
//     return number %2 == 0;
// }
// int one = 12;
// int two = 10;
// int three = 9;
// Console.WriteLine(chet(one));
// Console.WriteLine(chet(two));
// Console.WriteLine(chet(three));

//7. Показать числа от -N до N

// void Print_number(int start, int end)
// {
//     for (int i = start; i <= end; i++)
//     {
//       Console.Write($"{i} ");
//     }
// }
// int start_N = - 100;
// int end_N = 100;
// Print_number(start_N, end_N);

//Показать число, кратное 7 и 23
// bool check (int num)
// {
//     return num % 7 == 0 && num % 23 == 0; 
// }
// int number = 76;
// Console.WriteLine(check(number));

// По вводимому числу будний день или выходной

// string Weekend(int day)
// {
// if(day == 6 && day == 7)
// {
//     return "Выходной";
// }
// else
// {
//     return "Будний день";
// }
// }
// int number = 6;
// Console.WriteLine(Weekend(number));



//Convert.ToInt32(Console.ReadLine());

// Проверить какое число является квадратом другого
// string check (int one, int two)
// {
//     string result = "";
//     if(one*one == two)
//     {
//        result = $"{two}^2 = {one}";
//     }
//     if(two*two == one)
//     {
//         result = $"{one}^2 = {two}";
//     }
//     return result;
// }
// int number_one = 4;
// int number_two = 16;
// Console.WriteLine(check(number_one,number_two));


//Проверить условие
// bool check (bool one_bool, bool two_bool)
// {
//     return !(one_bool || two_bool) == !one_bool && !two_bool;
// }
// bool one = true;
// bool two = false;
// Console.WriteLine(check(one,two));

// Вывести четверть точки

// int Chetvert (int x, int y)
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//     {
//         result = 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         result = 2;
//     }
//     if(x < 0 && y < 0)
//     {
//         result = 3;   
//     }
//     if(x > 0 && y < 0)
//     {
//         result = 4;
//     }
//     return result;
// }
// int hor = 12;
// int ver = -5;
// Console.WriteLine(Chetvert(hor,ver));

//Вводят четверть, вывести интервал допустимых значений
// string interval (int number)
// {
//     string result ="";
//     int max = Int32.MaxValue;
//     int min = Int32.MinValue;
//     if (number == 1)
//     {
//         result = $"x(0;{max}) y(0;{max})";
//     }
//     if (number == 2)
//     {
//         result = $"x({min};0) y(0;{max})";
//     }
//     if(number == 3)
//     {
//     result = $"x({min};0) y({min};0)";  
//     }
//     if(number == 4)
//     {
//         result = $"x(0;{max}) y({min};0)";
//     }
//     return result;
// }

// int num = 3;
// Console.WriteLine(interval(num));



//Проверка на полиндром
// int number = 987678;
// string number_string = Convert.ToString(number);
// char[] array = number_string.ToCharArray();
// int integer = 0;
// int check = array.Length/2;
// for(int i = 0; i < array.Length; i++)
// {
//     if (i == array.Length/2)
//     {
//         break;
//     }
//     if (array[i] == array[array.Length-1-i])
//     {
//         integer ++;
//     }
    
// }
// if (integer == check)
// {
//     Console.WriteLine("Полиндром");
// }
