'Escuela Superior de Ingieeria Textil
'Ortis Castro Juan Manuel
'TV65
'Codigo para calcular de hilos por hora


Imports System

Module Program
    Sub Main()


        Dim metros As Integer
        Dim tiempo As Integer
        Dim produccion As Double


        Console.WriteLine("Introduce los metros de hilo producidos:")
        metros = Console.ReadLine()
        Console.WriteLine("Introduce el tiempo en minutos:")
        tiempo = Console.ReadLine()


        produccion = (metros / tiempo) * 60


        Console.WriteLine("La producción de hilo por hora es de " & produccion & " metros.")


        Console.WriteLine()
        Console.ReadKey()


    End Sub

End Module
