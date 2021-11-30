
//Игрок просит ещё карту
int[,] HitMe(int[,] cardsOfPlayer, int[] cardsTake)
{
    for (int i = 1; i < cardsOfPlayer.GetLength(0); i++)
    {
        int index = 0;
        int indexCardsPlayer = 1;
        char more = 'y';
        Console.WriteLine($"Очередь игрока под номером {i} \nУ вас на руках {cardsOfPlayer[i,0]} ");
        while (more != 'n')
        {
            if (cardsTake[index] == 0){index++; continue;}
            else
            {    
                Console.WriteLine("Нужна ещё карта? Если да то введите 'y' если нет то 'n'");
                more =  Convert.ToChar(Console.ReadLine());
                if (more != 'n'&& more != 'y') {Console.WriteLine("Ваш ответ не ясен.");continue;}
                if (more == 'y') 
                {
                    cardsOfPlayer[i,indexCardsPlayer] = cardsTake[index];
                    Console.WriteLine($"Вы вытянули карту со значением {cardsTake[index]}");
                    if (cardsTake[index] == 11) {cardsOfPlayer[i,indexCardsPlayer] = Change11To1(cardsOfPlayer, i);}
                    cardsTake[index] = 0;
                    indexCardsPlayer++;
                }
                
            }

        }
        PrintCards(cardsOfPlayer,i);
        Console.WriteLine();
    }
    return cardsOfPlayer;
}
//Считаем сумму набранных очков
int SumArray (int[,] array, int player)
{
    int sum = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[player, i];
        }
    return sum;
}
//Находим победителя по набранным очкам
int IndexMaxArray (int[,] arr)
{ 
    int indexMax = 0;
    int max = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if ( max == SumArray(arr,i))
        {
            indexMax = 0;
        }
        if (max < SumArray(arr,i))
        {   
            if( SumArray(arr,i) <= 21)
            {
                max = SumArray(arr,i);
                indexMax = i;
            } 
        }
    }
    return indexMax;
}
//Сама игра
string Play (int[,] cardsPlayer, int[] cardsStok)
{
    int quantityPlayer = cardsPlayer.GetLength(0);
    for (int i = 1; i < cardsPlayer.GetLength(0); i++)
    {
        cardsPlayer[i,0] = cardsStok[i];
        cardsStok[i] = 0;
    }
    cardsPlayer = HitMe(cardsPlayer, cardsStok);
    int index = IndexMaxArray(cardsPlayer);
    for (int i = 1; i < cardsPlayer.GetLength(0); i++)
    {
        Console.WriteLine($"Итоги раунда, игрок {i} = {SumArray(cardsPlayer,i)}");
    }
    if (index == 0){return "Никто не победил";}
    else {return $"Победил игрок под номером: {index}";}
}
//Вывод карт
void PrintCards (int[,] printCards, int player)
{
    Console.Write("Ваши карты:");
    for (int i = 0; i < printCards.GetLength(1); i++)
    {
        if(printCards[player,i] != 0)
        {
            Console.Write($"{printCards[player,i]} ");
        }   
    }
    Console.WriteLine();
}

int[] deckOfCards = {2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,
                       5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,
                       10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
deckOfCards = RandomCards(deckOfCards);

Console.Write("Введите количество игроков: ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] deckPlayer = new int[quantity+1,20];
Console.WriteLine(Play (deckPlayer, deckOfCards));