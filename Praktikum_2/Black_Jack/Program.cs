﻿// Решал через одномерные массивы, деревянно, не гибко

// //Перемешиваем каллоду
// int[] random_cards(int[] cards)
// {
//     int temp = 0;
//     int one_card = 0;
//     int two_card = 0;
//     for (int i = 0; i < cards.Length; i++)
//     {
//         one_card = new Random().Next(0, cards.Length);
//         two_card = new Random().Next(0, cards.Length);
//         temp = cards[one_card];
//         cards[one_card] = cards[two_card];
//         cards[two_card] = temp;
//     }
//     return cards;
// }
// //Игрок просит ещё карту
// int[] hit_me(int[] cards_of_pl, int[] cards_take)
// {
//     string answer = "y";
//     char[] more = answer.ToCharArray();
//     int index = 0;
//     int index_cards_pl = 1;
//     Console.WriteLine($"У вас на руках {cards_of_pl[0]}");
//     while (more[0] != 'n')
//     {
//         if (cards_take[index] == 0)
//         {
//             index++;
//             continue;
//         }
//         else
//         {
//             Console.WriteLine("Нужна ещё карта? Если да то введите 'y' если нет то 'n'");
//             answer = Console.ReadLine();
//             more = answer.ToCharArray();
//             if (more[0] != 'n'&& more[0] != 'y') 
//             {
//                 Console.WriteLine("Ваш ответ не ясен.");
//                 continue;
//             }
//             if (more[0] == 'y') 
//             {
//                 cards_of_pl[index_cards_pl] = cards_take[index]; 
//                 Console.WriteLine($"Вы вытянули карту со значением {cards_take[index]}");
//                 cards_take[index] = 0;
//                 index_cards_pl++;
//             }
//             if (more[0] == 'n') break;
            
//         }

//     }
//     return cards_of_pl;
// }
// //Считаем сумму набранных очков
// int sum_array (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         sum += array[i];
//     }
//     return sum;
// }
// //Находим победителя по набранным очкам
// int index_max_array (int[] arr)
// {
//     int index_max = 0;
//     int max = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if (max < arr[i])
//         {
//             if( arr[i] <= 21)
//             {
//             max = arr[i];
//             index_max = i;
//             } 
//         }

//     }
//     return index_max;
// }
// //Сама игра
// string play (int[] cards_pl1, int[] cards_pl2, int[] cards_stok)
// {
//     int quantity_pl = 2;
//     int[] sum = new int[quantity_pl+1];
//     for (int i = 0; i < quantity_pl; i++)
//     {
//         cards_pl1[0] = cards_stok[i];
//         cards_stok[i] = 0;
//         i++;
//         cards_pl2[0] = cards_stok[i];
//         cards_stok[i] = 0;
//     }
//     Console.WriteLine("Очередь 1го игрока:");
//     cards_pl1 = hit_me(cards_pl1, cards_stok);
//     print_cards(cards_pl1);
    
//     sum[1] = sum_array(cards_pl1);
//     Console.WriteLine($"Сумма первого {sum[1]}");

//     Console.WriteLine("Очередь 2го игрока:");
//     cards_pl1 = hit_me(cards_pl2, cards_stok);
//     print_cards(cards_pl2);
   
//     sum[2] = sum_array(cards_pl2);
//      Console.WriteLine($"Сумма второго {sum[2]}");

//     if (index_max_array(sum) == 0)
//     {
//         return "Никто не победил";
//     }
//     else
//     {
//         return $"Победил игрок под номером: {index_max_array(sum)}";
//     }
// }
// //Вывод карт
// void print_cards (int[] pr_cards)
// {
//     for (int i = 0; i < pr_cards.Length; i++)
//     {
//         if(pr_cards[i] != 0)
//         {
//             Console.Write($"{pr_cards[i]} ");
//         }   
//     }
//     Console.WriteLine();
// }
// int[] deck_of_cards = {2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,
//                        5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,
//                        10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
// int[] deck_pl1 = new int[20];
// int[] deck_pl2 = new int[20];
// int[,] deck_pl = new int[2,20];
// Console.WriteLine(play (deck_pl1, deck_pl2, deck_of_cards));

// Решал через двумерные массивы, мега гибко

//Перемешиваем каллоду
int[] random_cards(int[] cards)
{
    int temp = 0;
    int one_card = 0;
    int two_card = 0;
    for (int i = 0; i < cards.Length; i++)
    {
        one_card = new Random().Next(0, cards.Length);
        two_card = new Random().Next(0, cards.Length);
        temp = cards[one_card];
        cards[one_card] = cards[two_card];
        cards[two_card] = temp;
    }
    return cards;
}

//Игрок просит ещё карту
int[,] hit_me(int[,] cards_of_pl, int[] cards_take)
{
    string answer = "y";
    char[] more = answer.ToCharArray();
    int index = 0;
    int index_cards_pl = 1;
    for (int i = 1; i < cards_of_pl.GetLength(0); i++)
    {
        more[0] = 'y';
        Console.WriteLine($"Очередь игрока под номером {i}:");
        Console.WriteLine();
        Console.WriteLine($"У вас на руках {cards_of_pl[i,0]}");
        while (more[0] != 'n')
        {
            if (cards_take[index] == 0)
            {
                index++;
                continue;
            }
            else
            {
                Console.WriteLine("Нужна ещё карта? Если да то введите 'y' если нет то 'n'");
                answer = Console.ReadLine();
                more = answer.ToCharArray();
                if (more[0] != 'n'&& more[0] != 'y') 
                {
                    Console.WriteLine("Ваш ответ не ясен.");
                    continue;
                }
                if (more[0] == 'y') 
                {
                    cards_of_pl[i,index_cards_pl] = cards_take[index]; 
                    Console.WriteLine($"Вы вытянули карту со значением {cards_take[index]}");
                    cards_take[index] = 0;
                    index_cards_pl++;
                }
                
            }

        }
        print_cards(cards_of_pl,i);
        Console.WriteLine($"Сумма очков составляет {sum_array(cards_of_pl,i)}:");
        Console.WriteLine();
    }
    return cards_of_pl;
}
//Считаем сумму набранных очков
int sum_array (int[,] array, int player)
{
    int sum = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[player, i];
        }
    return sum;
}
//Находим победителя по набранным очкам
int index_max_array (int[,] arr)
{ 
    int index_max = 0;
    int max = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if ( max == sum_array(arr,i))
        {
            index_max = 0;
        }
        if (max < sum_array(arr,i))
        {   
            if( sum_array(arr,i) <= 21)
            {
                max = sum_array(arr,i);
                index_max = i;
            } 
        }
    }
    return index_max;
}
//Сама игра
string play (int[,] cards_pl, int[] cards_stok)
{
    int quantity_pl = cards_pl.GetLength(0);
    for (int i = 1; i < cards_pl.GetLength(0); i++)
    {
        cards_pl[i,0] = cards_stok[i];
        cards_stok[i] = 0;
    }
    cards_pl = hit_me(cards_pl, cards_stok);
    int index = index_max_array(cards_pl);
    if (index == 0)
    {
        return "Никто не победил";
    }
    else
    {
        return $"Победил игрок под номером: {index}";
    }
}
//Вывод карт
void print_cards (int[,] pr_cards, int player)
{
    Console.Write("Ваши карты:");
    for (int i = 0; i < pr_cards.GetLength(1); i++)
    {
        if(pr_cards[player,i] != 0)
        {
            Console.Write($"{pr_cards[player,i]} ");
        }   
    }
    Console.WriteLine();
}

int[] deck_of_cards = {2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,
                       5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,
                       10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
deck_of_cards = random_cards(deck_of_cards);

Console.Write("Введите количество игроков: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[,] deck_pl = new int[quantity+1,20];
Console.WriteLine(play (deck_pl, deck_of_cards));