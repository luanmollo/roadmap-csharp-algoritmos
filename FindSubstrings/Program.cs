//Find all substrings from string

//string texto = "abcdefg";
//List<string> list = new List<string>();

//for (int i = 0; i < texto.Length; i++)
//{
//    for (int j = 1; j <= texto.Length - i; j++)
//    {
//        //substring(startIndex, length)
//        //recorro desde el indice hasta la longitud de la cadena. para esto voy desde j=i hasta j= longitud de la cadena menos el indice i (para no salirme fuera de la longitud de la cadena)
//        list.Add(texto.Substring(i, j));
//    }
//}

//foreach(var c in list)
//{
//    Console.WriteLine(c);
//}

//solucion sin usar método substring

//string texto = "abcd";

//for(int i = 0; i < texto.Length; i++)
//{
//    string substring = "";
//    for(int j = i; j < texto.Length; j++)
//    {
//        substring += texto[j];

//        Console.WriteLine(substring);
//    }
//}


//solucion usando StringBuilder (es más óptimo)

using System.Text;

string texto = "abcd";

for (int i = 0; i < texto.Length; i++)
{
    StringBuilder substring = new StringBuilder(texto.Length - i);

    for (int j = i; j < texto.Length; j++)
    {
        substring.Append(texto[j]);

        Console.WriteLine(substring);
    }
}

