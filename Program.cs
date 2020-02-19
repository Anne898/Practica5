using System;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
             string cadenaInvertida = "";
             string cadena= "Hello World!";

    foreach(char letra in cadena){
     
      cadenaInvertida = letra + cadenaInvertida;
    }

    Console.WriteLine(cadenaInvertida);

    //clase

    string helloWorld="Hello World!";
    int charCount = helloWorld.Length;
    char [] caracteres = new char[charCount];

  
for (int i = 0; i < helloWorld.Length; i++) {
    int newIndex = (helloWorld.Length - 1) - i;
    caracteres[newIndex] = helloWorld[i];
}
Console.WriteLine(caracteres);

    

     }


  }

   }
 
 
