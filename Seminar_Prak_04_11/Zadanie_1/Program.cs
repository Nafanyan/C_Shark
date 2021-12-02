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


//33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
//Найти сумму положительных/отрицательных элементов массива
// int[] add_in_create(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
// int sum (int[] array, bool flag)
// {
//    int sum = 0;
//    for ( int i = 0; i < array.Length; i++)
//     {
//         if (flag)
//         {
//             if (array[i]>0)
//             {
//                 sum += array[i];
//             }
//         }
//         else
//         {
//             if (array[i]<0)
//             {
//                 sum += array[i];
//             }
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
// bool mode = false;
// new_array = add_in_create(new_array);
// print(new_array);
// Console.WriteLine(sum(new_array, mode));


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


//36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
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


//39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
//     int[] swapArray = new int[array.Length/2];
//     for ( int i = 0; i < swapArray.Length; i++)
//     {
//        swapArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return swapArray;
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


//41. Выяснить являются ли три числа сторонами треугольника 
// bool condition (int a, int b, int c)
// {
//     return c <= a + b && b <= a + c && a <= b + c;
// }
// int one = Convert.ToInt32(Console.ReadLine());
// int two = Convert.ToInt32(Console.ReadLine());
// int three = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(condition(one, two, three));


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
// int[] ten_to_two(int number)
// {
//     int bit = 1;
//     while (number / Math.Pow(2,bit) > 1)
//     {
//         bit++;
//     }
//     int[] arr_two = new int[bit+1];
//     for(int i = 0; i <= bit; i++)
//     {
//         if(i == bit && number < 2){break;}
//         arr_two[i] = number % 2;
//         number = number / 2;
//     }
//     return arr_two;
// }
// void print (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//     }
// }
// int[] sort (int [] arr_sort)
// {
//     int temp = 0;
//     for (int i = 0; i < arr_sort.Length/2; i++)
//     {
//         temp = arr_sort[i];
//         arr_sort[i] = arr_sort[arr_sort.Length-i-1];
//         arr_sort[arr_sort.Length-i-1] = temp;
//     }
//     return arr_sort;
// }
// print(sort(ten_to_two(7252)));


// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы
// double plosk (double b_one, double b_two, double k_one, double k_two)
// {
//     double  x = 0;
//     for (double i = -10000; i < 10000; i ++)
//     {
//         if (b_one + k_one*i == b_two + k_two*i)
//         {
//            x = i;        
//            break;
//         } 
//     }
//     return x;
// }
// double b1 = Convert.ToInt64(Console.ReadLine());
// double k1 = Convert.ToInt64(Console.ReadLine());
// double b2 = Convert.ToInt64(Console.ReadLine());
// double k2 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine ($"{plosk(b1, b2, k1, k2)} {k1 * plosk(b1, b2, k1, k2) + b1}");


//45. Показать числа Фибоначчи
// int Fib (int N)
// {
//     if (N == 1 || N == 0) return 1;
//     else return Fib(N-1) + Fib(N-2);
// }
// int n = 10;
// for(int i = 0; i < n; i++)
// {
//     Console.Write($"{Fib(i)} ");
// }


//46. Написать программу масштабирования фигуры
// char[] scale (float ratio, string coordinates)
// {
//     int counter = 0;
//     char[] coor = coordinates.ToCharArray();
//     for (int i = 0; i < coor.Length; i++)
//     {
//         if (coor[i] == '(' || coor[i] == ')' || coor[i] == ',' || coor[i] == ' ')
//         {
//             counter++;
//         }
//         else
//         {
//             while ((coor[i] != '(' || coor[i] != ')' || coor[i] != ',' || coor[i] != ' ') )
//         {
//             coor[i] = Convert.ToInt32(coor[i]) * ratio;
//             i++;
//         }
            
//         }
//     }
//     char[] coor_new = new char[counter] 
//     return coor_new;
// }
// void print (char[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//     {
//         Console.Write($"{array[i]}");
//     }
// }
// string coordinat = Console.ReadLine();
// // float rat = Convert.ToInt64(Console.ReadLine());
// // char[] coor = coordinat.ToCharArray();
// // Console.Write($"{(Convert.ToInt64(coor[1]) - 48) * rat}");
// // Console.Write($"{coordinat[0]}");
// // print(scale(rat, coordinat));
// if (coordinat[0] != ',' )
// {
//     Console.WriteLine($"{coordinat[0] * 1}");
// }


// 47 Написать программу копирования массива
// int[] copy_array (int[] array_cop, int[] array_new)
// {
//     for ( int i = 0; i < array_cop.Length; i++)
//     {
//         array_new[i] = array_cop[i];
//     }
//     return array_new;
// }
// int [] rand_array (int[] array)
// {
//      for ( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,11);
//     }
//     return array;
// }
// void print (int[] arr)
// {
//     for ( int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine(); 
// }
// int[] one_array = new int[10];
// int[] two_array = new int[one_array.Length];
// print(rand_array(one_array));
// two_array = copy_array(one_array,two_array);
// print(two_array);


// 48 Показать двумерный массив размером m×n заполненный целыми числами
// int[,] rand(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 101);
//         }
//     }
//     return arr;
// }
// void print(int[,] print_arr)
// {
//        for (int i = 0; i < print_arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < print_arr.GetLength(1); j++)
//         {
//             Console.Write($"{print_arr[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// } 
// int[,] array = new int[10, 4];
// print(rand(array));


//49 Показать двумерный массив размером m×n заполненный вещественными числами
// double[,] rand(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 101);
//             arr[i, j] = arr[i, j] / 10;
//         }
//     }
//     return arr;
// }
// void print(double[,] print_arr)
// {
//        for (int i = 0; i < print_arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < print_arr.GetLength(1); j++)
//         {
//             Console.Write($"{print_arr[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// } 
// double[,] array = new double[10, 4];
// print(rand(array));


// 50. В двумерном массиве n×k заменить четные элементы на противоположные
// int[,] chet (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if ( array[i,j] % 2 == 0)
//             {
//                 array[i,j] = array[i,j] * (-1);
//             }
//         }
//     }
//     return array;
// }
// int[,] Random (int[,] arr_ran)
// {
//     for (int i = 0; i < arr_ran.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr_ran.GetLength(1); j++)
//         {
//             arr_ran[i,j] = new Random().Next(0, 101);
//         }
//     }
//     return arr_ran;
// }
// void print (int[,] arr_print)
// {
//     for ( int i = 0; i < arr_print.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr_print.GetLength(1); j++)
//         {
//             Console.Write($"{arr_print[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array = new int[10,5];
// print(chet(Random(array)));


//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
// int[,] m_n_arr (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i ++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = i + j;
//         }
//     }
//     return arr;
// }
// void print (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] new_arr = new int[10,4];
// print(m_n_arr(new_arr));


// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// int[,] rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }
// int[,] swap (int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 arr[i,j] = arr[i,j] * arr[i,j];
//             }
//         }
//     }
//     return arr;
// }
// void print(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//          Console.WriteLine();
//     } 
// }

// int[,] new_array = new int[3,6];
// new_array = rand(new_array);
// print(new_array);
// Console.WriteLine();
// print(swap(new_array));


//53 .В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// string search (int[,] array, int num)
// {
//     string numbers = string.Empty;
//     bool flag = false;
//     for ( int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] == num)
//             {
//                 numbers = $"{i} {j}";
//                 flag = true;
//                 break;
//             }
//             else numbers = "Такого числа нет";
//         }
//         if(flag) break;
//     }
//     return numbers;
// }

// int[,] Random (int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(0, 101);
//         }
//     }
//     return arr;
// }

// void print (int[,] arr_print)
// {
//     for(int i = 0; i < arr_print.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr_print.GetLength(1); j++)
//         {
//             Console.Write($"{arr_print[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] new_arr = new int[4, 3];
// new_arr = Random(new_arr);
// print(new_arr);
// Console.WriteLine();
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(search(new_arr, num));

//54. В матрице чисел найти сумму элементов главной диагонали

// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }

// int SumMainDiag (int[,] matrix)
// {
//     int sum = 0;
//     int start = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = start; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i,j];
//             start += 1;
//             break;
//         }
//     }
//     return sum;
// }

// void Print (int[,] arr_print)
// {
//     for(int i = 0; i < arr_print.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr_print.GetLength(1); j++)
//         {
//             Console.Write($"{arr_print[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] newMatrix = new int[4,6];
// newMatrix = Rand(newMatrix);
// Print(newMatrix);
// Console.WriteLine(SumMainDiag(newMatrix));

//55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }

// float[] SumCol (int[,] double_Array)
// {
//     float[] sumArray = new float[double_Array.GetLength(1)];
//     for (int i = 0; i < double_Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < double_Array.GetLength(1); j++)
//         {
//             sumArray[j] += (float)double_Array[i,j]/double_Array.GetLength(0);
//         }
//     }
//     return sumArray;
// }

// void print (float[] print_array)
// {

//     for (int j = 0; j < print_array.Length; j++)
//     {
//         Console.Write($"{print_array[j]} ");
//     }
// }

// int [,] matrix = new int[6,6];
// matrix = Rand(matrix);
// print_1(matrix);
// Console.WriteLine();
// print(SumCol(matrix));


//56. Написать программу, которая обменивает элементы первой строки и последней строки
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }
// int[,] Swap (int[,] swapArray)
// {
//     int temp = 0;
//     for (int j = 0; j < swapArray.GetLength(1); j++)
//     {
//         temp = swapArray[0,j];
//         swapArray[0,j] = swapArray[swapArray.GetLength(0)-1, j];
//         swapArray[swapArray.GetLength(0)-1, j] = temp;
//     }
//     return swapArray;
// }

// void Print (int[,] arr_print)
// {
//     for(int i = 0; i < arr_print.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr_print.GetLength(1); j++)
//         {
//             Console.Write($"{arr_print[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] startArray = new int[6,4];
// startArray = Rand(startArray);
// Print(startArray);
// Console.WriteLine();
// Print(Swap(startArray));


//57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }

// int[,] Sorting (int[,] sortingArray)
// {
//     for (int i = 0; i < sortingArray.GetLength(0); i++)
//     {
//         for (int j = 1; j < sortingArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < sortingArray.GetLength(1) - j; k++)
//             {
//                 if (sortingArray[i,k] < sortingArray[i,k+1])
//                 {
//                     int temp = sortingArray[i,k];
//                     sortingArray[i,k] = sortingArray[i,k+1];
//                     sortingArray[i,k+1] = temp;
//                 }
//             }
//         }
//     }
//     return sortingArray;
// }

// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//             Console.Write($"{printArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
    
// }

// int[,] array = new int[6, 10];
// array = Rand(array);
// Print(array);
// Console.WriteLine();
// Print(Sorting(array));


//58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }
// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//             Console.Write($"{printArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
    
// }

// int[,] SwapRowColoumn (int[,] sourceArray)
// {
//     for(int i = 0; i < sourceArray.GetLength(0); i++)
//     {
//         for (int j = i+1; j < sourceArray.GetLength(1); j++)
//         {
//             int temp = sourceArray[i,j];
//             sourceArray[i,j] = sourceArray[j,i];
//             sourceArray[j,i] = temp;
//         }
//     }
//     return sourceArray;
// }

// int[,] array = new int[10, 10];
// array = Rand(array);
// Print(array);
// Console.WriteLine();
// if (array.GetLength(0) == array.GetLength(1))
// {
//     Print(SwapRowColoumn(array));
// }
// else 
// {
//     Console.WriteLine("Двумерный массив не имеет квадратную форму");
// }


//59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }
// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//             Console.Write($"{printArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int MinRow (int[,] sourceArray)
// {
//     int[] sumRows = new int[sourceArray.GetLength(0)];
//      for(int i = 0; i < sourceArray.GetLength(0); i++)
//     {
//         for (int j = i; j < sourceArray.GetLength(1); j++)
//         {
//             sumRows[i] += sourceArray[i,j];
//         }
//     }
//     int min = sumRows[0];
//     int minIndex = 0;
//     for (int i = 0; i < sourceArray.GetLength(0); i++)
//     {
//         if (min > sumRows[i])
//         {
//             min = sumRows[i];
//             minIndex = i;
//         }
//     }
//     return minIndex;
// }


// int[,] array = new int[2, 3];
// array = Rand(array);
// Print(array);
// Console.WriteLine();
// Console.WriteLine(MinRow(array));


//60. Составить частотный словарь элементов двумерного массива
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,101);
//         }
//     }
//     return array;
// }
// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//             if ( printArray[i,j] != 0)
//             {
//                 Console.Write($"{printArray[i,j]} ");
//             }    
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FrequencyArray (int[,] sourceArray)
// {
//     int[,] dictinoryArray = new int[2,sourceArray.GetLength(1)*sourceArray.GetLength(0)];
//     for(int i = 0; i < sourceArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < sourceArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < sourceArray.GetLength(1)*sourceArray.GetLength(0); k++)
//             {
//                 if (dictinoryArray[0,k]==0)
//                 {
//                     dictinoryArray[0,k]=sourceArray[i,j];
//                     dictinoryArray[1,k] += 1;
//                     break;
//                 }
//                 if (dictinoryArray[0,k]==sourceArray[i,j])
//                 {
//                     dictinoryArray[1,k] += 1;
//                     break;
//                 }
//             }
//         }
//     }
//     return dictinoryArray;
// }

// int[,] array = new int[2, 4];
// array = Rand(array);
// Print(array);
// Console.WriteLine();
// Print(FrequencyArray(array));


//61. Найти произведение двух матриц
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,11);
//         }
//     }
//     return array;
// }
// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//                 Console.Write($"{printArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] MultiMatrix (int[,] multipliperOne, int[,] multipliperTwo)
// {
//     int[,] resultArray = new int[multipliperOne.GetLength(0), multipliperTwo.GetLength(1)];
//     for(int i = 0; i < multipliperOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < multipliperTwo.GetLength(1); j++)
//         {
//             for ( int k = 0; k < multipliperOne.GetLength(1); k++)
//             {
//                 resultArray[i,j] += multipliperOne[i,k] * multipliperTwo[k,j];
//             }
//         }
//     }
//     return  resultArray;
// }
// int[,] arrayOne = new int[2, 4];
// int[,] arrayTwo = new int[4, 2];
// arrayOne = Rand(arrayOne);
// arrayTwo = Rand(arrayTwo);
// Print(arrayOne);
// Console.WriteLine();
// Print(arrayTwo);
// Console.WriteLine();
// Print(MultiMatrix(arrayOne, arrayTwo));

//62. В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// int[,] Rand (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,110);
//         }
//     }
//     return array;
// }
// void Print(int[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//                 Console.Write($"{printArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[] SearchMin (int[,] sourceArray)
// {
//     int min = sourceArray[0,0];
//     int[] indexMin = new int[2];
//     for (int i = 0; i < sourceArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < sourceArray.GetLength(1); j++)
//         {
//             if (min > sourceArray[i,j])
//             {
//                 min = sourceArray[i,j];
//                 indexMin[0] = i;
//                 indexMin[1] = j;
//             }
//         }
//     }
//     return indexMin;
// }
// int[,] RemovePartArray(int[,] currentArray, int[] indexRemove)
// {
//     for ( int i = 0; i < currentArray.GetLength(0); i++)
//     {
//         currentArray[i,indexRemove[1]] = 0;
//         for(int j = 0; j < currentArray.GetLength(1); j++)
//         {
//             if (i == indexRemove[0])
//             {
//                 currentArray[i,j] = 0; 
//             }
            
//         }
//     }
//     return currentArray;
// }
// int[,] array = new int[6, 4];
// array = Rand(array);
// Print(array);
// Console.WriteLine();
// array = RemovePartArray(array, SearchMin(array));
// Print(array);


//63. Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента


//64. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника


//65. Спирально заполнить двумерный массив:


//66. Показать натуральные числа от 1 до N, N задано
// string NaturalNumbers(int n)
// {
//     if (n == 1)
//     {
//         return "1";
//     }
//     return NaturalNumbers(n-1) + " " + n;
// }
// Console.WriteLine(NaturalNumbers(10));


//67. Показать натуральные числа от N до 1, N задано
// string NaturalNumbers(int n)
// {
//     if(n == 1)
//     {
//         return "1";
//     }
//     return n + " " + NaturalNumbers(n-1);
// }
// Console.WriteLine(NaturalNumbers(10));


//68. Показать натуральные числа от M до N, N и M заданы
string NaturalNM(int m, int n)
{
    if(m == n) {return $"{n}";}
    else
    {
        if ( m < n) {return m + " " + NaturalNM(m+1, n);}
        else {return m + " " + NaturalNM(m-1, n);}
    }
}
Console.WriteLine(NaturalNM(25, 15));

//69. Найти сумму элементов от M до N, N и M заданы
//70. Найти сумму цифр числа
//71. Написать программу вычисления функции Аккермана
//72. Написать программу возведения числа А в целую стень B
//73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
//74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
//75.
