// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите трехзначное число");

int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 < 100)
{
    Console.WriteLine("Введите трехзначное число");
    number1 = Convert.ToInt32(Console.ReadLine());
}
int otvet1 = (number1 % 100) / 10;
Console.WriteLine(otvet1);





Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
  string num = number2.ToString();
if (num[2] > 0)
{
    Console.WriteLine (num[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



int sum = Convert.ToInt32(Console.ReadLine());
int (a) = 1;
if (sum>99)
{
    a = (sum % 100) % 10;
    Console.WriteLine (a);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}