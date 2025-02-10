

using DayOne;

class Program
{
    static void Main()
    {
       
        Atleta atleta = new Atleta { Nome = "Usain Bolt", Sport = "Atletica", Età = 37 };
        Dipendente dipendente = new Dipendente { Nome = "Mario Rossi", Ruolo = "Sviluppatore", Stipendio = 3500 };
        Animale animale = new Animale { Nome = "Fido", Specie = "Cane", Età = 5 };
        Veicolo veicolo = new Veicolo { Marca = "Tesla", Modello = "Model S", Anno = 2022 };

        atleta.MostraDettagli();
        dipendente.MostraDettagli();
        animale.EmittiSuono();
        veicolo.MostraDettagli();
    }
}
