using System;

public class Calculador
{


  public Jugador calcularTorneo(List<Jugador> jugadores)
  {

    while (jugadores.Count > 1)
    {
      List<Jugador> jugadoresEnTorneo = new List<Jugador>();

      for (int i = 0; i < jugadores.Count - 1; i = i + 2)
      {

        Console.WriteLine("ronda " + i + jugadores[i].Nombre + " vs " + jugadores[i + 1].Nombre);


        int puntajeJ1 = jugadores[i].calcularPuntajeTotal() + calcularSuerte();
        int puntajeJ2 = jugadores[i + 1].calcularPuntajeTotal() + calcularSuerte();

        if (puntajeJ1 > puntajeJ2)
        {
          Console.WriteLine("gano 1 ");
          jugadoresEnTorneo.Add(jugadores[i]);
        }
        else if (puntajeJ1 < puntajeJ2)
        {
          Console.WriteLine("gano 2 ");
          jugadoresEnTorneo.Add(jugadores[i + 1]);
        }
        else
        {
          Console.WriteLine("desempate");
          if (desempate() == 1)
          {
            jugadoresEnTorneo.Add(jugadores[i]);
          }
          else
          {
            jugadoresEnTorneo.Add(jugadores[i + 1]);
          }
        }

      }
      jugadores = jugadoresEnTorneo;
      for (int j = 0; j < jugadoresEnTorneo.Count; j++)
      {
        Console.WriteLine("en torneo : " + jugadoresEnTorneo[j].Nombre);
      }


    }

    return jugadores.First();

  }




  public int calcularSuerte()
  {
    Random rand = new Random();
    return rand.Next(0, 100);
  }

  public int desempate()
  {
    Random random = new Random();
    if (random.Next(2) == 0)
      return 1;
    else
      return 2;
  }

}
