/*Написать программу, вычисляющую значение периодической функции f(x), в произвольной точке x, если на промежутке [a;b], 
который составляет один её период, значения функции вычисляются по формуле

[-3; 3], f(x) = |x| - 1
[-10; -2], f(x) = 1/x + 0.6
[-4; 3], f(x) = Cos(|π*x|)*/

//объявление переменных функции, точки, которая будет приводиться к промежутку и заданной точки

/*[-3; 3], f(x) = |x| - 1


double function;
double x = -39;
double x_num = x;
// Условие, что бы привести точку к промежутку
while(x < -3 || x > 3 )
{
    if(x < -3)
    {
        x = x + 6;
    }
    else
    {
        x = x - 6;
    }
}
function = Math.Abs(x) - 1;
Console.WriteLine($"Значение функции в точке {x_num} равно {function}");
*/

/*[-10; -2], f(x) = 1/x + 0.6

double function;
double x = -1;
double x_num = x;
// Условие, что бы привести точку к промежутку
while(x < -10 || x > -2 )
{
    if(x < -10)
    {
        x = x + 9;
    }
    else
    {
        x = x - 9;
    }
}
function = 1/x + 0.6;
Console.WriteLine($"Значение функции в точке {x_num} равно {function}");
*/

/*[-4; 3], f(x) = Cos(|π*x|)

double function;
double x = -4;
double x_num = x;
// Условие, что бы привести точку к промежутку
while(x < -4 || x > 3 )
{
    if(x < -4)
    {
        x = x + 8;
    }
    else
    {
        x = x - 8;
    }
}
function = Math.Cos(Math.Abs(3.14*x));
Console.WriteLine($"Значение функции в точке {x_num} равно {function}");
*/