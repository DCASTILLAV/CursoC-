using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");
            //declarando las variables numericas
            int num1;
            int num2;
            int suma;
            num1=5; num2=7; suma=num1+num2;
            Console.WriteLine("Se declararon dos variables la variable num1 contiene:" + num1);
            Console.WriteLine(" y la variable num2 contiene: " + num2);
            Console.WriteLine("Ademas la suma es: " +  suma);

            //declaramos nuevas variables
            string nombre;
            nombre="Juan Perez";
            Console.WriteLine("Su nombre es: "+ nombre);
        }
    }
}