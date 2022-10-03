string[] arrayFirst = { "*-*", "Hello Rustem", "-_-", "20", "superhero", "-1" };
Printmassive2(arrayFirst);
Printmassive2(GetSecondarray(arrayFirst));
string[] GetSecondarray(string[] array)
{
    string[] array2 = { "", "", "", "","","" };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= array[0].Length)
        {
            array2[i] = array[i];
        }
    }
    return array2;
}

void Printmassive2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}