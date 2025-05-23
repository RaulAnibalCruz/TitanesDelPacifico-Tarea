using System.Collections.Generic;
using System.Linq;
﻿namespace Titanes;
public class Mision
{
    public string Nombre { get; set; }
    public List<Jaeger> Participantes { get; set; } = new List<Jaeger>();
    public List<Kaiju> Enemigos { get; set; } = new List<Kaiju>();

    public Mision(string nombre)
    {
        Nombre = nombre;
    }

    public void Ejecutar()
    {
        float poderAliado = Participantes.Sum(j => j.CalcularPoderPelea());
        float poderEnemigo = Enemigos.Sum(k => k.CalcularPoderPelea());

        System.Console.WriteLine($"Misión: {Nombre}");
        System.Console.WriteLine($"Poder aliado: {poderAliado}");
        System.Console.WriteLine($"Poder enemigo: {poderEnemigo}");
        System.Console.WriteLine(MisionExitosa() ? "¡Misión exitosa!" : "La misión ha fallado...");
    }

    public bool MisionExitosa()
    {
        return Participantes.Sum(j => j.CalcularPoderPelea()) >= Enemigos.Sum(k => k.CalcularPoderPelea());
    }
}
