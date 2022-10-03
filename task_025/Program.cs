using static System.Console;

Write("Введите число A: ");
float a = float.Parse(ReadLine()!);

Write("Введите степень B: ");
int b = int.Parse(ReadLine()!);

Write($"A^B = {pow(a,b):f2}");

float pow(float number, int power)
{
    float result = 1;
    for(int i = 0; i < power; i++) result *= number;
    return result;
}