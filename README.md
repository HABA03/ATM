Pasos para poder usar el proyecto:

  1-Colocar la cadena de conexion correspontiente en los archivos ATM.MVC/appsettings.json y ATM.DAL/Context/ATMDbContext.cs.
    Ejemplo de la cadena de conexion: Data Source=-MiDataSource-;Initial Catalog=AUTOPRIMEMOTORS;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true

  2-Una vez colocada la cadena de navegacion copiar la ruta de ATM.DAL

  3-Abrir el cmd y colocarse a la altura de la ruta de ATM.DAL

  4.Ejecutar el comando 'dotnet ef database update' para ejecutar la migracion y crear la base de datos
