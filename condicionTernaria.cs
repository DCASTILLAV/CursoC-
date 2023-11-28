using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");          
            //declarando las variables
            
            int num;
            num=7;      
            string mensaje;
            mensaje= num==6?"El número es: " + num: "El número no es " + num;
            Console.WriteLine(mensaje);   
            
        }
    }
}