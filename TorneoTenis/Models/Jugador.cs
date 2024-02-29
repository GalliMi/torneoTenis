public  class Jugador
{

    public string Nombre { get; set; }
    public int Habilidad { get; set; }



    public Jugador()
    {
    }
    public virtual  int calcularPuntajeTotal(
    ){Console.WriteLine("calculando puntaje jugador solo");
return 0;
    }

}
public class JugadorMasculino : Jugador
{
    public int Fuerza { get; set; }
    public int Velocidad { get; set; }

    public JugadorMasculino()
    {
    }
    
    public JugadorMasculino(string nombre, int habilidad, int fuerza, int velocidad)
    {
        Nombre = nombre;
        Habilidad = habilidad;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }

    public override  int calcularPuntajeTotal()
    {
        Console.WriteLine("calculando puntaje jugador masculino");

        return Habilidad + Velocidad + Fuerza;
    }
}

public class JugadorFemenino : Jugador
{

    public int TiempoReaccion { get; set; }

    public JugadorFemenino()
    {
    }

    public JugadorFemenino(string nombre, int habilidad, int tiempoReaccion)
    {
        Nombre = nombre;
        Habilidad = habilidad;
        TiempoReaccion = tiempoReaccion;
    }

    public override int calcularPuntajeTotal()
    {
        Console.WriteLine("calculando puntaje jugador femenino");

        return Habilidad - TiempoReaccion;
    }
}