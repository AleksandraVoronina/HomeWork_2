// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

char vtoraya(string chislo, int num_of_letter)
{
    if (chislo.Length >= num_of_letter)
    {
        return chislo[num_of_letter-1];
    }
    else
    {
    Console.Write($"{num_of_letter}-й элемент отсутсвует");
    }
    return '!';
}
Console.WriteLine(vtoraya(Console.ReadLine(),Convert.ToInt32(Console.ReadLine())));
