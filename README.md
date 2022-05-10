# Orq-ShoppingCar
Servicio que orquesta las peticiones del front  las otras APIS, proyecto prueba de ingreso 


## Versión
API Backend en .net core version netcoreapp3.1


## Porque?


El API *Orq-ShoppingCar* es un backend para un proyecto de carrito de compras, el cual tiene como finalidad mostrar los conocimientos adquiridos en las tecnologías necesarias para el rol.


Esta API se encarga de recibir todas las peticiones provenientes del frontend [**Front-ShoppingCar**](https://github.com/juliankgp/Front-ShoppingCar), validar que los campos sean correctos y hacer la petición para cada API según corresponda. 


## ¿Cómo funciona?
Lo primero que se debe hacer es descargar el repositorio en una máquina local, al hacer esto se descarga un proyecto de tipo API Web.NetCore para poder ejecutarlo puede usar Visual studio, o si quiere ejecutarlo en algún otro editor de código como VSC puede leer el siguiente artículo [**Visual Studio Code: cómo preparar un entorno de trabajo para .NET**](https://www.campusmvp.es/recursos/post/visual-studio-code-como-preparar-un-entorno-de-trabajo-para-net-core.aspx). Debe tener en cuenta que antes de iniciar Angular se deben iniciar SQL server managment studio y las tres APIS que conforman la prueba (en primer lugar [**Logistica-ShoppingCar**](https://github.com/juliankgp/Logistica-ShoppingCar), es muy importante que sé la primera que se ejecute, ya que esta API creara la base de datos donde se harán todas las consultas, luego de esta podemos continuar con [**Productos-ShoppingCar**](https://github.com/juliankgp/Productos-ShoppingCar)). Una vez completados este paso ya podrá arrancar la API que lo redirige directamente al swagger donde se muestra toda la documentación de esta. 



## Librerías


- *Microsoft.AspNetCore.Cors:* esta librería se usa para habilitar los Cors en nuestra API y poder recibir peticiones desde cualquier dirección.
- *Microsoft.VisualStudio.Azure.Containers.Tools.Targets:* esta librería se instala por defecto cuando se configura el campo de Docker al crear la API.
- *Serilog*: Esta librería se usa para el manejo de loggers dentro del API
- *Swashbuckle.AspNetCore:* Esta librería se utiliza para poder  configurar el swagger.
- *System.Configuration.ConfigurationManager:* esta librería se utiliza para poder acceder a los datos del appsetting. 




## Instalación

Descargue el proyecto en una ruta en su PC, y abra la carpeta con su editor de código de preferencia, si usa Visual Studio, solo deberá ejecutar el proyecto **Api.Orq.Pagos** y el **IIS Express**

![2022-05-10 11_58_15-Api.Orq.Pago - Microsoft Visual Studio.png](#file:b1899488-5d5e-c729-214c-b0cc7d80f29c)

de esta manera, se ejecutará el proyecto:

![swagger pagos.png](#file:05729af1-96d3-2279-e66a-8d552cd690b1)

## Pruebas unitarias 
### XUnit
Este proyecto se le realizaron pruebas unitarias con Xunit, es el proyecto que mas completo tiene las pruebas, puesto que los demas no poseen o solo tienen muy pocas.


## Repositorios relacionados

La aplicación consta de cuatro repositorios incluido este  para funcionar:

[**Front-ShoppingCar**](https://github.com/juliankgp/Front-ShoppingCar) : Este repositorio es el front de la aplicación, se encarga de mostrar la interfaz gráfica de nuestra aplicación.

[**Productos-ShoppingCar**](https://github.com/juliankgp/Productos-ShoppingCar): Este repositorio se encarga de gestionar todos los productos del catálogo, envía y devuelve todas las peticiones del front referente con los productos. 

[**Logistica-ShoppingCar**](https://github.com/juliankgp/Logistica-ShoppingCar) : Este repositorio es el principal del backend, se encarga de generar la estructura de la base de datos y de gestionar todo lo referente a los pedidos enviados desde la API [**Orq-ShoppingCar**](https://github.com/juliankgp/Orq-ShoppingCar).

## Métodos



 [*API Logística*](https://github.com/juliankgp/Logistica-ShoppingCar)

| Nombre | Path | Método |
| ------ | ------ | ------ |
| ObtenerPedidos |[*api/Facturacion/ObtenerPedidos*](https://github.com/juliankgp/Logistica-ShoppingCar) | GET|
| ObtenerPedidoId | [*api/Facturacion/ObtenerPedidoId*](https://github.com/juliankgp/Logistica-ShoppingCar) |GET|
| GuardarPedido | [*api/Facturacion/GuardarPedido*](https://github.com/juliankgp/Logistica-ShoppingCar) | POST	|
|FacturarPedido|  [*api/Facturacion/FacturarPedido*](https://github.com/juliankgp/Logistica-ShoppingCar)|POST|


[*Api Productos*](https://github.com/juliankgp/Productos-ShoppingCar)

| Nombre | Path | Método |
| ------ | ------ |-------|
| CrearProducto  | [*api/Productos/CrearProducto*](https://github.com/juliankgp/Productos-ShoppingCar)| POST |
| ObtenerProductos |[*api/Productos/ObtenerProductos*](https://github.com/juliankgp/Productos-ShoppingCar) |GET|
| ObtenerProductoPorId | [*api/Productos/ObtenerProductoPorId*](https://github.com/juliankgp/Productos-ShoppingCar) |GET|
