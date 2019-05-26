Imports System
Module Program
    Enum meses
        nomes
        ENERO
        FEBRERO
        MARZO
        ABRIL
        MAYO
        JUNIO
        JULIO
        AGOSTO
        SEPTIEMBRE
        OCTUBRE
        NOVIEMBRE
        DICIEMBRE
    End Enum
    Sub Main(args As String())
        Dim num As meses
        Console.Write("Ingrese el Numero del Mes: ")
        num = Console.ReadLine()
        Call mes(num)

    End Sub

    Sub mes(a)
        Select Case a
            Case 0
                Console.Write("El numero es Invalido")
            Case 1
                Console.Write(a.ToString)
            Case 2
                Console.Write(a.ToString)
            Case 3
                Console.Write(a.ToString)
            Case 4
                Console.Write(a.ToString)
            Case 5
                Console.Write(a.ToString)
            Case 6
                Console.Write(a.ToString)
            Case 7
                Console.Write(a.ToString)
            Case 8
                Console.Write(a.ToString)
            Case 9
                Console.Write(a.ToString)
            Case 10
                Console.Write(a.ToString)
            Case 11
                Console.Write(a.ToString)
            Case 12
                Console.Write(a.ToString)
            Case Is > 12
                Console.Write("El Numero es Invalido")
        End Select
    End Sub
End Module
