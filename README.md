# Prueba Técnica Banco Atlántida

Este proyecto es una aplicación construida en .NET 6 para resolver prueba técnica de Banco Atlántida. La solución se implementará siguiendo los principios de Clean Architecture y utilizando una serie de patrones de diseño para asegurar un código limpio, mantenible y escalable. La estructura del proyecto estará dividida en varias capas, cada una con una responsabilidad específica. Se utilizan patrones de diseño como UnitOfWork, Repository Pattern y Command Query Responsibility Segregation (CQRS), así como herramientas como Entity Framework (EF) para la gestión de datos.

## Estructura del Proyecto

La solución está organizada en los siguientes proyectos:

1. **EstadoCuenta.Api**
   - **Responsabilidad:** Exponer servicios RESTful para interactuar con la aplicación.
   - **Tecnologías:** ASP.NET Core, controladores MVC.
   - **Funcionalidades:** Gestionar solicitudes HTTP, rutas, controladores y middleware.


2. **EstadoCuenta.Application**
   - **Responsabilidad:** Contener la lógica de aplicación y las implementaciones de CQRS (comandos y consultas).
   - **Tecnologías:** MediatR para CQRS, FluentValidation para validaciones, Automapper.
   - **Funcionalidades:** Definir casos de uso, servicios de aplicación y validaciones.

3. **EstadoCuenta.Domain**
   - **Responsabilidad:** Definir las entidades del dominio, las interfaces de los repositorios, las excepciones y los DTOs.
   - **Tecnologías:** Clases C#, interfaces.
   - **Funcionalidades:** Contener la lógica de negocio central, reglas de negocio, agregados, excepciones específicas del dominio y DTOs compartidos.

4. **EstadoCuenta.Frontend**
   - **Responsabilidad:** Proveer la interfaz de usuario utilizando Razor MVC.
   - **Tecnologías:** ASP.NET Core MVC, Razor.
   - **Funcionalidades:** Gestionar vistas, controladores y modelos para la capa de presentación.

5. **EstadoCuenta.Infrastructure**
   - **Responsabilidad:** Implementar los repositorios definidos en la capa de dominio y configurar el acceso a la base de datos.
   - **Tecnologías:** Entity Framework Core, SQL Server.
   - **Funcionalidades:** Implementar el patrón UnitOfWork y manejar el acceso a la base de datos.

## Cómo ejecutar el proyecto

### Prerrequisitos

Asegúrate de tener instalados los siguientes componentes:

- .NET 6 SDK
- SQL Server

### Pasos para ejecutar la API y el Frontend

1. **Clona o Descarga el repositorio:**

    ```bash
    git clone https://github.com/Aviscad/PruebaTecnicaBA.git
    ```
    Abrir el archivo `EstadoCuenta.sln`

2. **Configura la base de datos:**

   Asegúrate de tener configurada la cadena de conexión en `appsettings.json` dentro de `EstadoCuenta.Api` y `EstadoCuenta.Frontend` en caso de cambiar el Servidor.
  
    ```json
     "ConnectionStrings":
      {
        "EstadoCuentaConnection": "Server=YOUR_SERVER;Initial Catalog=EstadoCuentaTC;TrustServerCertificate=True;Integrated Security=True;"
      },
    ```

3. **Ejecuta las migraciones de la base de datos:**

   -  Abrir el proyecto o la solución en Visual Studio.
   -  Click derecho sobre el nombre del proyecto `EstadoCuenta.Api`
   -  Click en `Set as Startup Project`
   -  Seleccionar Herramientas > Administrador de paquetes NuGet > Consola del administrador de paquetes.
   -  En la consola seleccionar el proyecto `EstadoCuenta.Infrastructure`.
   -  Ejecutar el comando `Update-Database`

5. **Compila y ejecuta la API y el Frontend:**
   - Click derecho sobre el nombre del proyecto `EstadoCuenta.Api` o `EstadoCuenta.Frontend`
   - Click en `Set as Startup Project`
   - Ejecutar Proyecto

### Documentacion API

Se puede consultar por medio de Swagger al ejecutar la API.


