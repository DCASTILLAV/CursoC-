using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando un array Multidimensional
           
           string[,] edades = new string[3, 2]; // Una matriz de 3 fila y 2 columnas
          // string[,,] cubo = new string[2, 2, 2]; // Un cubo de 2x2x2

           //insertamos datos en el array edades
           edades[0,0]="Juan";
           edades[0,1]="18 anios";

           edades[1,0]="Maria";
           edades[1,1]="19 anios";
       
          Console.WriteLine("La matriz contiene: " + edades[0,0] + " " + edades[0,1]);
          Console.WriteLine("La matriz contiene: " + edades[1,0] + " " + edades[1,1]);
        }
    }
}