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

    string HelloWorld="Hello World!";
    int charCount = HelloWorld.Length;
    char [] caracteres = new char[charCount];

  
for (int i = 0; i < HelloWorld.Length; i++) {
    int newIndex = (HelloWorld.Length - 1) - i;
    caracteres[newIndex] = HelloWorld[i];
}
Console.WriteLine(caracteres);

    

     }


  }

   }
 
