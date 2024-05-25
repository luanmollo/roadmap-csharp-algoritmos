//Remove duplicates

//string texto = "This is a string and nothing more than a string";
//string resultado = "";

//for(int i = 0; i < texto.Length; i++)
//{
//    if (!resultado.Contains(texto[i].ToString().ToLower()))
//        resultado += texto[i].ToString().ToLower();
//}

//Console.WriteLine(resultado);

//solución con array
string texto = "This is a string and nothing more than a string";
char[] arreglo = texto.ToCharArray();
string resultado = "";

for (int i = 0; i < arreglo.Length; i++)
{
    if (!resultado.Contains(arreglo[i].ToString().ToLower()))
        resultado += arreglo[i].ToString().ToLower();
}

Console.WriteLine(resultado);