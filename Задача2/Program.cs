//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7 min = 5
//a = 2 b = 10 -> max = 10 min = 2
//a = -9 b = -3 -> max = -3 min = -9

Console.Clear();
Console.Write("Введите первое число: ");
string n1 = Console.ReadLine();
int number1 = int.Parse(n1);
Console.Write("Введите второе число: ");
string n2 = Console.ReadLine();
int number2 = int.Parse(n2);

if (number1 == number2)
    {
        Console.Write("Числа равны");
    }

else
    {
    if (number1 > number2)
        {
        Console.Write("max = ");
        Console.Write(number1);
        Console.Write(" min = ");
        Console.Write(number2);
        }
    else
        {
        Console.Write("max = ");
        Console.Write(number2);
        Console.Write(" min = ");
        Console.Write(number1);
        }

    }

