// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int show_second_number(int iskomoe){
    int result = (iskomoe/10)%10;
    return result;
}

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(show_second_number(number));
