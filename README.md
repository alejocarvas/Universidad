# Universidad
En este repositorio encontrarás la implementación del patrón arquitectonico de Repository y Unit of Work en un proyecto en .Net Core 3.1 por capas.

Utilizamos 4 capas en nuestro proyecto, las cuales podrán ver en la siguiente imagen:

![image](https://user-images.githubusercontent.com/72578049/201115199-844a91ae-f33b-44ef-b644-63f02b81218d.png)

Como se puede ver en la anterior imagen hacemos uso de una capa de API, una capa de servicio (Service), una capa de datos (Data) que es la encargada 
de la implemnetación del patrón de repositorio y de unidad de trabajo, y por último una capa transversal de DTO para exponer los objeto de transferencia de datos.

En la capa de aplicación se implementó Swagger para el proceso de documentación de la API y en la capa de datos se hace uso de Dapper como micro ORM para el manejo 
de los objetos en la base de datos.

Se hace uso de una base de datos en SQL Server, la cual se podrá crear haciendo uso del archivo "Crear base de datos.sql" que se encuentra en la carpeta SQL del 
presente repositorio.
