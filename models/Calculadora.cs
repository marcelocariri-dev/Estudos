using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FUNDAMENTOS.models
{
    public class Calculadora
    {

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine(pot);
        }
        public void raizquadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz);
        }

        public void areacircunferencia()
        {
    double pi, raio, volume, VOLUME;
    pi = 3.14159;


            raio = double.Parse(Console.ReadLine()!);
    volume = pi * ( 4 / 3.0 ) * Math.Pow( raio , 3 );
    VOLUME = Math.Round(volume, 3); //arredonda para 3 casas decimais 
   Console.WriteLine($"VOLUME = {VOLUME:F3}"); // deixa formatado para exatamente três casas deco,aos
}

    }


}