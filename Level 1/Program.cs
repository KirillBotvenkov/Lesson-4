//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
{
break;
}
else
{
Console.WriteLine("ввели не число или меньше 1.");
}
}

return result;
}

int number = GetNumber("Введите число больше 1");
int number2 = GetNumber("Введите число больше 1");
int result= 1;
{
    for (int i = 1; i <= number2; i++)
    {
        result = result * number;
    }

Console.WriteLine($"Число {number} в степени {number2} = {result}");
}
return result;
