//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a, b;
Console.WriteLine("Введите 2 числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
//После применяю " оператор ветвления" 
if (a > b)
{
    Console.WriteLine("max = {0}", a);
}
else
{
    Console.WriteLine("max = {0}", b);
}

//int - цельное число, Integer
//Convert - "преобразование значений" (Toint32 - просто размерность. Выделение памяти для чисел)