Imports System

Module Program
    Sub Main(args As String())
        Call fibo()
    End Sub

    Sub fibo()
        Dim a = 1, b = 0, suma As UInteger
        For y = 1 To 20
            Console.WriteLine("en la pos {0} el numero de fibonacci es {1}", y, suma)
            suma = a + b
            b = a
            a = suma
        Next
    End Sub
End Module
