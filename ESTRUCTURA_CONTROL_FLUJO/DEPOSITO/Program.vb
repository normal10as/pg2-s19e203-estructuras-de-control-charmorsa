Imports System

Module Program
    Const interes = 0.36

    Sub main()
        Call carga()
    End Sub

    Sub carga()
        Dim capital As Decimal
        Dim meses As Byte
        Console.Write("Ingrese el capital: ")
        capital = Console.ReadLine()
        Console.Write("Ingrese la cantidad de meses: ")
        meses = Console.ReadLine()
        Call inter(capital, meses)
    End Sub


    Sub inter(cap As Decimal, mes As Byte)
        Dim inter, saldo As Decimal
        For i As Byte = 1 To mes
            inter = (cap * ((mes * interes) / 12) * mes) / 365
            saldo = cap - inter
            Console.WriteLine("mes: {0} --- capital {1} --- interes {2} --- saldo {3} ", i, cap, inter, saldo)
        Next
    End Sub
End Module
