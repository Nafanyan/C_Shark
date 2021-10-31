/*Даны координаты концов двух отрезков [a; b], [c; d]. Верно ли, что

отрезки не пересекаются
отрезки пересекаются строго в одной точке
один отрезок вложен в другой*/
//перемеенные точек
int a_one = -10;
int b_one = -7;
int c_one = 10;
int d_one = 17;

int a_two = 0;
int b_two = 10;
int c_two = 16;
int d_two = -14;
//вводим переменные счетчика и переменные координат самого длинного отрезка
int check = 0;
int x0;
int x1;
int y0;
int y1;
// находим координаты самого длинного отрезка по оси x
if (c_one - a_one > c_two - a_two)
{
    x0 = a_one;
    x1 = c_one;
}
else
{
    x0 = a_two;
    x1 = c_two;
}
// проверяем принадлежность точек более короткого отрезка к более длинному по оси x
int x = x0;
while (x >= x0 && x <= x1)
{
    if (x >= a_two && x <= c_two)
    {
        check ++;
        break;
    }
    if (x >= a_one && x <= c_one)
    {
        check ++;
        break;
    }
    x++;
}
// находим координаты самого длинного отрезка по оси y
if (d_one - b_one > d_two - a_two)
{
    y0 = b_one;
    y1 = d_one;
}
else
{
    y0 = b_two;
    y1 = d_two;
}
// проверяем принадлежность точек более короткого отрезка к более длинному по оси y
int y = y0;
while (y >= y0 && y <= y1)
{
    if (y >= b_two && y <= d_two)
    {
        check ++;
        break;
    }
    if (y >= b_one && y <= d_one)
    {
        check ++;
        break;
    }
    y++;
}
// проверка условия на пересечение
if (check == 2)
{
Console.WriteLine("Отрезки пересекаются");
}
else
{
Console.WriteLine("Отрезки не пересекаются");
}

