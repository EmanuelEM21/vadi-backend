# VadiFrontEnd

API REST construida en .NET para gestionar solicitudes de crédito como parte de una prueba técnica.

## Tecnologías utilizadas

- .NET 8
- C#
- Dapper
- Swagger

## Instalación

1. Clonar el repositorio
2. Ejecutar con cualquier método (http, https, IISExpress).

## Endpoints

La API cuenta con documentación Swagger. Para verla, ejecutar la app y acceder a: http://localhost:5044/swagger

## Observaciones

- El launchSettings se configuró para que indenpendientemente del método de ejecución, el puerto sea siempre el mismo.
- En caso de que el puerto sea diferente al http://localhost:5044, es necesario cambiar el API URL del environment en FrontEnd.
- El API está configurada para que permita acceso desde cualquier origen (CORS).
- Se mantuvo el connectionString en el appsettings para facilitar la ejecución.