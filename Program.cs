int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int dimension = Input("Введите размерность массива");
string [] array = new string[dimension];
void FillArray()
{
    for (int i = 0; i < dimension; i++)
    {
        Console.WriteLine("Введите {0}-й элемент массива", i + 1);
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
FillArray();