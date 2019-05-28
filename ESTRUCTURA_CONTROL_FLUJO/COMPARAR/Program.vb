Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, r As Byte
        a = ingresar_dato("ingresar un valor")
        b = ingresar_dato("ingresar otro valor")

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

    Function ingresar_dato(mensaje As String) As Integer
        Dim valor As Integer
        Console.Write(mensaje)
        valor = Console.ReadLine()
        Return valor
    End Function
End Module
