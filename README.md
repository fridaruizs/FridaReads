# FridaReads
FridaReads es una aplicación web inspirada en Goodreads, donde los usuarios pueden registrar sus lecturas, dejar reseñas y calificaciones de diferentes tipos de textos, como libros, ensayos, poemas y artículos.

## Requisitos
.NET 6 SDK (o superior)
Node.js (versión 14 o superior)
SQL Server Express (o una instancia de SQL Server)

## Configuración
### 1. Clonar el repositorio
git clone https://github.com/fridaruizs/FridaReads.git

### 2. Configurar la base de datos
Instala SQL Server Express si aún no lo tienes instalado.
Crea una nueva base de datos vacía para FridaReads.
Abrí el archivo `appsettings.json` en la carpeta raíz del proyecto de back-end (/fridareads.server).
Actualiza la cadena de conexión DefaultConnection con los detalles de tu instancia de SQL Server y la base de datos creada.
```javascript
"DefaultConnection":"Server=TU_SERVIDOR;Database=FridaReads;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
```

### 3. Iniciar el back-end
Abrí la solución de FridaReads en Visual Studio.
Ejecuta las migraciones de Entity Framework Core para crear las tablas de la base de datos:
`Herramientas > Administrador de paquetes NuGet > Package Manager Console`
Selecciona el proyecto de back-end como proyecto predeterminado
Ejecuta el comando: `Update-Database` o estas dos líneas en la terminal de Visual Studio
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
Presiona F5 o selecciona "Iniciar" para ejecutar el back-end.

### 4. Iniciar el front-end
Abrí una terminal y navega hasta la carpeta del proyecto de front-end (/fridareads.client).
Ejecuta el siguiente comando para instalar las dependencias de Node.js:
```
npm install
```

Una vez finalizada la instalación, ejecuta el siguiente comando para iniciar el servidor de desarrollo de Angular:
```
ng serve
```

Abrí un navegador web y visita http://localhost:4200 para ver la aplicación FridaReads en ejecución.

Eso es todo! Ahora deberías tener la aplicación FridaReads en funcionamiento. 🙂
