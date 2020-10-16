using System;

namespace convertitoreNumeroDecimale
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto;
            string numeroconvertito = "";

            Console.WriteLine("inserisci la base in cui vuoi convertire:");
            int BaseConvert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci un numero decimale:");
            int dec = Convert.ToInt32(Console.ReadLine());
            while (dec > 0)
            {

                resto = dec % BaseConvert;
                if (resto == 15)
                {
                    numeroconvertito += "F";
                }
                else if (resto == 14)
                {
                    numeroconvertito += "E";
                }
                else if (resto == 13)
                {
                    numeroconvertito += "D";
                }
                else if (resto == 12)
                {
                    numeroconvertito += "C";
                }
                else if (resto == 11)
                {
                    numeroconvertito += "B";
                }
                else if (resto == 10)
                {
                    numeroconvertito += "A";
                }
                else
                {
                    numeroconvertito = Convert.ToString(resto) + numeroconvertito;
                }
                dec = dec / BaseConvert;
            }
            Console.WriteLine($"il numero binario è {numeroconvertito}");

        }
    }
}
     
