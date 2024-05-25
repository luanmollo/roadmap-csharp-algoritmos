using System.Runtime.ExceptionServices;

bool esPalindromo(string x)
{
    for (int i = 0; i < (x.Length / 2); i++)
    {
        if (!x[i].Equals(x[x.Length - 1 - i]))
            return false;
    }

    return true;
}


Console.WriteLine(esPalindromo("12321"));