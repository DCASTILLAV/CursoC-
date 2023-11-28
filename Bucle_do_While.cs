using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando las variables
            int contador = 0;
            do
            {
                Console.WriteLine($"Hello World! El contador is {contador}");
                contador++;
            } while (contador < 10);

            //El bucle while prueba la condición antes de ejecutar el código que sigue a while. El bucle do ... while
            //primero ejecuta el código y después comprueba la condición. El bucle do while se muestra en el código siguiente:
            //hay que tener en cuenta que: el bucle do y el bucle while anterior generan el mismo resultado.
        }
    }
}