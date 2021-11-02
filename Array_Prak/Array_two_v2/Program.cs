/*

Нарушают порядок возрастания

int[] array_A = new int [10];
int[] array_Test = new int [10];
int index = 0;
int min_Value = -100;
int max_Value = 101;
Console.Write("Исходный массив: ");
while(index < array_A.Length)
{
    array_A[index] = new Random().Next(min_Value, max_Value);
    Console.Write($"{array_A[index]} ");
    index++;
}
int current = array_A[0];
int i = 0;
index = 0;
while(index < array_A.Length)
{
    if(index == 0)
    {
        array_Test[i] = array_A[index];
        current = array_A[index];
        i++;   
    }
    if (current < array_A[index])
    {
        array_Test[i] = array_A[index];
        current = array_A[index];
        i++;  
    }
    index++;
}
Console.WriteLine();
int[] array_B = new int [i];
index = 0;
Console.Write("Массив В: ");
while (index < i)
{
    array_B[index] = array_Test[index];
     Console.Write($"{array_B[index]} ");
     index++;
}
*/
/*

Больше определенного числа

int[] array_A = new int [10];
int[] array_Test = new int [10];
int number = -50; // указанное число
int index = 0;
int min_Value = -100;
int max_Value = 101;
Console.Write("Исходный массив: ");
while(index < array_A.Length)
{
    array_A[index] = new Random().Next(min_Value, max_Value);
    Console.Write($"{array_A[index]} ");
    index++;
}
int i = 0;
index = 0;
while(index < array_A.Length)
{
    if (array_A[index] < number )
    {
        array_Test[i] = array_A[index];
        i++;  
    }
    index++;
}
Console.WriteLine();
int[] array_B = new int [i];
index = 0;
Console.Write("Массив В: ");
while (index < i)
{
    array_B[index] = array_Test[index];
     Console.Write($"{array_B[index]} ");
     index++;
}

*/
/*

Знакочередование

int[] array_A = new int [10];
int[] array_Test = new int [10];
int index = 0;
int min_Value = -100;
int max_Value = 101;
Console.Write("Исходный массив: ");
while(index < array_A.Length)
{
    array_A[index] = new Random().Next(min_Value, max_Value);
    Console.Write($"{array_A[index]} ");
    index++;
}
Console.WriteLine();
int i = 0;
index = 0;
int current = array_A[0];
while(index < array_A.Length)
{

    if ( index == 0)
    {
        array_Test[i] = array_A[index];
        i++;
        index++;
    }
    if ((array_A[index - 1] >= 0 && array_A[index] < 0)||(array_A[index - 1] < 0 && array_A[index] > 0))
    {
        array_Test[i] = array_A[index];
        i++;
    }

    index++;
}
int[] array_B = new int [i];
index = 0;
Console.Write("Массив В: ");
while (index < i)
{
    array_B[index] = array_Test[index];
     Console.Write($"{array_B[index]} ");
     index++;
}
*/
