using System;

namespace DayOne
{
    internal class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}");

        }
    }
}