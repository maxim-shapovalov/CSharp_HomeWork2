//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// bool match = false; //true если найдена разрядность введенного числа
// int multiplier = 10; //множитель
// int x1, x2, z; 
// int result = -1;

// Console.Write("Введите целое число ");
// int x = Convert.ToInt32(Console.ReadLine()); //17524

// //int x = 17524;
// //Console.WriteLine(17524%1000);//524
// //Console.WriteLine(17524%100);//24
// //Console.WriteLine(17524%10);//4

// if (x < 100) //если третьей цифры нет
// {
//     Console.Write("Третьей цифры нет!");
// }
// else 
// while (match == false) {
//     z = x%multiplier; //остаток
//     if ((100 < z) && (z < 1000)) //остаток, с которым можно работать должен быть равен, например 524
//     {
//         Console.WriteLine("x%multiplier = " + z);
//         x1 = x%(multiplier); //75
//         Console.WriteLine("x%multiplier = " + x1);
//         x2 = (x1%multiplier)/10; //5
        
//         result = (x1 - x2) / multiplier;
        
//         Console.WriteLine("Третья цифра введенного числа: " + result);
//         match = true;
//     }
//     else //multiplier = multiplier * 10;
//     {
//         multiplier = multiplier * 10;
//     }
// }

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32;
    return result;
}

int  GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Ведите число ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}