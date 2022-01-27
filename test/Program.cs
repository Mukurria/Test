//
void FillArray(string[] absinthe)
{
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        absinthe[i] = Console.ReadLine();
    }
}
void PrintArray(string[] absinthe)
{
    Console.Write("[ ");
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        Console.Write($"{absinthe[i]} ");
    }
    Console.Write("]");
}
void NewArray(string[] absinthe)
{
    Console.Write(" = [ ");
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        if (absinthe[i].Length <= 3)
        {
            Console.Write($"{absinthe[i]} ");
        }

    }
     Console.Write("]");
}
Console.WriteLine("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());
string[] absinthe = new string[N];
FillArray(absinthe);
PrintArray(absinthe);
NewArray(absinthe);