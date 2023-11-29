using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //autor: Danny Castilla 28.11.2023 21:30
           // Console.WriteLine("Hello world!");        
           //declarando un array Multidimensional
           //Mostrar las notas y el promedio de una alumno
            //sabiendo que las notas ingresadas son las siguientes:
            //nota 1= 15 ; nota 2 = 18 ; y nota 3 = 16
            //trabajarlo en base a arrays y estructura tipo bucle
            
            //declaramos la variable suma y promedio
            decimal suma=0;
            decimal promedio=0;
            
           int[] notas = new int[3]; // Una matriz de 3 fila y 1 columnas
           //insertamos datos en el array edades
           notas[0]=15;
           notas[1]=18;
           notas[2]=16;

            for (int i=0;i<3;i++)
            {                   
                Console.WriteLine("----------------------------");
                Console.WriteLine("Nota "+ (i+1 )+ " = " + notas[i]);
                Console.WriteLine("----------------------------");
                decimal nota_obtenida;
                nota_obtenida=notas[i];
                suma=suma  + nota_obtenida;     
            }

            //calculamos el promedio
            promedio=suma/3;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}