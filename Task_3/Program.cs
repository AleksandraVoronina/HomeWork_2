//Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int num = Convert.ToInt32(Console.ReadLine());
if(num>5 && num<8){
    Console.WriteLine("Да");
}
else if (num>0 && num<=5)
{
    Console.WriteLine("Нет");
}
else{
    Console.WriteLine("Введено не правильное число");
}