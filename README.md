# Proyecto SISVEN - Sistema de Ventas

## Descripción

Este repositorio contiene el sistema de ventas (SISVEN) desarrollado con una arquitectura que incluye una aplicación WPF y una librería de acceso a datos (SISVEN_DAO) para interactuar con una base de datos MySQL. A continuación, se detallan los pasos necesarios para ejecutar la solución.

## Requisitos previos

- Tener instalado **XAMPP** para ejecutar MySQL.
- Tener configurada la base de datos en MySQL.
- Si se utiliza una base de datos diferente, modificar la cadena de conexión (connectionString) en el archivo `_Implementation/BaseImplementation.cs` dentro del proyecto **SISVEN_DAO**.

## Pasos para ejecutar la solución

1. Cambiar el inicio del proyecto a **WpfApp8**.
2. Compilar (Build) la librería de clase **SISVEN_DAO**.
3. Asegurarse de que **MySQL** (XAMPP) esté habilitado y la base de datos esté en funcionamiento.
4. Si utiliza una base de datos distinta, modificar la cadena de conexión en el archivo `_Implementation/BaseImplementation.cs` dentro del proyecto **SISVEN_DAO**.

## Nota

Es importante verificar la configuración de la base de datos en el archivo de implementación para asegurar una correcta conexión con MySQL u otro sistema gestor de bases de datos que se desee utilizar.
"""
