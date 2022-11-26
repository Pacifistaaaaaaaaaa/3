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

