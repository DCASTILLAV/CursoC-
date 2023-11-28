using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando un array Multidimensional
           string[,] edades = new string[3, 2]; // Una matriz de 3 fila y 2 columnas
           //insertamos datos en el array edades
           edades[0,0]="Juan";
           edades[0,1]="18 anios";

           edades[1,0]="Maria";
           edades[1,1]="19 anios";

           edades[2,0]="Carlos";
           edades[2,1]="21 anios";
            
            for (int i=0;i<3;i++)
            {         
                 for (int j=0;j<2;j++)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Nombre: " + edades[i,0]);
                        Console.WriteLine("Edad: " + edades[j,1]);
                        Console.WriteLine("----------------------------");
                    }      
            }
        }
    }
}