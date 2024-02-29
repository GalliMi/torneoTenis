using TorneoTenis.Context;

namespace TorneoTenis.Services;
public class TorneoService
{
    private readonly ApplicationDbContext _context;

    public TorneoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<string> IniciarTorneoMasculinoAsync(List<JugadorMasculino> jugadores)
    {
        var calculador = new Calculador();
        var participantes = new List<Jugador>(jugadores);
        var ganador = calculador.calcularTorneo(participantes).Nombre;

        try
        {
            await GuardarTorneoAsync(jugadores.Count, ganador, "masculino");
        }
        catch (Exception e)
        {
            return ganador;

        }

        return ganador;
    }

    public async Task<string> IniciarTorneoFemeninoAsync(List<JugadorFemenino> jugadoras)
    {
        var calculador = new Calculador();
        var participantes = new List<Jugador>(jugadoras);
        var ganador = calculador.calcularTorneo(participantes).Nombre;

        try
        {
            await GuardarTorneoAsync(jugadoras.Count, ganador, "masculino");
        }
        catch (Exception e)
        {
            return ganador;
        }
        return ganador;
    }


    public async Task GuardarTorneoAsync(int cantidadJugadores, string ganador, string tipo)
    {
        var fechaDelDia = DateTime.Today;
        var torneo = new Torneo(fechaDelDia, tipo, cantidadJugadores, ganador);

        _context.Torneos.Add(torneo);
        await _context.SaveChangesAsync();
    }


}
