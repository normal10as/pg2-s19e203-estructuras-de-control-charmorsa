Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, r As Byte
        Console.Write("ingrese un valor: ")
        a = Console.ReadLine()
        Console.Write("ingrese otro valor: ")
        b = Console.ReadLine()

        Console.WriteLine(comparacion(a, b))
    End Sub

    Function comparacion(ByRef x, ByRef y) As String
        Dim i As String
        If x < y Then
            i = "el primer valor es menor al segundo valor"
            Return i
        ElseIf x > y Then
            i = "el primer valor es mayor al segundo valor"
            Return i
        Else
            i = "los valores son iguales"
            Return i
        End If
    End Function

End Module
