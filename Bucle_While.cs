using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando las variables
            int contador =0;
            while (contador<10)
            {
                 Console.WriteLine($"¡Hola mundo!, el contador es {contador}");
                 contador++;
            }

            //La instrucción while comprueba una condición y ejecuta la instrucción o el bloque de instrucciones que aparece después 
            //de while. 
            //Comprueba repetidamente la condición y ejecuta esas instrucciones hasta que la condición sea false.

            //En este ejemplo aparece otro operador nuevo. El código ++ que aparece después de la variable contador
            // este es el operador de incremento. 
            //Suma un valor de uno al valor de contador y almacena dicho valor en la variable de contador.
        }
    }
}