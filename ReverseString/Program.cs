//Reverse string

//string texto = "palindromo";

//string resultado = "";

//for(int i = texto.Length - 1; i >= 0; i--)
//{
//    //se crea una nueva cadena resultado cada vez que pasa por acá
//    resultado += texto[i];
//}

//Console.WriteLine(resultado);


//solución mejorada (usando un array)

//string texto = "diciembre";

//char[] arreglo = new char[texto.Length];

//int index = 0;

//for (int i = texto.Length - 1; i >= 0; i--)
//{
//    arreglo[index] = texto[i];
//    index++;
//}

//foreach (char c in arreglo)
//{
//    Console.Write(c);
//}


//solución usando Array.Reverse()

string texto = "computadora";

char[] arreglo = texto.ToArray();

Array.Reverse(arreglo);

string resultado = new string(arreglo);
Console.WriteLine(arreglo);