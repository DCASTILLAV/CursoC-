using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
           // Console.WriteLine("Hello world!");        
           //declarando las variables
            
            int num1,num2,num3,mayor;
            mayor=0;
            num1=5;
            num2=3;
            num3=8;
            
            if (num1>num2 && num1>num3)
            {
                mayor=num1;  
            }
            else if (num2>num1 && num2>num3)
            {
                mayor=num2;      
            }
            else if (num3>num1 && num3 >num2)
            {
                mayor=num3;
            }
            Console.WriteLine("el numero mayor a todos es: " + mayor);
        }
    }
}
