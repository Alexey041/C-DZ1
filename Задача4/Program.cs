//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
string n1 = Console.ReadLine();
int number1 = int.Parse(n1);
Console.Write("Введите второе число: ");
string n2 = Console.ReadLine();
int number2 = int.Parse(n2);
Console.Write("Введите третье число: ");
string n3 = Console.ReadLine();
int number3 = int.Parse(n3);
int max = number1;

if (max < number2)
    {
        max = number2;
    }

if (max < number3)
    {
        max = number3;
    }

Console.Write(max);