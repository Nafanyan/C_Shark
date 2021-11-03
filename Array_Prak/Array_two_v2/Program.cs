/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. С
оздать на его основе масив B, отбрасывая те, которые нарушают порядок

возрастания
элементы, больше 8
знакочередования*/


// Метод, наполняющий массив рандомными значениями
int[] Array_Random(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
// Метод, выполняющий печать массива
void Array_Print(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Возрастания
/*
int[] array_A = new int [10];// Инициализируем массив А
int[] array_Test = new int [10];// Инициализируем тестовый, переходный массив
int min_Value = -100;// Задаем минимальное значение диапазона 
int max_Value = 100;// Задаем маскимально значение диапазона
Console.Write("Исходный массив: ");
array_A = Array_Random(array_A, min_Value, max_Value);// Заполняем массив А рандомными числами через метод Array_Random
Array_Print(array_A);// Печатаем массив А через метод Array_print

// Реализуем поставленное условие
int current = 0;// Инициализируем переменную, с помощью которой будем обозначать текущее значение элемента массива
int counter = 0;// Инициализируем счетчик для нахождения количества чисел, соответствующих условию
for (int index = 0; index < array_A.Length; index++)
{
    // Специальное условие для первого элемента массива, с него должно проверяться условие
    if(index == 0)
    {
        array_Test[counter] = array_A[index];
        current = array_A[index];
        counter++;   
    }
    if (current < array_A[index])
    {
        array_Test[counter] = array_A[index];
        current = array_A[index];
        counter++;  
    }
}
Console.WriteLine();

// Заполняем итоговый массив
int[] array_B = new int [counter];// Инициализирование массива В, размерностью равной количеству чисел, проверенных условием
Console.Write("Массив В: ");
// Заполнение массива В с помощью тестового массива, избавление от нулей
for (int index = 0; index < counter; index ++)
{
    array_B[index] = array_Test[index];
}
Array_Print(array_B);// Печать массива В с помощью метода Array_print
*/


// Элементы, больше 8
/*
int[] array_A = new int [10];// Инициализируем массив А
int[] array_Test = new int [10];// Инициализируем тестовый, переходный массив
int min_Value = -100;// Задаем минимальное значение диапазона 
int max_Value = 100;// Задаем маскимально значение диапазона
Console.Write("Исходный массив: ");
array_A = Array_Random(array_A, min_Value, max_Value);// Заполняем массив А рандомными числами через метод Array_Random
Array_Print(array_A);// Печатаем массив А через метод Array_print

// Реализуем поставленное условие
int counter = 0;// Инициализируем счетчик для нахождения количества чисел, соответствующих условию
for (int index = 0; index < array_A.Length; index++)
{
    if (array_A[index] < 8 )
    {
        array_Test[counter] = array_A[index];
        counter++;  
    }
}
Console.WriteLine();

// Заполняем итоговый массив
int[] array_B = new int [counter];// Инициализирование массива В, размерностью равной количеству чисел, проверенных условием
Console.Write("Массив В: ");
// Заполнение массива В с помощью тестового массива, избавление от нулей
for (int index = 0; index < counter; index ++)
{
    array_B[index] = array_Test[index];
}
Array_Print(array_B);// Печать массива В с помощью метода Array_print
*/
// Знакочередования
/*
int[] array_A = new int [10];// Инициализируем массив А
int[] array_Test = new int [10];// Инициализируем тестовый, переходный массив
int min_Value = -100;// Задаем минимальное значение диапазона 
int max_Value = 100;// Задаем маскимально значение диапазона
Console.Write("Исходный массив: ");
array_A = Array_Random(array_A, min_Value, max_Value);// Заполняем массив А рандомными числами через метод Array_Random
Array_Print(array_A);// Печатаем массив А через метод Array_print

// Реализуем поставленное условие
int counter = 0;// Инициализируем счетчик для нахождения количества чисел, соответствующих условию
for(int index = 0; index < array_A.Length; index++)
{
   // Специальное условие для первого элемента массива, с него должно проверяться условие
    if (index == 0)
    {
        array_Test[counter] = array_A[index];
        counter++;
        index++;
    }
    if ((array_A[index - 1] >= 0 && array_A[index] < 0)||(array_A[index - 1] < 0 && array_A[index] > 0))
    {
        array_Test[counter] = array_A[index];
        counter++;
    }
}
Console.WriteLine();

// Заполняем итоговый массив
int[] array_B = new int [counter];// Инициализирование массива В, размерностью равной количеству чисел, проверенных условием
Console.Write("Массив В: ");
// Заполнение массива В с помощью тестового массива, избавление от нулей
for (int index = 0; index < counter; index ++)
{
    array_B[index] = array_Test[index];
}
Array_Print(array_B);// Печать массива В с помощью метода Array_print
*/
