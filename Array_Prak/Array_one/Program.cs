/*

нарушают порядок возрастания


int index = 0;// Инициализируем индекс массива
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
// Заполняет массив
while (index <= 9)
{
    array_A[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

// Выводим массив
Console.Write("Исходный массив A: ");
index = 0;
while (index <= 9)
{
    Console.Write($"{array_A[index]} ");
    index++;
}
Console.WriteLine();
int current = array_A[0];
// Добавляем элементы не нарушающие возрастание
index = 0;
int i = 0; // Счетчик чисел, удовлетворяющих условию
while (index <= 9)
{
  if (index == 0)
  {
      // Специальное условие для нулевого элемента
      array_test[i] = current;
      current = array_A[index];
      i++; 
  }  
  if (current < array_A[index])
  {
      array_test[i] = array_A[index];
      current = array_A[index];
      i++;
  }
  index++;
}
index = 0;
int[] array_B = new int [i]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
while (index <= i+1 )
{
    array_B[index] = array_test[index];
    Console.Write($"{array_B[index]} ");
    index++;
}
*/
/*

больше среднего арифметического элементов A

int index = 0;// Инициализируем индекс массива
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
// Заполняет массив
while (index <= 9)
{
    array_A[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

// Выводим массив
Console.Write("Исходный массив A: ");
index = 0;
while (index <= 9)
{
    Console.Write($"{array_A[index]} ");
    index++;
}

// Находим среднее арифметическое
int sum = 0; // Инициализируем переменную для нахождения среднего арифметического 
index = 0;
while (index <=9) // Суммируем все элементы массива
{
    sum = sum + array_A[index];
    index ++;
}
sum = sum / array_A.Length; // Делим сумму всех элементов на их количество
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое: {sum}");
// Добавляем элементы меньшие среднего арифметического в вспомогательный массив
index = 0;
int i = 0; // Счетчик чисел, удовлетворяющих условию
while (index <= 9)
{
    if(array_A[index] < sum)
    {
        array_test[i] = array_A[index];
        i++;
    }
    index++;
}
index = 0;
int[] array_B = new int [i]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
while (index <= i )
{
    array_B[index] = array_test[index];
    Console.Write($"{array_B[index]} ");
    index++;
}
*/

/*
int index = 0;// Инициализируем индекс массива
int[] array_A = new int[10]; // Инициализируем массив А
int[] array_test = new int [10]; // Инициализируем тестовый, вспомогательный массив
// Заполняет массив
while (index <= 9)
{
    array_A[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

// Выводим массив
Console.Write("Исходный массив A: ");
index = 0;
while (index <= 9)
{
    Console.Write($"{array_A[index]} ");
    index++;
}
// Добавляем элементы меньшие среднего арифметического в вспомогательный массив
index = 0;
int i = 0; // Счетчик чисел, удовлетворяющих условию
while (index <= 9)
{
    if(array_A[index] % 2 == 1)
    {
        array_test[i] = array_A[index];
        i++;
    }
    index++;
}
index = 0;
int[] array_B = new int [i]; // Создаем финальный массив В
// Заполняем массив В
Console.WriteLine();
Console.Write("Итоговый массив В: ");
while (index <= i )
{
    array_B[index] = array_test[index];
    Console.Write($"{array_B[index]} ");
    index++;
}
*/