using System;

namespace DayOne
{
    internal class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Età { get; set; }

        public void EmittiSuono()
        {
            Console.WriteLine($"{Nome} fa un suono caratteristico della sua specie ({Specie}).");
        }

    }
}
