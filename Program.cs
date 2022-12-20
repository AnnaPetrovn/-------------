void GetLastDigit(int number)
{
    if (number < 1000 && number > 99)

    {
        int lastDigit = number % 10;
        Console.WriteLine(lastDigit);
    }
}

int tu = 567;
GetLastDigit (tu);





