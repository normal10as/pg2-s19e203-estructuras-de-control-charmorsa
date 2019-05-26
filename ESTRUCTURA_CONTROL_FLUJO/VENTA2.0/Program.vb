Imports System

Module Program
    Sub Main(args As String())
        Dim cantidad As UShort
        Dim precio_unitario As Decimal
        Console.Write("Cantidad del Producto: ")
        cantidad = Console.ReadLine()
        Console.Write("Precio Unitario: ")
        precio_unitario = Console.ReadLine()

        Call ventas(cantidad, precio_unitario)

    End Sub

    Sub ventas(ByRef cant, ByRef preuni)
        Dim subt, desc, tot As Decimal
        subt = cant * preuni
        Console.WriteLine("SubTotal: " & subt)
        Select Case cant
            Case 10 To 50
                Console.WriteLine("Descuento: 5%")
                desc = subt * 0.05
                Console.WriteLine("Monto Descontado: " & desc)
            Case 51 To 250
                Console.WriteLine("Descuento: 10%")
                desc = subt * 0.1
                Console.WriteLine("Monto Descontado: " & desc)
            Case Is > 250
                Console.WriteLine("Descuento: 20%")
                desc = subt * 0.2
                Console.WriteLine("Monto Descontado: " & desc)
        End Select
        tot = subt - desc
        Console.WriteLine("Total: " & tot)
    End Sub
End Module