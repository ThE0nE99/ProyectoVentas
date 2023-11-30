# ProyectoVentas
// enlace ha Videos 
https://www.youtube.com/watch?v=vZRemXrkJAM
Le recomendamos que se descargue el archivo .rar puesto que se genere un error por el git y revise el Word que esta detallado con imagenes para la configuracion e instalacion respectiva del proyecto. 
    Manual Técnico

1.	Introducción:
Este informe presenta un análisis detallado del proyecto de desarrollo basado en una arquitectura de tres capas, focalizado en la implementación de operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en siete tablas principales: Usuario, Cliente, Artículo, Detalle de Ingreso, Detalle de Venta, Ingreso, Venta y Proveedor. Este proyecto se sustenta en una estructura robusta de tres capas, compuesta por la capa de presentación, capa lógica y capa de acceso a datos.
Este proyecto se fundamenta en un prototipo inicial que cumplía con las especificaciones básicas. La adaptación y mejora continua se han llevado a cabo sobre esta base, implementando nuevos requisitos y funcionalidades sin perder de vista las directrices establecidas en el proyecto original.
El presente informe tiene como objetivo principal brindar una visión detallada del diseño, implementación y funcionamiento del proyecto en cuestión. Se analizarán las características principales de cada capa, la interacción entre ellas y la forma en que se gestionan las operaciones CRUD en las tablas mencionadas.

2.	Descripción del proyecto:

El proyecto se centra en el desarrollo de un sistema basado en una arquitectura de tres capas que gestiona operaciones CRUD en siete tablas principales: Usuario, Cliente, Artículo, Detalle de Ingreso, Detalle de Venta, Ingreso Venta y Proveedor. Estas tablas representan entidades fundamentales para la gestión de usuarios, clientes, productos y transacciones de venta.
La arquitectura del sistema se compone de una capa de presentación para la interacción con el usuario, una capa lógica que implementa la lógica de negocio y una capa de acceso a datos que se conecta a la base de datos utilizando procedimientos almacenados.
Este proyecto evoluciona a partir de un prototipo inicial, manteniendo la estructura base mientras se agregan nuevas funcionalidades y se optimiza su desempeño. La implementación se rige por estándares específicos que definen la nomenclatura de tablas, procedimientos almacenados y la organización de las capas, asegurando una gestión eficiente de la información y la interacción entre los distintos niveles del sistema.


3.	Roles / integrantes
No hay existencia de roles debido a que es un proyecto de prueba

4.	Arquitectura del software: 

No tenemos una estructura u organización de software porque es un proyecto de prueba 

5.	Requisitos del sistema:
•	Requerimientos de Hardware (mínimo): Lo mas mínimo debido a que es una aplicación pequeña que simplemente muestra un crud sencillo
•	Requerimientos de Software: (cliente): Una conexión de internet y acceso a la base de datos
•	Requerimientos de Hardware (server/ hosting/BD): No tenemos un hosting
•	Requerimientos de Software (server/ hosting/BD) : No tenemos un hosting

6.	Instalación y configuración: Instrucciones detalladas sobre cómo instalar el software, configurar los componentes necesarios y establecer la conexión con otros sistemas o bases de datos

Punto 1
Restaurar la base de datos
Como restaurar 

Paso 1: Clic derecho en la carpeta (Databases)-Seleccionar Restore Database

Paso 2: Cambiar en Database a Device y darle click al botón de esa fila


Paso3: Dar click al botón Add y seleccionar la ubicación de la base de datos y una vez seleccionada la base de datos dar click al botón OK


Paso 4

•	Dar click al botón OK para que la base de datos se restaure
Paso 5
Dar click al botón Aceptar en cuanto se vea la ventana de la imagen
Punto 2
•	Abrir el proyecto
•	Ir a la capa 1 (Capa de acceso a datos” SWADNETVENTAS”)
•	
•	luego Web.config “Verificar la cadena de conexión”

•	Ir a la capa 2 (Capa de Negocio “SWLNVENTAS”)
•	
•	Ir a la carpeta App_WebReferences (Click derecho) “Actualizar referencia web o de servicio”
•	

•	Ir a la capa 3 (Capa de presentación “WAVENTAS”) (Click derecho) “Establecer como proyecto de inicio”

•	Ir a la carpeta WebForm -> carpeta Menú -> Default.aspx (Click derecho) “Establecer como página de inicio”

•	Ir a la carpeta App_WebReferences (Click derecho) “Actualizar referencia web o de servicio

•	Ir a la ventana Compilar -> Compilar solución, luego recompilar solución
•	
•	Luego Iniciar
•	
•	En caso de que no funcione, cierra Visual Studio y repite todo el proceso. 

7.	PROCEDIMIENTO DE HOSTEADO / HOSTING (configuración)
•	Sitio Web.
•	B.D.
•	API / servicios Web
•	Otros (firebase, etc.)

No contamos con ningún método de hosteado, simplemente se maneja la aplicación creada en visual studio
8.	GIT: 
•	https://github.com/ThE0nE99/ProyectoVentas
•	Rama: Master
OBSERVACION: El archivo debido a la cantidad de servicio que tiene tiende a dar errores a la hora de hacer la clonación de esta rama, SE RECOMIENDA UTILIZAR EL ARCHIVO .rar ADJUNTADO AL PROYECTO
9.	Personalización y configuración: 
No se puede personalizar ni configurar, el usuario simplemente llena los datos que pide cada casilla del crud de las tablas

10.	Seguridad: 

No hay Consideraciones de seguridad y recomendaciones

11.	Depuración y solución de problemas: 
En caso de que sucedan errores se debe hacer una recopilación del programa posterior mente actualizar las referencias de la segunda capa, seguido de actualizar las referencias de la última capa y establecer la página de inicio la vista de nombre default dentro de la carpeta menú IGUAL QUE COMO SE INDICÓ ANTERIORMENTE

12.	Glosario de términos: 

• Capa de ACCESO A DATOS, hace referencia a la primera capa del sistema, el cual cuenta con todos los datos obtenidos de la base de datos y se hace la conexión a esta 
• Capa de NEGOCIO, hace referencia a la segunda capa del sistema la cual tiene toda la lógica que tendrá el sistema 
• Capa de PRESENTACION, hace referencia a la última capa del sistema la cual contiene las vistas utilizadas en el proyecto
13.	Referencias y recursos adicionales: 
No hay referencias externas

14.	Herramientas de Implementación:

• Lenguajes de programación: c# 
• Frameworks: ninguno 
• APIs de terceros, etc. ninguno




