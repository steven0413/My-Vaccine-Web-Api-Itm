# My Vaccine Web API - ITM

API REST para gestión de vacunación (personas, vacunas, registros).  
Desarrollada con .NET 9, EF Core y SQL Server. Contenerizada con Docker.

## 🚀 Inicio rápido

### Local (con .NET SDK)
```bash
dotnet restore
dotnet ef database update
dotnet run
# API en http://localhost:5294

Docker (requiere SQL Server contenedor)
docker-compose up -d --build
# API en http://localhost:8081

📦 Endpoints principales
Método	Endpoint	Descripción
GET/POST/PUT/DELETE	/api/personas	CRUD personas
GET/POST/PUT/DELETE	/api/vacunas	CRUD vacunas
GET/POST/DELETE	/api/registrosvacunas	Registros (incluye persona y vacuna)

🛠️ Tecnologías
.NET 9

ASP.NET Core Web API

Entity Framework Core 9

SQL Server

Docker / docker-compose

📄 Licencia
Proyecto académico – ITM

Este README es directo, funcional y fácil de leer. Puedes copiarlo y reemplazar el contenido actual.
