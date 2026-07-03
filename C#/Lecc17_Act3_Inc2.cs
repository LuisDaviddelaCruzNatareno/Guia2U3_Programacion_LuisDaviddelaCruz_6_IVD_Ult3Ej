internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna, x, y, mayor;
        int[,] tabla = new int[4, 4];

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.WriteLine("Ingrese un numero");
                tabla[fila, columna] = int.Parse(Console.ReadLine());
            }
        }

        mayor = tabla[0, 0];
        x = 1;
        y= 1;

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna] > mayor)
                {
                    mayor = tabla[fila, columna];
                    x = fila + 1;    
                    y = columna + 1; 
                }
            }
        }

        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine("Esta en la fila: " + x);
        Console.WriteLine("Y en la columna: " + y);
    }
}