int num1 = 0; int num2 = 0;


Console.WriteLine("калькулятор для детей с садика 1000-7 гуль C#\r");
Console.WriteLine("------------------------\n");


Console.WriteLine("выберите любое число и напишите его");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("выберите другое число и напишите его");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("выберите лююое действие из списка с помощью букв");
Console.WriteLine("\ta - плюс");
Console.WriteLine("\ts - минус");
Console.WriteLine("\tm - умножить");
Console.WriteLine("\td - поделить");
Console.Write("твой выбор? - ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.WriteLine("понял?????????\n");
Console.ReadKey();