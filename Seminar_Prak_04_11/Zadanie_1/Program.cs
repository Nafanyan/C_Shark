

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
// bool int_to_bool (int num)
// {
//     if (num == 0)
//     {
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }

// bool result = true;
// for (int i = 0; i <= 1; i++)
// {
//     for (int j = 0; j <= 1; j++)
//     {
//         result = result && (check(int_to_bool(i),int_to_bool(j)));
//     }
// }
// Console.WriteLine(result);

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

// 22. Найти расстояние между точками в пространстве 2D/3D

// double distance_2D (int x_1, int y_1, int x_2, int y_2)
// {
//     return Math.Sqrt((x_1-x_2)*(x_1-x_2)+(y_1-y_2)*(y_1-y_2)); 
// }
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(distance_2D(x1,y1,x2,y2));

// double distance_3D (int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
// {
//     return Math.Sqrt((x_1-x_2)*(x_1-x_2)+(y_1-y_2)*(y_1-y_2)+(z_1-z_2)*(z_1-z_2)); 
// }
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(distance_2D(x1,y1,z1,x2,y2,z2));

//23. Показать таблицу квадратов чисел от 1 до N 

// void print_square (int Nom)
// {
//     for (int i = 2; i <= Nom; i++)
//     {
//         Console.WriteLine($"{i} - {i*i}");
//     }
// }

// int N = Convert.ToInt32(Console.ReadLine());
// print_square(N);

//24. Найти кубы чисел от 1 до N
// void print_square (int Nom)
// {
//     for (int i = 1; i <= Nom; i++)
//     {
//         Console.WriteLine($"{i} - {i*i*i}");
//     }
// }

// int N = Convert.ToInt32(Console.ReadLine());
// print_square(N);

// 25. Найти сумму чисел от 1 до А

// int sum (int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(A));

//26. Возведите число А в натуральную степень B используя цикл
// int stepen (int number_a, int stepen_b)
// {
//     int result = 1;
//     for (int i = 0; i < stepen_b; i++)
//     {
//         result = result * number_a;
//     }
//     return result;
// }
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(stepen(A,B));

//27. Определить количество цифр в числе
// char[] int_to_arrchar (int number)
// {
// string number_string = Convert.ToString(number);
// char[] array = number_string.ToCharArray();
// return array;
// }
// int size (char[] new_array)
// {
//     return new_array.Length;
// }

// int value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(size(int_to_arrchar(value)));

//28. Подсчитать сумму цифр в числе
// char[] int_to_arrchar (int number)
// {
// string number_string = Convert.ToString(number);
// char[] array = number_string.ToCharArray();
// return array;
// }
// int sum(char[] arr)
// {
//     int sumn = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         sumn = sumn + (Convert.ToInt32(arr[i]) - Convert.ToInt32('0'));
//     }
//     return sumn;
// }

// int value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(int_to_arrchar(value)));

//29. Написать программу вычисления произведения чисел от 1 до N

// int chast(int N)
// {
//     int result = 1;
//     for(int i = 1; i <= N; i++)
//     {
//         result = result * i; 
//     }
//     return result;
// }
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(chast(number));

//30. Показать кубы чисел, заканчивающихся на четную цифру

// void print_kub(int num)
// {
//     num = num * num * num;
//     if (num % 2 == 0)
//     {
//         Console.WriteLine(num);
//     }
// }

// int number = Convert.ToInt32(Console.ReadLine());
// print_kub(number);

//31. Задать массив из 8 элементов и вывести их на экран 
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// int[] arr = {1,2,3,4,5,6,7,8,9,0,11};
// print(arr);

//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// int[] new_array = new int[8];
// new_array = add_in_create(new_array);
// print (new_array);

//33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
// int sum (int[] array)
// {
//     int sum = 0;
//    for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum; 
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[12];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(sum(new_array));

//
// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
// int sum (int[] array)
// {
//     int sum = 0;
//    for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum; 
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[12];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(sum(new_array));

//34. Написать программу замену элементов массива на противоположные

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
//     return array;
// }
// int[] swap (int[] array)
// {
//     int sum = 0;
//    for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] - array[i] * 2;
//     }
//     return array; 
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[15];
// new_array = add_in_create(new_array);
// print(new_array);
// new_array = swap(new_array);
// print(new_array);

//35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
//     return array;
// }
// bool find (int[] array, int number)
// {
//     bool bool_array = false;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (number == array[i])
//         {
//             bool_array = true;
//             break;
//         }
//     }
//     return bool_array;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[15];
// new_array = add_in_create(new_array);
// print(new_array);
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(find(new_array, num));

//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int find (int[] array)
// {
//     int quantity = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[15];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(find(new_array));

//

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int find (int[] array)
// {
//     int quantity = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 1)
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[15];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(find(new_array));

//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }
// int find (int[] array)
// {
//     int quantity = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[123];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(find(new_array));

//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }
// int find (int[] array)
// {
//     int sum = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[15];
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(find(new_array));

//39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }
// int[] find (int[] array)
// {
//     int[] swap_array = new int[array.Length/2];
//     for ( int i = 0; i < swap_array.Length; i++)
//     {
//        swap_array[i] = array[i] * array[array.Length - i - 1];
//     }
//     return swap_array;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[7];
// print(add_in_create(new_array));
// print(find(new_array));

//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }
// int dif (int[] array)
// {
//     int max = 0;
//     int min = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//        if (array[i] > max)
//        {
//            max = array[i];
//        }
//        if (array[i] < min)
//        {
//            min = array[i];
//        }
//     }
//     return max-min;
// }
// void print (int[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] new_array = new int[7];
// print(add_in_create(new_array));
// Console.WriteLine(dif(add_in_create(new_array)));

//42. Определить сколько чисел больше 0 введено с клавиатуры

// char[] int_to_char_arr (int num)
// {
//     string num_string = Convert.ToString(num);
//     char[] num_char = num_string.ToCharArray();
//     return num_char;
// }
// int quantity (char[] char_arr)
// {
//     int integer = 0;
//     for (int i = 0; i < char_arr.Length; i++)
//     {
//         if (char_arr[i] == '0')
//         {
//             integer++;
//         }
//     }
//     return integer;
// }

// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(quantity(int_to_char_arr(number)));

//43. Написать программу преобразования десятичного числа в двоичное

int[] ten_to_two(int number)
{
    int bit = 1;
    while (number / Math.Pow(2,bit) > 1)
    {
        bit++;
    }
    int[] arr_two = new int[bit+1];
    for(int i = 0; i <= bit; i++)
    {
        if(i == bit && number < 2){break;}
        arr_two[i] = number % 2;
        number = number / 2;
    }
    return arr_two;
}
void print (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
int[] sort (int [] arr_sort)
{
    int temp = 0;
    for (int i = 0; i < arr_sort.Length/2; i++)
    {
        temp = arr_sort[i];
        arr_sort[i] = arr_sort[arr_sort.Length-i-1];
        arr_sort[arr_sort.Length-i-1] = temp;
    }
    return arr_sort;
}
print(sort(ten_to_two(9)));
