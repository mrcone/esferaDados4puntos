# esferaDados4puntos
###Cálculo centro y radio esfera dados 4 puntos.

En geometría analítica, se sabe que existe una única esfera que pase por 4 puntos no coplanarios, sí y solo sí, no se encuentran en el mismo plano. Si están en el mismo plano, por lógica, no existe una esfera que pase por 4 puntos o existe un numero infinito si los 4 puntos se encuentran en un círculo perfecto.

Teniendo los puntos:

`{x1, y1, z1}, {x2, y2, z2}, {x3, y3, z3}, {x4, y4, z4}`

¿Cómo se puede encontrar el centro y el radio de la esfera que corte exáctamente esos puntos? Sencillo. 
Se puede encontrar la solución a través del determinante de la ecuación:

`` x2 +  y2 + z2 		x 	y 	z 	1 
x12 + y12 + z12 	x1 	y1 	z1 	1 ``

x22 + y22 + z22 	x2 	y2 	z2 	1   = 0

x32 + y32 + z32 	x3 	y3 	z3 	1

x42 + y42 + z42 	x4 	y4 	z4 	1`
