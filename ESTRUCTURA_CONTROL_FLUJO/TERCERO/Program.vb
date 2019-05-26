Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c, d, e As Integer
        Console.WriteLine("ingresar 5 numeros")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        e = Console.ReadLine()

        Call posicion(a, b, c, d, e)
    End Sub

    Sub posicion(ByRef p, ByRef q, ByRef r, ByRef s, ByRef t)
        If (p > q) And (p > r) And (p > s) And (p > t) Then
            Console.Write("el valor mayor se encuentra primero")
        ElseIf (q > p) And (q > r) And (q > s) And (q > t) Then
            Console.Write("el valor mayor se encuentra segundo")
        ElseIf (r > p) And (r > q) And (r > s) And (r > t) Then
            Console.Write("el valor mayor se encuentra tercero")
        ElseIf (s > p) And (s > r) And (s > q) And (s > t) Then
            Console.Write("el valor mayor se encuentra cuarto")
        Else
            Console.Write("el valor mayor se encuentra quinto")
        End If
    End Sub
End Module
