// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int multiplier = 10; //множитель
int count = 0; // разрядность введенного числа
int x_count;
int x, f = -1, z = -10; 

Console.Write("Введите целое число ");
x = Convert.ToInt32(Console.ReadLine()); //12345

//x = 4402;

//Console.WriteLine(12345%10000);//2345
//Console.WriteLine(12345%1000);//345
//Console.WriteLine(12345%100);//45
//Console.WriteLine(12345%10);//5

// вычислим разрядность числа
x_count = x;
while (x_count > 0)
    {
        count++;
        x_count = x_count / 10;
    }
Console.WriteLine("Разрядность введенного числа равна = " + count);

if (count < 3) //если третьей цифры нет
{
    Console.Write("Число двузначное, третьей цифры нет!");
}

else if (count == 3) //если число трехзначное
{
        z = x % 10;
        Console.WriteLine("Третья цифра = " + z);   
}

else if (count > 3) //если число более, чем трезначное
    {
        f = count - 3;
        for (int i = 1; i < f; i++)
        {
            multiplier = multiplier * 10;
            z = x / multiplier;
        }
        z = z % 10;
        Console.WriteLine("Третья цифра = " + z);
    }















//Console.WriteLine("z = " + x%multiplier);
// while (match == false) {
//     z = x%multiplier; //остаток
//     Console.WriteLine("z = " + z);
//     //if ((100 < z) && (z < 1000)) //остаток, с которым можно работать должен быть равен, например 524
//     if (100 < z)
//     {
//         Console.WriteLine("x%multiplier = " + z);
//         x1 = x%multiplier; //345
//         //Console.WriteLine("x1 = " + x1);
//         //x2 = (x1%multiplier)/(multiplier/10); //34
//         //Console.WriteLine("x2 = " + x2);
//         // result = (x1 - x2) / multiplier;
//         // //result = 
//         // Console.WriteLine("Третья цифра введенного числа: " + result);
//         match = true;
//     }
//     else //multiplier = multiplier * 10;
//     {
//         multiplier = multiplier * 10;
//         Console.WriteLine("multiplier = " + multiplier);
//     }
// }


// Эталонное решение
// int Promt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32;
//     return result;
// }

// int  GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Promt("Ведите число ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }



// // Получаем рандомное число
// Random rand = new Random(); //создаем класс rand как копию класса Random
// int number = rand.Next(10, 100); //запускаем метод Next с диапазоном от 10 до 99 и присваиваем результат его вывода переменной number
// // c тем же успехом можно все записать в одну строку
// // int number = new Random().Next(10, 100)

// int a = number / 10; // находим первую цифру
// int b = number % 10; // находим вторую цифру, если число двузначное

// if (a > b){
//     Console.WriteLine($"Our output is {number}. First digit > second digit. Result {a}");
// }
// else if (a < b){
//     Console.WriteLine($"Our output is {number}. First digit < second digit. Result {b}");
// }
// else {
//     Console.WriteLine($"Our output is {number}. First digit = second digit");
// }