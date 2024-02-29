using System;
using Xunit;
using System.Collections.Generic;

public class CalculadorTests
{
    [Fact]
    public void CalcularTorneo_DevuelveJugadorMasculino()
    {
        // Arrange
        var jugadores = new List<Jugador>
        {
            new JugadorMasculino("Jugador1",40,50,20),
            new JugadorMasculino("Jugador2",80,10,30),
            new JugadorMasculino("Jugador3",55,63,20),
            new JugadorMasculino("Jugador4",90,10,10)
        };

        var calculador = new Calculador();

        // Act
        var ganador = calculador.calcularTorneo(jugadores);

        // Assert
        Assert.NotNull(ganador);
        Assert.IsType<JugadorMasculino>(ganador);
    }

      [Fact]
    public void CalcularTorneo_DevuelveJugadorFemenino()
    {
        // Arrange
        var jugadores = new List<Jugador>
        {
            new JugadorFemenino("Jugadora1",40,50),
            new JugadorFemenino("Jugadora2",80,10),
            new JugadorFemenino("Jugadora3",55,63),
            new JugadorFemenino("Jugadora4",90,10)
        };

        var calculador = new Calculador();

        // Act
        var ganador = calculador.calcularTorneo(jugadores);

        // Assert
        Assert.NotNull(ganador);
        Assert.IsType<JugadorFemenino>(ganador);
    }
}