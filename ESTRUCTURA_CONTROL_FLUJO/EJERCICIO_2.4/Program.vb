Imports System

Module Program
    Sub Main(args As String())
        Dim radio, altura As Decimal
        Console.Write("ingrese el radio de la base del cilindro: ")
        radio = carga()
        Console.Write("ingrese la altura del cilindro: ")
        altura = carga()

        Console.WriteLine("resultado del volumen del cilindro es " & cilindro(radio, altura))
    End Sub

    Function carga() As Decimal
        Dim val As Decimal
        Do
            val = Console.ReadLine()
            If val < 0 Then
                Console.WriteLine("el numero debe ser mayor o igual a cero '0'")
            End If
        Loop While val < 0
        Return val
    End Function

    Function cilindro(r, h) As Decimal
        Return (3.14 * r ^ 2) * h
    End Function
End Module
