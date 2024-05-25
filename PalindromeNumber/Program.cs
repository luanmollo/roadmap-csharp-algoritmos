//Given an integer x, return true if x is a palindrome, and false otherwise.

//Example 1:
//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.

//Example 2:
//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

//Example 3:
//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

//bool esPalindromo(int x)
//{
//    string numero = x.ToString();
//    string aux = "";

//    for (int i = numero.Length - 1; i >= 0; i--)
//    {
//        aux += numero[i];
//    }

//    if (aux.Equals(numero)) return true;

//    return false;

//}

//solucion mejorada: (solo evalua hasta la mitad)
bool esPalindromo(int x)
{
    string numero = x.ToString();

    for (int i = 0; i < (numero.Count() / 2); i++)
    {
        if (numero[i] != numero[numero.Count() - 1 - i])
            return false;
    }

    return true;

}

Console.WriteLine("Ejemplo 1:");
Console.WriteLine(esPalindromo(121));

Console.WriteLine("Ejemplo 2:");
Console.WriteLine(esPalindromo(-121));

Console.WriteLine("Ejemplo 3:");
Console.WriteLine(esPalindromo(10));