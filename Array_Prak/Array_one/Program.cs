// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// метод для заполнения массива случайными величинами
// int[] Rand_Arr(int [] array, int min, int max)
// {
//     int length = array.Length;
//     for(int i=0; i < length; i++)
//     {
//         array[i] = new Random().Next(min, max); // [10, 99]
//     }
//     return array;
// }

// // метод для печати массива
// void Print_Arr(int [] array_print)
// {
//     int length_print = array_print.Length;
//     for(int i = 0; i < length_print; i++)
//     {
//         Console.Write($"{array_print[i]} ");
//     }
// }

//нарушают порядок возрастания
/*
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
int min_num = 10;
int max_num = 100;

// Заполняет массив
array_A = Rand_Arr(array_A,min_num, max_num);

// Выводим массив
Console.Write("Исходный массив A: ");
Print_Arr(array_A);
Console.WriteLine();

int current = array_A[0];
// Добавляем элементы не нарушающие возрастание
int counter = 0; // Счетчик чисел, удовлетворяющих условию
for(int index = 0; index < array_A.Length; index++)
{
  if (index == 0)
  {
      // Специальное условие для нулевого элемента
      array_test[counter] = current;
      current = array_A[index];
      counter++; 
  }  
  if (current < array_A[index])
  {
      array_test[counter] = array_A[index];
      current = array_A[index];
      counter++;
      

  }
 
}
int[] array_B = new int [counter]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
for (int index = 0; index < counter; index++)
{
    array_B[index] = array_test[index];
}
Print_Arr(array_B);
*/

//больше среднего арифметического элементов A
/*
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
int min_num = 10;
int max_num = 100;

// Заполняет массив
array_A = Rand_Arr(array_A,min_num, max_num);

// Выводим массив
Console.Write("Исходный массив A: ");
Print_Arr(array_A);
Console.WriteLine();
// Находим среднее арифметическое
int sum = 0; // Инициализируем переменную для нахождения среднего арифметического 
for(int index = 0; index < array_A.Length; index++) // Суммируем все элементы массива
{
    sum = sum + array_A[index];
}
sum = sum / array_A.Length; // Делим сумму всех элементов на их количество
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое: {sum}");
// Добавляем элементы меньшие среднего арифметического в вспомогательный массив

int counter = 0; // Счетчик чисел, удовлетворяющих условию
for(int index = 0; index < array_A.Length; index++)
{
    if(array_A[index] < sum)
    {
        array_test[counter] = array_A[index];
        counter++;
    }
}
int[] array_B = new int [counter]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
for(int index = 0; index < counter; index++)
{
    array_B[index] = array_test[index];
}
Print_Arr(array_B);
*/

// четные
/*
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
int min_num = 10;
int max_num = 100;

// Заполняет массив
array_A = Rand_Arr(array_A,min_num, max_num);

// Выводим массив
Console.Write("Исходный массив A: ");
Print_Arr(array_A);
Console.WriteLine();

int counter = 0; // Счетчик чисел, удовлетворяющих условию
for(int index = 0; index < array_A.Length; index++)
{
    if(array_A[index] % 2 == 1)
    {
        array_test[counter] = array_A[index];
        counter++;
    }
}
int[] array_B = new int [counter]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
for(int index = 0; index < counter; index++)
{
    array_B[index] = array_test[index];
}
Print_Arr(array_B);
*/