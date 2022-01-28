void FillArray(string[] absinthe)
{
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        absinthe[i] = Console.ReadLine();
    }
}
void PrintArray(string[] absinthe)
{
    //Console.Write("[ ");
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        Console.Write($"{absinthe[i]} ");
        //if (absinthe[i].Length >= 1)
        //{
        //    Console.Write(" ");
        //}
    }
    //Console.Write(" ]");
}
void NewArray(string[] absinthe, string[] zima)
{
    int j = 0;
    for (int i = 0; i < absinthe.GetLength(0); i++)
    {
        if (absinthe[i].Length <= 3)
        {
            zima[j] = absinthe[i];
            j++;
        }
    }
}
Console.WriteLine("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());
string[] absinthe = new string[N];
string[] zima = new string[N];
FillArray(absinthe);
PrintArray(absinthe);
Console.Write("-> ");
NewArray(absinthe, zima);
PrintArray(zima);