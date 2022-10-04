string[] arrayFirst = { "*-*", "Hello Rustem", "-_-", "20", "superhero", "-1" };
Printmassive2(arrayFirst);
Printmassive2(GetSecondarray(arrayFirst));
string[] GetSecondarray(string[] array)
{
   string[] array2 = { "", "", "", "","","" };
    int m=3;
    for (int i = 0; i < array.Count(); i++)
    {
                if (array[i].Length <= m)
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