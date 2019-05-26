Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Byte
        Console.Write("ingresar el primer valor: ")
        a = Console.ReadLine()
        Console.Write("ingresar el segundo valor: ")
        b = Console.ReadLine()
        Console.Write("ingresar el tercer valor: ")
        c = Console.ReadLine()
        Call menor(a, b, c)
    End Sub

    Sub menor(ByRef x, ByRef y, ByRef z)
        If (x < y) And (x < z) Then
            Console.Write("el de menor valor es el primero")
        ElseIf (y < x) And (y < z) Then
            Console.Write("el de menor valor es el segundo")
        Else
            Console.Write("el de menor valor es el tercero")
        End If
    End Sub
End Module
