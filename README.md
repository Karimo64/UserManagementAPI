UserManagementAPI — Proyecto Final (Coursera)

Descripción del Proyecto
TechHive Solutions necesita una API interna para gestionar usuarios desde los departamentos de HR e IT. Esta API permite:
- Crear usuarios
- Obtener usuarios
- Actualizar usuarios
- Eliminar usuarios
- Validar datos
- Registrar logs
- Manejar errores de forma consistente
- Autenticar solicitudes mediante token (middleware incluido)

El proyecto fue desarrollado con ASP.NET Core Web API y Microsoft Copilot como asistente principal para generación, mejora y depuración del código.

Tecnologías Utilizadas
- .NET 8
- ASP.NET Core Web API
- Swagger / OpenAPI
- Middleware personalizado
- DataAnnotations para validación
- C# 12

Estructura del Proyecto
UserManagementAPI/
├── Controllers/
│   └── UsersController.cs
├── Middleware/
│   ├── LoggingMiddleware.cs
│   ├── ErrorHandlingMiddleware.cs
│   └── AuthenticationMiddleware.cs
├── Models/
│   └── User.cs
├── Services/
│   └── UserService.cs
├── Program.cs
└── UserManagementAPI.csproj

Actividad 1 — Writing & Enhancing API Code (COMPLETADA)

Lo realizado:
- Creación del proyecto UserManagementAPI.
- Scaffold inicial con Copilot (Program.cs, estructura base).
- Implementación de CRUD completo:
  GET /api/users
  GET /api/users/{id}
  POST /api/users
  PUT /api/users/{id}
  DELETE /api/users/{id}
- Pruebas con Swagger (POST devolviendo 201 Created).
- Ajustes sugeridos por Copilot para mejorar claridad y estructura.

Cómo ayudó Copilot:
- Generó el controlador base con los métodos CRUD.
- Sugirió la estructura del servicio UserService.
- Propuso mejoras en Program.cs para registrar servicios y configurar Swagger.
- Ayudó a corregir rutas, tipos de retorno y estructura del JSON.

Actividad 2 — Debugging API Code (COMPLETADA)

Problemas encontrados y corregidos:
- Falta de validación en el modelo User.
- GetById devolvía null sin manejar → ahora devuelve 404.
- Advertencias de nullables → corregidas con = string.Empty.
- Problemas con Swagger/OpenAPI → resueltos ajustando paquetes y framework.
- Excepciones no manejadas → corregidas con middleware de errores.
- POST devolvía 401 → corregido al ajustar el pipeline.

Cómo ayudó Copilot:
- Identificó propiedades que necesitaban inicialización.
- Sugirió convertir User → User? en el servicio.
- Propuso agregar DataAnnotations.
- Ayudó a detectar el orden incorrecto del middleware.
- Sugirió manejo centralizado de errores.

Actividad 3 — Middleware (COMPLETADA)

Middleware implementado:
1. LoggingMiddleware
   - Registra método HTTP, ruta y código de respuesta.

2. ErrorHandlingMiddleware
   - Captura excepciones no manejadas.
   - Devuelve JSON consistente: { "error": "Internal server error." }

3. AuthenticationMiddleware
   - Valida token en el header Authorization.
   - Devuelve 401 si el token es inválido.
   - Puede activarse o dejarse comentado.

Orden correcto del pipeline:
1. ErrorHandlingMiddleware
2. AuthenticationMiddleware
3. LoggingMiddleware
4. MapControllers

Cómo ayudó Copilot:
- Generó la estructura base de cada middleware.
- Sugirió cómo leer el cuerpo de la respuesta para logging.
- Indicó el orden correcto del pipeline.
- Ayudó a implementar validación del token.

Cómo ejecutar el proyecto:
1. Clonar el repositorio:
   git clone https://github.com/Karimo64/UserManagementAPI.git

2. Entrar al proyecto:
   cd UserManagementAPI

3. Ejecutar:
   dotnet run

4. Abrir Swagger:
   http://localhost:xxxx/swagger

Cómo probar los endpoints:

POST /api/users
Body:
{
  "name": "Karim",
  "email": "karim@example.com",
  "role": "Admin"
}

GET /api/users
GET /api/users/{id}
PUT /api/users/{id}
DELETE /api/users/{id}

Criterios de evaluación (25/25)
- GitHub repo creado: ✔
- CRUD completo: ✔
- Debugging con Copilot: ✔
- Validaciones: ✔
- Middleware (logging, auth, error handling): ✔

Proyecto completado.
Este repositorio contiene el resultado final de las tres actividades del curso, con todas las funcionalidades requeridas y documentación clara del proceso.
