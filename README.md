(
echo # My Vaccine Web API - ITM
echo.
echo API REST para gestión de vacunación (personas, vacunas, registros).  
echo Desarrollada con .NET 9, EF Core y SQL Server. Contenerizada con Docker.
echo.
echo ## 🚀 Inicio rápido
echo.
echo ### Local (con .NET SDK^)
echo ```bash
echo dotnet restore
echo dotnet ef database update
echo dotnet run
echo # API en http://localhost:5294
echo ```
echo.
echo ### Docker (requiere SQL Server contenedor^)
echo ```bash
echo docker-compose up -d --build
echo # API en http://localhost:8081
echo ```
echo.
echo ## 📦 Endpoints principales
echo.
echo ^| Método ^| Endpoint ^| Descripción ^|
echo ^|--------^|----------^|-------------^|
echo ^| GET/POST/PUT/DELETE ^| `/api/personas` ^| CRUD personas ^|
echo ^| GET/POST/PUT/DELETE ^| `/api/vacunas` ^| CRUD vacunas ^|
echo ^| GET/POST/DELETE ^| `/api/registrosvacunas` ^| Registros (incluye persona y vacuna) ^|
echo.
echo Ejemplo POST `/api/personas`:
echo ```json
echo {
echo   "nombre": "Juan Pérez",
echo   "documento": "12345678",
echo   "telefono": "555-1234"
echo }
echo ```
echo.
echo ## 🛠️ Tecnologías
echo.
echo - .NET 9
echo - ASP.NET Core Web API
echo - Entity Framework Core 9
echo - SQL Server
echo - Docker / docker-compose
echo.
echo ## 📄 Licencia
echo.
echo Proyecto académico – ITM
) > README.md
