using System;


namespace DayOne
{
    internal class Atleta
    {
        public string Nome { get; set; }
        public string Sport { get; set; }
        public int Età { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}, Età: {Età}");
        }

    }
}
