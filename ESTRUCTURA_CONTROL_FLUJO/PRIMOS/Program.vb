Imports System
Module Program
    Sub Main(args As String())
        Call primito()
    End Sub

    Sub primito()
        Dim aux, numero, cont As Integer
        For i = 1 To 1000
            If i Mod 2 <> 0 Then
                aux = 1
                cont = 0
                Do
                    numero = i Mod aux
                    If numero = 0 Then
                        cont += 1
                    End If
                    aux += 1
                Loop Until aux > i
                If cont = 2 Then
                    Console.WriteLine("el numero {0} es primo ", i)
                End If
            ElseIf i = 2 Then
                Console.WriteLine("el numero {0} es primo", i)
            End If
        Next
    End Sub


End Module
