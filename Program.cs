// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(threeDigitNumber);

Console.WriteLine("вторая цифра этого числа:"+number[1]);

// Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

Console.Write("Введите трехзначное число: ");

int randomNumber = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(randomNumber); 

if (number.Length > 2)
{
    Console.WriteLine("третье число этого числа:"+number[2]);
}

else
 {
  Console.WriteLine("третьей цифры нет");
 }


 //Напишите программу, которая принимает на вход цифру,обозначающую
 //день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
 {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine($"{dayNumber} да");
  }
  
  else Console.WriteLine($"{dayNumber} нет");
}

CheckingTheDayOfTheWeek(dayNumber);
