# Esfera dados 4 puntos geométricos
###Cálculo centro y radio esfera dados 4 puntos.

En geometría analítica, se sabe que existe una única esfera que pase por 4 puntos no coplanarios, sí y solo sí, no se encuentran en el mismo plano. Si están en el mismo plano, por lógica, no existe una esfera que pase por 4 puntos o existe un numero infinito si los 4 puntos se encuentran en un círculo perfecto.

Teniendo los puntos:

**{x1, y1, z1}, {x2, y2, z2}, {x3, y3, z3}, {x4, y4, z4}**

¿Cómo se puede encontrar el centro y el radio de la esfera que corte exáctamente esos puntos? Sencillo. 
Se puede encontrar la solución a través del determinante de la ecuación.

|  x<sup>2</sup>+y<sup>2</sup> + z<sup>2</sup> | x | y | z | 1 | |
|:-----------:|:-:|:-:|:-:|:-:|:-:|
x<sub>1</sub><sup>2</sup> + y<sub>1</sub><sup>2</sup> + z<sub>1</sub><sup>2</sup> | x<sub>1</sub> | y<sub>1</sub> | z<sub>1</sub>  | 1 | 
x<sub>2</sub><sup>2</sup>+y<sub>2</sub><sup>2</sup> + z<sub>2</sub><sup>2</sup> | x<sub>2</sub> | y<sub>2</sub> | z<sub>2</sub>  | 1 |  = 0 |
x<sub>3</sub><sup>2</sup>+y<sub>3</sub><sup>2</sup> + z<sub>3</sub><sup>2</sup> | x<sub>3</sub> | y<sub>3</sub> | z<sub>3</sub>  | 1 | 
x<sub>4</sub><sup>2</sup>+y<sub>4</sub><sup>2</sup> + z<sub>4</sub><sup>2</sup> | x<sub>4</sub> | y<sub>4</sub> | z<sub>4</sub>  | 1 | 

Evaluando los cofactores de la primera fila del determinante se puede obtener la solución. La ecuación del determinante puede transformarse y tener los cofactores de la siguiente forma: 

 **(x<sup>2</sup>+y<sup>2</sup> + z<sup>2</sup>)·M<sub>11</sub> - x · M<sub>12</sub> + y · M<sub>13</sub> - z · M<sub>13</sub> + M<sub>15</sub> = 0**
 
 La cual se puede convertir a la forma canónica de la ecuación de la esfera:

 **x<sup>2</sup>+y<sup>2</sup> + z<sup>2</sup> - (M<sub>12</sub>/ M<sub>11</sub>) · x + (M<sub>13</sub>/ M<sub>11</sub>) · y - (M<sub>14</sub>/ M<sub>11</sub>) · z + M<sub>15</sub>/ M<sub>11</sub> = 0**
 
 Realizando los cuadrados con x, y, z se obtiene:

 **x<sub>0</sub> = 0,5 · M<sub>12</sub>/M<sub>11</sub>**
 
 **y<sub>0</sub> = -0,5 · M<sub>13</sub>/M<sub>11</sub>**
 
 **z<sub>0</sub> = 0,5 · M<sub>14</sub>/M<sub>11</sub>**
 
 **r<sub>0</sub><sup>2</sup> = (x<sub>0</sub><sup>2</sup> + y<sub>0</sub><sup>2</sup> + z<sub>0</sub><sup>2</sup>) - M<sub>15</sub>/M<sub>11</sub>**
 
 Cabe destacar que no existe solución cuando M<sub>11</sub> es 0. En ese caso, los puntos no pertenece a una esfera. Pueden pertenecer al mismo plano o 3 puntos pertenecients a la misma linea recta.
 
###Uso 
 
 ```c#
double[] puntoA={1,2,3};
double[] puntoB={3,5,1};
double[] puntoC={4,8,2};
double[] puntoD={2,7,10};

CalcularEsfera4Puntos calculo=new CalcularEsfera4Puntos(puntoA, puntoB, puntoC, puntoD);

double[] centroEsfera=calculo.Centro(); //Array de 3 doubles indicando el centro geométrico de la esfera
double radio=calculo.Radio(); //Radio de la misma
```
