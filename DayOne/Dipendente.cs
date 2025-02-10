using System;


namespace DayOne
{
    internal class Dipendente
    {
        public string Nome { get; set; }
        public string Ruolo { get; set; }
        public double Stipendio { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Dipendente: {Nome}, Ruolo: {Ruolo}, Stipendio: {Stipendio}€");
        }

    }
}
