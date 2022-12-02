System.Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

void Power()
{
    double power = (Math.Pow(a, b));
    Console.WriteLine($"Число {a} в степени {b} = {power}");
}

Power();