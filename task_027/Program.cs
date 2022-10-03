using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

WriteLine($"Сумма цифр числа = {digit_sum(number)}");

int digit_sum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}