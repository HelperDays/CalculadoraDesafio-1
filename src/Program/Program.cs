﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));

// Esta clase implementa la operación <Multiplicacion>
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    
}
//Clase para usar funcion de Division
public class Division
{
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}

//Clase para usar la funcion de Suma
public class Addition
{
    public static int Add(int a, int b)
    {
        return 0; // Cambio incorrecto
    }
}
//clase para usar la funcion de Resta
public class Substraction
{
    public static int Substract(int a, int b)
    {
        return a - b;
    }
}