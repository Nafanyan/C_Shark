/*Проверить, что натуральное число m

является счастливым пятизначным
образовано тремя цифрами, составляющими арифметическую прогрессию
образовано четырмя одинаковыми цифрами*/

//является счастливым пятизначным
/*
int m = new Random().Next(10000, 100000);

int m_one = (m - m % 10000)/10000;

int m_two = (m % 10000 - m %1000)/1000 ;

int m_three = (m % 1000 - m % 100)/100 ;

int m_four = (m % 100 - m % 10)/10;

int m_five = m % 10;

if (m_one + m_two == m_four + m_five)
{
    Console.WriteLine($"{m} - счастливое пятизначное");
}
else
{
    Console.WriteLine($"{m} - не счастливое пятизначное");
}
*/


//образовано тремя цифрами, составляющими арифметическую прогрессию
/*
int m = new Random().Next(100, 1000);

int m_one = (m % 1000 - m % 100)/100 ;

int m_two = (m % 100 - m % 10)/10;

int m_three = m % 10;

if (m_two + (m_two - m_one) == m_three)
{
    Console.WriteLine($"{m} - Образовано арифметической прогрессией первых 3х чисел");
}
else
{
    Console.WriteLine($"{m} - Не образовано арифметической прогрессией первых 3х чисел");
}
*/

// образовано 4мя одинаковыми цифрами
/*
int m = new Random().Next(1000, 10000);

int m_one = (m % 10000 - m %1000)/1000 ;

int m_two = (m % 1000 - m % 100)/100 ;

int m_three = (m % 100 - m % 10)/10;

int m_four = m % 10;

if ( (m_one == m_two) && (m_one == m_three) && (m_one == m_four ))
{
    Console.WriteLine($"{m} - Образовано 4мя одинаковыми цифрами");
}
else
{
    Console.WriteLine($"{m} - не образовано 4мя одинаковыми цифрами");
}
*/