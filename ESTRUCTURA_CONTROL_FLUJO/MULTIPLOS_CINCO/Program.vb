Imports System

Module Program
    Sub Main()
        Dim a, b As Byte
        Console.Write("ingrese un numero: ")
        a = Console.ReadLine()
        Console.Write("ingrese un numero mayor al primero: ")
        b = Console.ReadLine()
        'Call confor(a, b)
        'Call Condowhile(a, b)
        'Call condoloop(a, b)
        'Call condountil(a, b)
        Call condountiloop(a, b)
    End Sub
    Sub confor(ByRef x As Byte, ByRef y As Byte)
        Dim multi As Byte
        For i = x To y
            multi = i Mod 5
            If multi = 0 Then
                Console.WriteLine("el numero " & i & " es multiplo de 5.")
            End If
        Next
    End Sub

    Sub Condowhile(ByRef x As Byte, ByRef y As Byte)
        Dim multi, i As Byte
        i = x
        Do While (i < y)
            multi = i Mod 5
            If multi = 0 Then
                Console.WriteLine("el numero " & i & " es multiplo de 5")
            End If
            i += 1
        Loop
    End Sub

    Sub Condoloop(ByRef x As Byte, ByRef y As Byte)
        Dim multi, i As Byte
        i = x
        Do
            multi = i Mod 5
            If multi = 0 Then
                Console.WriteLine("el numero " & i & " es multiplo de 5")
            End If
            i += 1
        Loop While (i < y)
    End Sub

    Sub condountil(ByRef x As Byte, ByRef y As Byte)
        Dim multi, i As Byte
        i = x
        Do Until (i = y)
            multi = i Mod 5
            If multi = 0 Then
                Console.WriteLine("el numero " & i & " es multiplo de 5")
            End If
            i += 1
        Loop
    End Sub

    Sub condountiloop(ByRef x As Byte, ByRef y As Byte)
        Dim multi, i As Byte
        i = x
        Do
            multi = i Mod 5
            If multi = 0 Then
                Console.WriteLine("el numero " & i & " es multiplo de 5")
            End If
            i += 1
        Loop Until (i = y)
    End Sub
End Module
