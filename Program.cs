// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int randomNum = new Random().Next(100,1000);
Console.WriteLine(randomNum);
int firstDigit = randomNum / 100;
int thirdDigit = randomNum % 10;
int result = (randomNum - ((firstDigit * 100) + thirdDigit)) / 10;
Console.WriteLine(result);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = Convert.ToInt32(Console.ReadLine());
int result1 = 0;
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result1 = number % 10;
    Console.WriteLine(result1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру,обозначающую день недели.");
int day = Convert.ToInt32(Console.ReadLine());
while (day <= 0 || day > 7)
{
    Console.WriteLine("Недопустимое значение.Введите цифру в диапозоне от 1 до 7.");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day >= 6)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

// int size = 10;
// int[] array = new int[10];
// int randomNum = 0;
// int i = 0;
// // int digit1;
// int digit2;
// int digit3;
// while (i < size)
// {
//     randomNum = Convert.ToInt32(new Random().Next(10,1000));
//     Console.WriteLine(randomNum);
//     array[i] = Convert.ToInt32(randomNum);
//     Console.WriteLine(array[i]);
//     int sum = 0;
//     int ymn = 1;
//     string randomNumString = randomNum.ToString();
//     for (int j = 0; j < randomNumString.Length; j++)
//     {
//        int digit1 = int.Parse(randomNumString[j].ToString());
       
//        sum += digit1;
//        ymn *= digit1;
//     }
//     return ymn % sum == 0;
//     Console.WriteLine(sum);
//     Console.WriteLine(ymn);
    
    
    




//     i++;
// }
