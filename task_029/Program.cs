using static System.Console;

int[] array = array_create();

int[] array_create()
{
    int[] result = new int[8];
    Write("[");
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0,100);
        Write($"{result[i]},");
    }
    Write("\b]");
    return result;
}