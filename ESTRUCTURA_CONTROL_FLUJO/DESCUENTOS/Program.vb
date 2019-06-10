Imports System
Module Program
    Private descuen, total As Decimal
    Sub Main(args As String())
        Call carga()
    End Sub
    Sub carga()
        Dim cant, precio As Decimal
        Do
            Console.Write("ingrese la cantidad del producto: ")
            cant = Console.ReadLine()
            If cant <> 0 Then
                Console.Write("ingrese el precio del producto: ")
                precio = Console.ReadLine()
            End If
            Call desc(cant, precio)
        Loop Until cant = 0
        Console.WriteLine("el descuento total es de {0} y el total a pagar es de {1}", descuen, total)

    End Sub

    Sub desc(ByVal c As Decimal, ByRef p As Decimal)
        Dim des, subtotal As Decimal
        Select Case c
            Case 10 To 50
                des = (p * c) * 0.05
                subtotal = (p * c) - des
            Case 51 To 250
                des = (p * c) * 0.1
                subtotal = (p * c) - des
            Case Is > 250
                des = (p * c) * 0.2
                subtotal = (p * c) - des
        End Select
        descuen += des
        total += subtotal
    End Sub
End Module
