using Microsoft.EntityFrameworkCore;
using TorneoTenis.Context;
using TorneoTenis.Services;


public class TorneoServiceTests
{
    [Fact]
    public async Task GuardarTorneoAsync_GuardaTorneoEnDB()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDB")
            .Options;
        /* se utiliza un bloque using para crear y administrar un contexto de base de datos. 
        La palabra clave using asegura que el contexto se limpie correctamente una vez que el bloque termine*/
        using (var context = new ApplicationDbContext(options))
        {
            var service = new TorneoService(context);


            await service.GuardarTorneoAsync(2, "Ganador", "Masculino");
        }


        using (var context = new ApplicationDbContext(options))
        {
            //ejecutar una consulta asincrónica que devuelve el primer torneo encontrado en la tabla Torneos.
            var torneo = await context.Torneos.FirstOrDefaultAsync();

            Assert.NotNull(torneo);
            Assert.Equal(2, torneo.CantidadJugadores);
            Assert.Equal("Ganador", torneo.Ganador);
            Assert.Equal("Masculino", torneo.Tipo);
            Assert.Equal(DateTime.Today, torneo.Fecha);
        }
    }


}