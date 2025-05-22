using System.Collections.Generic;
using System.Linq;
﻿namespace Titanes;
public class Jaeger
{
    public string Nombre { get; set; }
    public bool EsAnalogico { get; set; }
    public bool UsaReactorNuclear { get; set; }
    public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();
    public List<Piloto> Pilotos { get; set; } = new List<Piloto>();

    public Jaeger(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarPiloto(Piloto piloto)
    {
        if (Pilotos.Count < 2)
            Pilotos.Add(piloto);
    }

    public void AgregarHabilidad(Habilidad habilidad)
    {
        Habilidades.Add(habilidad);
    }

    public List<string> ObtenerNombresPilotos()
    {
        return Pilotos.Select(p => p.Nombre).ToList();
    }

    public float CalcularPoderPelea()
    {
        return Habilidades.Sum(h => h.Danio) * (Pilotos.Count == 1 ? 0.8f : 1f);
    }
}
