//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int number = ReadLine("Введите число: ");
int b = Numberb(number);
SumNumbers(number, b);

int ReadLine(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numberb(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int b)
{
    int sum = 0;
    for (int i = 1; i <= b; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}