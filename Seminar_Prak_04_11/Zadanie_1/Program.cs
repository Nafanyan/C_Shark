

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

// 8. Показать четные числа от 1 до N

// void Print_chet_Arr(int Num)
// {
//     for (int i = 0; i <= Num; i++)
//     {
//         if (i%2 == 0)
//         Console.Write($"{i} ");
//     }
// }

// int N = Convert.ToInt32(Console.ReadLine());
// Print_chet_Arr(N);

//  9. Показать последнюю цифру трёхзначного числа

// int last_num (int num)
// {
//     return num % 10;
// }

// int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(last_num(Number));

//10. Показать вторую цифру трёхзначного числа
// int two_num (int num)
// {
//     return (num % 100 - num % 10) / 10;
// }

// int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(two_num(Number));

//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int srav (int num)
// {
//     if (num % 10 > (num - num % 10)/10)
//     {
//         return num % 10;
//     }
//     else
//     {
//         return (num - num % 10)/10;
//     }
// }

// int Number = new Random().Next(10,100);
// Console.WriteLine(Number);
// Console.WriteLine(srav(Number));

//12. Удалить вторую цифру трёхзначного числа
// char[] two_num (int num)
// {
//     string number_string = Convert.ToString(num);
//     char[] array_char = number_string.ToCharArray();
//     return array_char;
// }
// void print_char (char[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ( i != 1)
//         {
//             Console.Write($"{array[i]}");
//         }   
//     }
// }

// int Number = Convert.ToInt32(Console.ReadLine());
// print_char(two_num(Number));

//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// int check (int number, int krat)
// {
//     if (number % krat == 0)
//     {
//         return 0;
//     }
//     else
//     {
//        return number % krat; 
//     }
// }
// int num_one = Convert.ToInt32(Console.ReadLine());
// int num_two = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(check(num_one,num_two));

//14. Найти третью цифру числа или сообщить, что её нет

// char three_num (int number)
// {
//     string number_string = Convert.ToString(number);
//     char[] array_char = number_string.ToCharArray();
//     if (number > 99 || number < -99)
//     {
//         return array_char[2];
//     }
//     else
//     {
//         return 'n';
//     }
// }
// int num = Convert.ToInt32(Console.ReadLine());
// if(three_num(num) == 'n') 
// {Console.WriteLine("Число отсутствует");}
// else
// {
//     Console.WriteLine(three_num(num));
// }

//15.Показать число, кратное 7 и 23
// bool check (int num)
// {
//     return num % 7 == 0 && num % 23 == 0; 
// }
// int number = 76;
// Console.WriteLine(check(number));

// 16.По вводимому числу будний день или выходной

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

// 17.Проверить какое число является квадратом другого
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


//18. Проверить условие
// bool check (bool one_bool, bool two_bool)
// {
//     return !(one_bool || two_bool) == !one_bool && !two_bool;
// }
// bool one = true;
// bool two = false;
// Console.WriteLine(check(one,two));

// 19.Вывести четверть точки

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

//20.Вводят четверть, вывести интервал допустимых значений
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



//21. Проверка на полиндром
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
