
using System.Collections.Generic;
using System.Linq;
﻿namespace Titanes;
public class Kaiju
{
    public string Nombre { get; set; }
    public int Categoria { get; set; }
    public float Peso { get; set; }
    public float Dureza { get; set; }
    public float Energia { get; set; }
    public float Vida { get; set; }
    public float Tamaño { get; set; }
    public bool InmuneAlFuego { get; set; }
    public bool PuedeVolar { get; set; }
    public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();

    public Kaiju(string nombre, int categoria)
    {
        Nombre = nombre;
        Categoria = categoria;
    }

    public void AgregarHabilidad(Habilidad habilidad)
    {
        Habilidades.Add(habilidad);
    }

    public List<string> ObtenerNombresHabilidades()
    {
        return Habilidades.Select(h => h.Nombre).ToList();
    }

    public float ObtenerTotalDanioHabilidades()
    {
        return Habilidades.Sum(h => h.Danio);
    }

    public float CalcularPoderPelea()
    {
        return Energia * ObtenerTotalDanioHabilidades() * Categoria;
    }
}
