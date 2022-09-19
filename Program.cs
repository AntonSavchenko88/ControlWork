int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int dimension = Input("Введите размерность массива");
string[] array = new string[dimension];
string[] SortArray = new string[array.Length];
void FillArray()
{
    for (int i = 0; i < dimension; i++)
    {
        Console.WriteLine("Введите {0}-й элемент массива", i + 1);
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
    Console.WriteLine();
}
FillArray();
void PrintArrayWithIF(string[] array, string[] SortArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            SortArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref SortArray, count);
    Console.WriteLine("[{0}]", string.Join(", ", SortArray));
   
}
PrintArrayWithIF(array, SortArray);

