# VeterinariaApp - Sistema de Gestión de Veterinarias

Este proyecto es un sistema de gestión académica desarrollado en PHP. Permite gestionar carreras, comisiones,  profesores y usuarios. El sistema incluye funcionalidades de autenticación, ABMs (Altas, Bajas, Modificaciones) y vistas diferenciadas para administración y usuarios.

# Indice 
- [Funcionalidades]
- [Requisitos]
- [Instalación]
- [Credenciales]
- [Desarrolladores]

---

# Funcionalidades

Empleado:
- **Gestión de especies**: Alta, baja, modificación y visualización de especies.
- **Gestión de Clientes**: Alta, baja, modificación y visualización de clientes registrados.
- **Gestión de Mascotas**: Alta, baja, modificación y visualización de las mascotas asociadas a los clientes y su respectiva especie.
- **Gestión de Usuarios**: Alta, baja, modificación y visualización de usuarios (empleados).
- **Generacion de Informes**:
  - **Cantidad de Mascotas por Cliente**: Informe detallado sobre cuántas mascotas tiene cada cliente.
  - **Cálculo de Peso de Mascotas Filtrado por Edad**: Informe sobre el peso de las mascotas, filtrado por su edad.
  - **Análisis de Peso según Especie**: Análisis que compara el peso de las mascotas con el promedio esperado para su especie, indicando si están dentro de un rango saludable.
---

# Requisitos
Para ejecutar este proyecto, necesitarás:
- **Sistema Operativo**: Windows
- **Visual Studio**: Versión 2019 o superior.
- **.NET Framework**: 4.72 o superior.
- **BBDD**: SQL Server Management Studio 20 o superior.

---

# Instalación

1. **Clonar el Repositorio**:
   1. **Clonar el Repositorio**:
Clonar el repositorio en la ubicación deseada. git clone https://github.com/alanfrancoa/VeterinariaRepo.git
  

2. Configurar la Base de Datos:

Crea una base de datos en SQL Server llamada VeterinariaDB.
Puedes crear las tablas con la siguiente query: 
CREATE TABLE ESPECIES (
    ID INT IDENTITY PRIMARY KEY,
    NOMBRE VARCHAR(50) NOT NULL UNIQUE,
    EDAD_MADUREZ INT,
    PESO_PROMEDIO DECIMAL(18,2)
);

CREATE TABLE CLIENTES (
    ID INT IDENTITY PRIMARY KEY,
    NOMBRE VARCHAR(50) NOT NULL,
    DNI INT UNIQUE NOT NULL,
    TELEFONO INT NOT NULL,
    E_MAIL VARCHAR(80) NOT NULL
);

CREATE TABLE MASCOTAS (
    ID INT IDENTITY PRIMARY KEY,
    NOMBRE VARCHAR(30) NOT NULL,
    PESO DECIMAL(18,2),
    FECHA_NACIMIENTO DATE,
    ID_CLIENTE INT,
    ID_ESPECIE INT,
    FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTES(ID),
    FOREIGN KEY (ID_ESPECIE) REFERENCES ESPECIES(ID)
);

CREATE TABLE USUARIOS (
    ID INT IDENTITY PRIMARY KEY,
	USERNAME VARCHAR (16) NOT NULL UNIQUE,
    NOMBRE VARCHAR(30) NOT NULL,
	CLAVE VARCHAR(30) NOT NULL
);


SELECT * FROM ESPECIES;
SELECT * FROM MASCOTAS;
SELECT * FROM ESPECIES;
SELECT * FROM USUARIOS;

INSERT INTO USUARIOS VALUES ('Usuario1','John Doe','123456');

3.Configuración de la Cadena de Conexión: 
- Abre el proyecto en Visual Studio.
- En el archivo de configuración (App.config), asegúrate de configurar correctamente la cadena de conexión a tu base de datos SQL Server:

<connectionStrings>
  <add name="VeterinariaDB" connectionString="Server=localhost;Database=VeterinariaDB;Integrated Security=True;"/>
</connectionStrings>

4. Configurar la Aplicación:
-Asegúrate de que las dependencias estén correctamente configuradas en Visual Studio.
-Compila y ejecuta el proyecto.

5. Iniciar el Proyecto:
-Una vez compilado, abre la aplicación desde Visual Studio y navega a la interfaz principal.

---

# Credenciales

Para acceder a las funciones de administración, utiliza las siguientes credenciales:

Usuario: Usuario1
Contraseña: 123456

---

# Desarrolladores

Este proyecto fue desarrollado por:
-Alan Alvarez 
