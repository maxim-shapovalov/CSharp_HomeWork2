//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 1. Ввод числа
// 2. Проверка на диапазон от 1 по 7
// 3. Проверка на то, что введенное число равно 6 или 7
// 4. Вывод сообщения


// 2. Проверка на диапазон от 1 по 7
bool Check_Day(int dayNumber)
{
    if ((dayNumber > 0) && (dayNumber < 8)) // введен день недели
    {
        return true;   
    } 
    Console.WriteLine("Введен не день недели");
    return false;
}

// 3. Проверка на то, что введенное число равно 6 или 7
bool Check_Weekend(int dayNumber)
{
    if ((dayNumber == 6) || (dayNumber == 7))
    {
        return true;
    }
    return false;
}

Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine()); //1. Ввод числа

if (Check_Day(day)){ // 2. Проверка на диапазон от 1 по 7
    if (Check_Weekend(day)) // 3. Проверка на то, что введенное число равно 6 или 7
    {
        Console.Write("Это выходной!");// 4. Вывод сообщения
    }
    else
    {
        Console.Write("Это простой рабочий день");// 4. Вывод сообщения 
    }
}
























// void CheckA(string A) 
//      { 
//          if(A[0]== A[4] && A[1] == A[3]) 
//          { 
//          Console.WriteLine($"Число {A} является палиндромом"); 
//          } 
//          else 
//          { 
//          Console.WriteLine($"Число {A} не является палиндромом"); 
//          } 
//      }

// int Promt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool IsWeekDay(int IsWeekDay)
// {
//     if (IsWeekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekday(int number)
// {
//     if (number > 0 && number <=7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;
// }

// int IsWeekDay = Promt("Введите день недели ");
// if (ValidateWeekday(weekDay))
// {
//     if (IsWeekend(weekDay))
//     {
//         Console.WriteLine("Выходной");
//     }
//     else
//     {
//         Console.WriteLine("Рабочий день");
//     }
// }