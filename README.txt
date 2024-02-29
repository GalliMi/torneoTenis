La solucion está integrada a una BDD MySQL, la cual contiene una tabla "torneos" con la siguiente estructura:
Id int 
fecha date 
tipo varchar(45) 
cantidadJugadores int 
ganador varchar(45)

Si se necesita ajustar los datos de conexión, modificar el contenido de "MySQLConnection" en appsettings.json.



Una vez ejecutada la aplicación, los controladores pueden ser utilizados a traves de la siguiente ruta: http://localhost:5093/swagger/index.html

Para generar un nuevo torneo y obtener su ganador mediante un POST request, proveer una lista de jugadores masculinos o femeninos según sea el caso en formato JSON.
El siguiente es un ejemplo para el endpoint api/Torneo/TorneoMasculino:

[
  {
    "nombre": "Agustin Gomez",
    "habilidad": 40,
    "fuerza": 77,
    "velocidad": 33
  },
{
    "nombre": "Carlos ",
    "habilidad": 20,
    "fuerza": 80,
    "velocidad": 45
  },
{
    "nombre": "string",
    "habilidad": 60,
    "fuerza": 44,
    "velocidad": 38
  },
{
    "nombre": "string",
    "habilidad": 90,
    "fuerza": 10,
    "velocidad": 70
  }
]

El torneo solo calcula una cantidad de jugadores de multiplo de 2, si se ingresa un numero impar, el ultimo jugador no entrará en la competencia.


Para recibir una lista de todos los torneos registrados realizar una solicitud GET en el endpoint api/Torneo.
Para recibir un torneo según su ID proveerlo como parametro en api/Torneo/{id}.
Si lo que se desea es consultar un torneo según su fecha proveerla como parametro en api/Torneo/{fecha} con el formato YYYY-MM-DD.


Ingresar la ruta en donde se encuentra alojado el proyecto para la correcta integración del proyecto de tests dentro del archivo TorneoTenisTests.csproj
en el apartado <ItemGroup>
    <ProjectReference Include="<ruta al proyecto>" />
  </ItemGroup>



