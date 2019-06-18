Imports System

Module Program
    Sub Main(args As String())
        Dim ladoA, ladoB As Decimal

        ladoA = carga()
        ladoB = carga()

        Console.WriteLine(" resultado de la hipotenusa: " & hipopotenusa(ladoA, ladoB))
    End Sub
    Function carga() As Decimal
        Dim val As Decimal
        Console.Write("Ingrese un valor: ")
        Do
            val = Console.ReadLine()
            If val < 0 Then
                Console.WriteLine("el numero debe ser mayor o igual a cero '0'")
            End If
        Loop While val < 0
        Return val
    End Function

    Function hipopotenusa(a, b) As Double
        Dim c As Double
        c = (a ^ 2) + (b ^ 2)
        Return c
    End Function
End Module

