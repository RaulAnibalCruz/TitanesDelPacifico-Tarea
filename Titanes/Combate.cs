namespace Titanes;
public static class Combate
{
    public static string DeterminarGanador(Kaiju kaiju, Jaeger jaeger)
    {
        float poderKaiju = kaiju.CalcularPoderPelea();
        float poderJaeger = jaeger.CalcularPoderPelea();

        if (poderKaiju > poderJaeger)
            return $"Gana el Kaiju {kaiju.Nombre}";
        else if (poderJaeger > poderKaiju)
            return $"Gana el Jaeger {jaeger.Nombre}";
        else
            return "Empate";
    }
}
