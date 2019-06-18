Imports System

Module Program
    Sub main()
        Dim numero, resultado As Integer
        numero = carga()
        Console.WriteLine("la sumatoria de las potencias del 1 al {0} es de {1}", numero, sumatoria(numero, resultado))
    End Sub

    Function carga() As Integer
        Dim val As Integer = 0
        Console.Write("ingrese un valor: ")
        Do
            val = Console.ReadLine()
            If val < 0 Then
                Console.WriteLine("el numero debe ser mayor o igual a cero 0")
            End If
        Loop While val < 0
        Return val
    End Function

    Function sumatoria(n, ByRef resultado) As Integer
        Dim i As Integer
        For i = 1 To n
            resultado += potencia(i)
        Next
        Return resultado
    End Function

    Function potencia(indice As Integer) As Integer
        Return indice ^ 2
    End Function
End Module
