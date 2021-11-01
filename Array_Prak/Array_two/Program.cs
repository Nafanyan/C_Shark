/*
int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}
*/

int index = 0;

int[] array = new int[10];
int[] array_B = new int [10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
int sum = 0;
// Находим среднее арифметическое
while (index <=9)
{
    sum = sum + array[index];
    index ++;
}
sum = sum / array.Length;
Console.WriteLine(sum);
//Исключаем среднее арифметическое
Console.WriteLine();
index = 0;
while (index <= 9)
{
    if(array[index] < sum)
    {
        array_B[index] = array[index];
        Console.WriteLine(array_B[index]);
        
    }
    index++;
    
}
Console.WriteLine(array_B.Length);
