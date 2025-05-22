namespace Titanes;
public class Habilidad
{
    public string Nombre { get; set; }
    public float Danio { get; set; }

    public Habilidad(string nombre, float danio)
    {
        Nombre = nombre;
        Danio = danio;
    }

    public override string ToString() => $"{Nombre} (Daño: {Danio})";
}
