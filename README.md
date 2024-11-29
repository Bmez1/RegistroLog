# Introduccion 
El proyecto "InformacionLogsBots" es una aplicación ASP.NET Core diseñada para gestionar y registrar logs de transacciones. Utiliza Entity Framework Core para interactuar con una base de datos SQL Server, donde almacena información detallada sobre cada log, incluyendo datos como la fecha y hora de la transacción, duración, ambiente, IP, usuario, tecnología, proceso, nivel de log, y mensajes asociados. 

La aplicación expone una API RESTful que permite registrar nuevos logs. Además, utiliza Swashbuckle para generar documentación de la API y proporciona un middleware personalizado para manejar excepciones globalmente y registrar errores.

# Herramientas y Tecnologías Utilizadas
Este proyecto fue hecho en .Net8 entonces es necesario que cuente con el SDK necesario para su ejecución
- ASP.NET Core
- Entity Framework Core
- Swashbuckle (Swagger)
- Newtonsoft.Json
- SQL Server
- Inyección de Dependencias
- Middleware Personalizado
- Configuración de Entorno

