# Introduccion 
El proyecto "InformacionLogsBots" es una aplicaci�n ASP.NET Core dise�ada para gestionar y registrar logs de transacciones. Utiliza Entity Framework Core para interactuar con una base de datos SQL Server, donde almacena informaci�n detallada sobre cada log, incluyendo datos como la fecha y hora de la transacci�n, duraci�n, ambiente, IP, usuario, tecnolog�a, proceso, nivel de log, y mensajes asociados. 

La aplicaci�n expone una API RESTful que permite registrar nuevos logs. Adem�s, utiliza Swashbuckle para generar documentaci�n de la API y proporciona un middleware personalizado para manejar excepciones globalmente y registrar errores.

# Herramientas y Tecnolog�as Utilizadas
Este proyecto fue hecho en .Net8 entonces es necesario que cuente con el SDK necesario para su ejecuci�n
- ASP.NET Core
- Entity Framework Core
- Swashbuckle (Swagger)
- Newtonsoft.Json
- SQL Server
- Inyecci�n de Dependencias
- Middleware Personalizado
- Configuraci�n de Entorno

