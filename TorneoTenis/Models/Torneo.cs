using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


public class Torneo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Tipo { get; set; }
    public int CantidadJugadores { get; set; }
    public string Ganador { get; set; }

    public Torneo(DateTime fecha, string tipo, int cantidadJugadores, string ganador)
    {
        Fecha = fecha;
        Tipo = tipo;
        CantidadJugadores = cantidadJugadores;
        Ganador = ganador;
    }



}