using System;
using Titanes;
namespace Main;

class Program
{
    static void Main()
    {
        // --- Pilotos ---
        Piloto raleigh = new Piloto("Raleigh Becket", esVeterano: true);
        Piloto mako = new Piloto("Mako Mori");
        Comandante stacker = new Comandante("Stacker Pentecost");

        // --- Habilidades Kaiju (Knifehead) ---
        Habilidad rayoPlasma = new Habilidad("Rayo de Plasma", 150);
        Habilidad pulsoElectromagnetico = new Habilidad("Pulso Electromagnético", 100);

        // --- Kaiju ---
        Kaiju knifehead = new Kaiju("Knifehead", categoria: 4)
        {
            Peso = 12000,
            Dureza = 8,
            Energia = 500,
            Vida = 1000,
            Tamaño = 50,
            InmuneAlFuego = false,
            PuedeVolar = false
        };
        knifehead.AgregarHabilidad(rayoPlasma);
        knifehead.AgregarHabilidad(pulsoElectromagnetico);

        // --- Habilidades Jaeger (Gipsy Danger) ---
        Habilidad codoCohete = new Habilidad("Codo de Cohete", 120);
        Habilidad canonPlasma = new Habilidad("Cañón de Plasma", 200);
        Habilidad espada = new Habilidad("Espada", 180);

        // --- Jaeger ---
        Jaeger gipsyDanger = new Jaeger("Gipsy Danger")
        {
            EsAnalogico = true,
            UsaReactorNuclear = true
        };
        gipsyDanger.AgregarPiloto(raleigh);
        gipsyDanger.AgregarPiloto(mako);

        gipsyDanger.AgregarHabilidad(codoCohete);
        gipsyDanger.AgregarHabilidad(canonPlasma);
        gipsyDanger.AgregarHabilidad(espada);

        // --- Mostrar datos ---
        Console.WriteLine("Pilotos de Gipsy Danger:");
        foreach (var piloto in gipsyDanger.Pilotos)
        {
            Console.WriteLine($" - {piloto}");
        }

        Console.WriteLine("\nHabilidades de Knifehead:");
        foreach (var hab in knifehead.Habilidades)
        {
            Console.WriteLine($" - {hab}");
        }

        Console.WriteLine($"\nDaño total de habilidades de Knifehead: {knifehead.ObtenerTotalDanioHabilidades()}");
        Console.WriteLine($"Poder de pelea de Knifehead: {knifehead.CalcularPoderPelea()}");

        Console.WriteLine($"\nPoder de pelea de Gipsy Danger: {gipsyDanger.CalcularPoderPelea()}");

        // --- Combate ---
        string resultado = Combate.DeterminarGanador(knifehead, gipsyDanger);
        Console.WriteLine($"\nResultado del combate: {resultado}");
    }
}