using static System.Console;

array_create_and_print();

void array_create_and_print()
{
    int[] result = new int[8];
    Write("[");
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0,100);
        Write($"{result[i]},");
    }
    Write("\b]");
}