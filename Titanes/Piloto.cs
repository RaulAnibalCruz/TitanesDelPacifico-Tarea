namespace Titanes;
public class Piloto
{
    public string Nombre { get; set; }
    public bool EsVeterano { get; set; }

    public Piloto(string nombre, bool esVeterano = false)
    {
        Nombre = nombre;
        EsVeterano = esVeterano;
    }

    public override string ToString() => Nombre + (EsVeterano ? " (Veterano)" : "");
}
