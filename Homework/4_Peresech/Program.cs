/*Даны координаты концов двух отрезков [a; b], [c; d]. Верно ли, что

отрезки не пересекаются
отрезки пересекаются строго в одной точке
один отрезок вложен в другой*/

/*
отрезки не пересекаются
int a_one = -10;
int b_one = 11;
int c_one = 10;
int d_one = 11;

int a_two = 0;
int b_two = 1;
int c_two = 1;
int d_two = 10;
//вводим переменные счетчика и переменные координат самого длинного отрезка
int x0 = 0;
int x1 = 0;
int check = 0;
// нашли минимальный интервал для поиска по оси x
if (c_one - a_one > c_two - a_two)
{
    x0 = a_two;
    x1 = c_two;
}
if (c_one - a_one < c_two - a_two)
{
    x0 = a_one;
    x1 = c_one;
}
while (x0 <= x1)
{
    double y_one = ((x0 - a_one)*(d_one - b_one)/(c_one - a_one)) + b_one;
    double y_two = ((x0 - a_two)*(d_two - b_two)/(c_two - a_two)) + b_two;
    if (y_one == y_two)
    {
        check++;
    }
    x0++;
}
if (check == 0)
{
    Console.WriteLine("Не пересекаются");
}
else 
{
    Console.WriteLine("Пересекаются");
}
*/
/*
отрезки пересекаются строго в одной точке
int a_one = -10;
int b_one = 1;
int c_one = 10;
int d_one = 1;

int a_two = 0;
int b_two = 1;
int c_two = 1;
int d_two = 10;
//вводим переменные счетчика и переменные координат самого длинного отрезка
int x0 = 0;
int x1 = 0;
int check = 0;
// нашли минимальный интервал для поиска по оси x
if (c_one - a_one > c_two - a_two)
{
    x0 = a_two;
    x1 = c_two;
}
if (c_one - a_one < c_two - a_two)
{
    x0 = a_one;
    x1 = c_one;
}
while (x0 <= x1)
{
    double y_one = ((x0 - a_one)*(d_one - b_one)/(c_one - a_one)) + b_one;
    double y_two = ((x0 - a_two)*(d_two - b_two)/(c_two - a_two)) + b_two;
    if (y_one == y_two)
    {
        check++;
    }
    x0++;
}
if (check == 1)
{
    Console.WriteLine("Пересекаются строго в одной точке");
}
else 
{
    Console.WriteLine("Пересекаются в нескольких точках либо не пересекаются");
}
*/


/*один отрезок вложен в другой
int a_one = -10;
int b_one = 1;
int c_one = 10;
int d_one = 1;

int a_two = -10;
int b_two = 1;
int c_two = 5;
int d_two = 1;
//вводим переменные счетчика и переменные координат самого длинного отрезка
int x0 = 0;
int x1 = 0;
int check = 0;
// нашли минимальный интервал для поиска по оси x
if (c_one - a_one > c_two - a_two)
{
    x0 = a_two;
    x1 = c_two;
}
if (c_one - a_one < c_two - a_two)
{
    x0 = a_one;
    x1 = c_one;
}
int check_point = 0;
while (x0 <= x1)
{
    double y_one = ((x0 - a_one)*(d_one - b_one)/(c_one - a_one)) + b_one;
    double y_two = ((x0 - a_two)*(d_two - b_two)/(c_two - a_two)) + b_two;
    if (y_one == y_two)
    {
        check++;
    }
    x0++;
    check_point++;
}
if (check == check_point)
{
    Console.WriteLine("Один отрезок вложен в другой");
}
else 
{
    Console.WriteLine("Пересекаются в нескольких точках либо не пересекаются");
}
*/