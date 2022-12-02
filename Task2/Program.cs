System.Console.WriteLine("Введите число");
void SummaChisel()
{
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (a > 0)
{
    b = b + (a % 10);
    a /= 10;
}
Console.WriteLine(b);
}

SummaChisel();