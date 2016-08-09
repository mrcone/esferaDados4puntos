# esferaDados4puntos
###Cálculo centro y radio esfera dados 4 puntos.

En geometría analítica, se sabe que existe una única esfera que pase por 4 puntos no coplanarios, sí y solo sí, no se encuentran en el mismo plano. Si están en el mismo plano, por lógica, no existe una esfera que pase por 4 puntos o existe un numero infinito si los 4 puntos se encuentran en un círculo perfecto.

Teniendo los puntos:

`{x1, y1, z1}, {x2, y2, z2}, {x3, y3, z3}, {x4, y4, z4}`

¿Cómo se puede encontrar el centro y el radio de la esfera que corte exáctamente esos puntos? Sencillo. 
Se puede encontrar la solución a través del determinante de la ecuación.

|  x<sup>2</sup>+y<sup>2</sup> + z<sup>2</sup> | x | y | z | 1 | |
|:-----------:|:-:|:-:|:-:|:-:|:-:|
x<sub>1</sub><sup>2</sup> + y<sub>1</sub><sup>2</sup> + z<sub>1</sub><sup>2</sup> | x<sub>1</sub> | y<sub>1</sub> | z<sub>1</sub>  | 1 | 
x<sub>2</sub><sup>2</sup>+y<sub>2</sub><sup>2</sup> + z<sub>2</sub><sup>2</sup> | x<sub>2</sub> | y<sub>2</sub> | z<sub>2</sub>  | 1 |  = 0 |
x<sub>3</sub><sup>2</sup>+y<sub>3</sub><sup>2</sup> + z<sub>3</sub><sup>2</sup> | x<sub>3</sub> | y<sub>3</sub> | z<sub>3</sub>  | 1 | 
x<sub>4</sub><sup>2</sup>+y<sub>4</sub><sup>2</sup> + z<sub>4</sub><sup>2</sup> | x<sub>4</sub> | y<sub>4</sub> | z<sub>4</sub>  | 1 | 
