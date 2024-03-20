using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara e instancia os 2 Cronómetros
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Inicia a contagem do tempo em crono1
            crono1.Start();

            //Pausa o programa durante 0.6 segundos (600 milissegundos):
            Thread.Sleep(600);

            //Inicia a contagem do tempo em crono2
            crono2.Start();

            //Pausa o programa durante mais 0.2 segundos
            Thread.Sleep(200);

            //Para a contagem do tempo nos 2 cronómetros
            crono1.Stop();
            crono2.Stop();

            //Mostra no ecrã o tempo decorrido em cada cronómetro, em segundos com 3 casas decimais
            Console.WriteLine("Tempo decorrido em crono1: " + (crono1.ElapsedMilliseconds / 1000.0).ToString("0.000") + " segundos");
            Console.WriteLine("Tempo decorrido em crono2: " + (crono2.ElapsedMilliseconds / 1000.0).ToString("0.000") + " segundos");
        }
    }
}
