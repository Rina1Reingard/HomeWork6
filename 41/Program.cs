/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
int[]FillArray(string message)
{
    Console.WriteLine(message);
    var str = Console.ReadLine();
    int []a = Array.ConvertAll(str.Split(','), s => int.Parse(s));
    String.Join(",", a);
    return a;
}
int Count(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int[]ar = FillArray("введите числа через запятую");
int a = Count(ar);
Console.WriteLine($"Количество четных чисел равно {a}");
