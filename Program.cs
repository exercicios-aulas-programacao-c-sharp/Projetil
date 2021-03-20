using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;

            double anguloEmGraus;
            double anguloEmRadianos;
            double velocidade;
            double alcance;
            double altura;
           
            Console.WriteLine("----------------------------");
            Console.WriteLine("-- Lançamento do Projétil --");
            Console.WriteLine("----------------------------");

            Console.Write("Entre com a velocidade, em m/s..: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre com o ângulo, em graus....: ");
            anguloEmGraus = Convert.ToDouble(Console.ReadLine());

            anguloEmRadianos = anguloEmGraus * (Math.PI / 180);

            alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloEmRadianos)) / g;
            Console.WriteLine($"Alcance........: {alcance:N2} m");

            altura = Math.Pow((velocidade * Math.Sin(anguloEmRadianos)), 2) / (2 * g);
            Console.WriteLine($"Altura máxima..: {altura:N2} m");
        }
    }
}
