// Задать положительное вещественное число m. Cоставить целое число n из цифр

//десятков и сотых m
//единиц и сотых m
//сотен и десятых m
/*
double m = 1223.496;
// находим десяток
double n_one = Math.Floor(m / 100);
n_one = m - n_one * 100;
n_one = Math.Floor(n_one/10); 
// находим сотые
double n_two = m * 10;
n_two = Math.Floor(n_two);
n_two = m * 100 - n_two * 10;
n_two = Math.Floor(n_two);
Console.WriteLine($"{n_one}{n_two}");
*/

/*
double m = 1223.496;
// находим еденицу
double n_one = Math.Floor(m / 10);
n_one = m - n_one * 10;
n_one = Math.Floor(n_one); 
// находим сотые
double n_two = m * 10;
n_two = Math.Floor(n_two);
n_two = m * 100 - n_two * 10;
n_two = Math.Floor(n_two);
Console.WriteLine($"{n_one}{n_two}");
*/

double m = 1223.496;

// находим сотые
double n_one = m * 10;
n_one = Math.Floor(n_one);
n_one = m * 100 - n_one * 10;
n_one = Math.Floor(n_one);
// находим десятую
double n_two = Math.Floor(m); 
n_two = m*10 - n_two * 10;
n_two = Math.Floor(n_two);
Console.WriteLine($"{n_one}{n_two}");