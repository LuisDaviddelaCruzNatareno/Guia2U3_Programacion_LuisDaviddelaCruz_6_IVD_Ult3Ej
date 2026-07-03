Algoritmo Lecc17_Act3_Inc2
	Definir fila, columna, x, yy, mayorr Como Entero
	Definir tabla Como Entero
	Dimensionar tabla[4,4]
	Para fila = 1 Hasta 4 Hacer
		Para columna = 1 Hasta 4 Hacer
			Escribir "Ingrese un numero"
			Leer tabla[fila,columna]
		Fin Para
	Fin Para
	mayorr = tabla[1,1]
	x=1
	yy=1
	Para fila = 1 Hasta 4 Hacer
		Para columna=1 Hasta 4 Hacer
			Si tabla[fila,columna] > mayorr Entonces
				mayorr=tabla[fila,columna]
				x=fila
				yy=columna
			Fin Si
		Fin Para
	Fin Para
	Escribir "El numero mayor es: ", mayorr
	Escribir "Esta en la fila: ", x
	Escribir "Y en la columna: ", yy
FinAlgoritmo
