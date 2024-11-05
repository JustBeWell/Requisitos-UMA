## PRIMERA ITERACION DE REQUISITOS

Implementación de requisitos para proceder con los casos de uso, casos de prueba y boceto de la interfaz:

(no se tomaran en cuenta ni assets ni relaciones)

/ significa que son obligatorios de introducir en un producto

Cualquier tipo string tiene de limite 205 caracteres

1 GESTION DE PRODUCTOS
	- Listar productos (como la pag 12 por ejemplo (en caso de texto en los atributos limitar los caracteres))
	- Crear productos ( dicen que al crear es mejor un formulario que pedir 10 campos uno detras de otro)
		- Atributos del sistema
			- /SKU
			- /GTIN 
				- Validar el GTIN -14
			- /label (nombre del producto dicho por el profe)
			- Thumbnail
				- png, jpg, jpeg
				- 200 x 200 pixeles
			- /fecha de creación
			- /fecha de modificación
		- Atributos de usuario
		- Asignar categorias
	- Borrar (puede ser una papelera clicable con funcion de borrar)
	- Editar
	- Consultar/Mostrar (como la pag 11 por ejemplo)


2 GESTION DE ATRIBUTOS DE USUARIO
	- Crear (Al crear un atributo no puede tener un nombre de un atributo ya existente, ya que son clave valor)
	- Leer (tiene dos atributos?? tipo y nombre) (se muestran todos los que este tengan o no valor)
	- Modificar
	- Borrar


3 GESTION DE ETIQUETAS/CATEGORIAS
	- Crear
	- Leer (nombre, num de productos que tengan esa categoría)
	- Modificar
	- Borrar (si borra la categoría no se borran los productos)


Estos son los requisitos que tenemos, dicen que estaría bien poner botones para volver al principio
Quieren una imagen estatica

Crear todos los bocetos que sean necesarios para luego enseñárselos al cliente

Las formas de mostrar o algunas más se pueden sacar de la presentación de plytix

Vamos a tener un sistema de mínimo dos cuentas, tenemos en cuenta que los usuarios ya existen no hace falta login,
tendríamos una pantalla inicial donde nos dejaría escoger entre los usuarios que tenemos
Los productos de una cuenta son distintos a los que tengan las demás (no distintos de que no son los mismos sino que no los comparten)

Recomienda Balsamic Mockup pero la podemos hacer con lo que la queramos


Que nos centremos en hacerlo que han dicho bien, que no hagamos requisitos de más


La aplicación debe ser ampliable por ejemplo en siguientes iteraciones pueden pedirnos que añadamos assets o un filtro