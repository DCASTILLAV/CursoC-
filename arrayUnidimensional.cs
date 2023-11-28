using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando un array unidimensional

           //En este caso hemos declarado un array denominado numeros que almacenara 5 numeros
            int [] numeros = new int [5];
            numeros[0]=1;
            numeros[1]=2;
            numeros[2]=3;
            numeros[3]=4;
            numeros[4]=5;
            
           //ahora vamos a agregar datos a esos arrays comenzamos agregando los 5 numeros
           //int []numeros={1,2,3,4,5}; // Inicialización implícita
            
           //aqui declararemos un array tipo string que almacene 3 cadenas
            string [] frutas= new string[3];
            frutas[0]="manzana";
            frutas[1]="pera";
            frutas[2]="uva";

           
            //recorremos numeros
           for (int i=0;i<numeros.Length;i++)
           {
            Console.WriteLine("numeros: "+ numeros[i]);
           }
            
            Console.WriteLine("********************");
            //recorremos frutas
            for (int i=0;i<frutas.Length;i++)
           {
            Console.WriteLine("frutas: "+ frutas[i]);
           }
        }
    }
}