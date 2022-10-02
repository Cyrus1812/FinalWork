string[] arrayFirst = { "*-*", "Hello Rustem", "-_-", "2022", "superhero" };
Random random = new Random();
Printmassive2(arrayFirst);
Printmassive2(GetSecondarray(arrayFirst));
string[] GetSecondarray(string[] array)
{
    int LengthArray = random.Next(0, 4);
    int randomIndex;
   string[] array2 = {"","","","",""} ;
    for (int i = 0; i < LengthArray; i++)
    {
        randomIndex = random.Next(0, 5);
        array2[i] = array[randomIndex];
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