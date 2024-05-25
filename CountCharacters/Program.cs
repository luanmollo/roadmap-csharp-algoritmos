//Count characters (cuantos hay de cada caracter)

string texto = "This is a string and nothing more than a string";

//debo usar un par clave valor (Dictionary)

Dictionary<char, int> characterCount = new Dictionary<char, int>();

foreach (char c in texto)
{
    //verifico que no sea un espacio
    if (!c.Equals(' '))
    {
        //si el diccionario no contiene la clave. entonces la agrego con la cantidad 1
        if (!characterCount.ContainsKey(c))
        {
            characterCount.Add(c, 1);
        }
        //si el diccionario si contiene la clave, entonces aumento el valor en 1
        else
        {
            characterCount[c]++;
        }

    }

}

foreach (var c in characterCount.OrderBy(x => x.Key))
{
    Console.WriteLine($"{c.Key} - {c.Value}");
}