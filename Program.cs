using System;

namespace TPFinal_Lamas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            a. El mayor de los números pares.
            b. La cantidad de números impares.
            c. El menor de los números primos.
            Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda. */

            int n, conImpares = 0;
            int maxPar = 0, minPrimo = 0;
            bool banderaPar = true, banderaPrimo = true;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    if (banderaPar)
                    {
                        maxPar = n;
                        banderaPar = false;
                    }
                    else         
                        if (n > maxPar)
                            maxPar = n;                                  
                }
                else
                    conImpares++;

                if(primo(n))
                {
                    if (banderaPrimo)
                    {
                        minPrimo = n;
                        banderaPrimo = false;
                    }
                    else                    
                        if (n < minPrimo)
                            minPrimo = n;                  
                }

                Console.WriteLine("Ingrese otro número: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor de los números pares es: " + maxPar);
            Console.WriteLine("La cantidad de números impares es: " + conImpares);
            Console.WriteLine("El menor de los números primos es: " + minPrimo);
        }

        static bool primo(int a)
        {
            int con = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    con++;              
            }

            if (con == 2)
                return true;
            else    
                return false;
        }
    }
}
