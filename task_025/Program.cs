using static System.Console;

WriteLine("Введите A");
float a = float.Parse(ReadLine()!);

WriteLine("Введите B");
int b = int.Parse(ReadLine()!);

Write($"A^B = {pow(a,b)}");

float pow(float number, int power)
{
    float result = 1;
    for(int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}