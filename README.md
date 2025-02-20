# 📌 API REST - Productos

Esta es una API REST desarrollada en **.NET 8** con **Entity Framework Core** y **Swagger**, que permite gestionar productos mediante operaciones CRUD.

## 📥 Requisitos Previos

Antes de instalar y ejecutar la API, asegúrate de tener lo siguiente:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/)
- [Postman](https://www.postman.com/) o cualquier herramienta para probar APIs

## 📂 Jerarquía de Carpetas
```
Asin_S3
│─📂 Connected Services
│─📂 Dependencias
│   ├── Microsoft.EntityFrameworkCore.SqlServer (9.0.2)
│   ├── Microsoft.EntityFrameworkCore.Tools (9.0.2)
│   ├── Swashbuckle.AspNetCore (7.2.0)
│─📂 Properties
│   ├─🗎 launchSettings.json
│─📂 Context
│   ├─🗎 ProductoContext.cs
│─📂 Controllers
│   ├─🗎 ProductosController.cs
│─📂 Migrations
│   ├─🗎 20250217032630_InitialCreate.cs
│   ├─🗎 ProductoContextModelSnapshot.cs
│─📂 Models
│   ├─🗎 Producto.cs
│─📂 Repositories
│   ├─🗎 IProductoRepository.cs
│   ├─🗎 ProductoRepository.cs
│─🗎 appsettings.json
│─🗎 Asin_S3.http
│─🗎 Program.cs
```

## 🚀 Instalación y Configuración

### 1️⃣ Clonar el repositorio
```sh
git clone https://github.com/tu_usuario/tu_repositorio.git
cd tu_repositorio
```

### 2️⃣ Instalar dependencias
```sh
dotnet restore
```

### 3️⃣ Configurar la cadena de conexión
Edita el archivo **appsettings.json** y reemplaza `YourConnectionStringHere` por la conexión a tu base de datos SQL Server.
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=ServidorSQL;Database=NombreBasedeDatos;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4️⃣ Aplicar Migraciones
Ejecuta los siguientes comandos para crear la base de datos y aplicar las migraciones:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5️⃣ Ejecutar la API
```sh
dotnet run
```
Por defecto, la API correrá en `http://localhost:5000` o `https://localhost:5001`.
En mi maquina fue el `https://localhost:7243/)`

## 📖 Documentación con Swagger
Una vez que la API esté en ejecución, puedes acceder a Swagger para ver y probar los endpoints:

🔗 [Swagger UI](https://localhost:7243/swagger/index.html)  (ajusta el puerto si es necesario)

## 📌 Endpoints Principales

| Método | Endpoint                         | Descripción                 |
|--------|----------------------------------|-----------------------------|
| GET    | api/Productos/ObtenerTodos       | Obtiene todos los productos |
| GET    | /api/productos/ObtenerPorId/{id} | Obtiene un producto por ID  |
| POST   | Productos/InsertarProducto       | Agrega un nuevo producto    |
| PUT    | /api/EditarProducto/{id}         | Actualiza un producto       |
| DELETE | /api/EliminarProducto/{id}       | Elimina un producto         |

### Ejemplo de Body (JSON) para crear un producto
```json
{
  "nombre": "Nombre del Producto",
  "precio": 100.99,
  "stock": 25
}
```

## 📼 Video de Gerarquia de carpetas y codigo utilizado 
https://drive.google.com/file/d/1_JkTiE5aKzZ1H6VuQP0VivVv9M6NZfQC/view?usp=sharing

## 📼 Video de ejecucion de la API
https://drive.google.com/file/d/1NKyKjWHFaN-lp6J_zYmEf4fPs3N2lG8D/view?usp=sharing

