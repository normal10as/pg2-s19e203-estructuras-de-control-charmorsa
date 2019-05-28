Imports System
Module Program
    Enum meses
        ENERO = 1
        FEBRERO
        MARZO
        ABRIL
        MAYO
        JUNIO
        JULIO
        AGOSTO
        SEPTIEMBRE
        OCTUBRE
        NOVIEMBRE
        DICIEMBRE
    End Enum
    Sub Main(args As String())
        Dim num As meses
        Console.Write("Ingrese el Numero del Mes: ")
        num = Console.ReadLine()
        Call mes(num)

    End Sub

    Sub mes(a)
        Select Case a
            Case meses.ENERO
                Console.Write("ENERO")
            Case meses.FEBRERO
                Console.Write(a.ToString)
            Case meses.MARZO
                Console.Write("MARZO")
            Case meses.ABRIL
                Console.Write(a.ToString)
            Case meses.MAYO
                Console.Write("MAYO")
            Case meses.JUNIO
                Console.Write(a.ToString)
            Case meses.JULIO
                Console.Write("JULIO")
            Case meses.AGOSTO
                Console.Write(a.ToString)
            Case meses.SEPTIEMBRE
                Console.Write("SEPTIEMBRE")
            Case meses.OCTUBRE
                Console.Write(a.ToString)
            Case meses.NOVIEMBRE
                Console.Write("NOVIEMBRE")
            Case meses.DICIEMBRE
                Console.Write(a.ToString)
            Case Else
                Console.Write("El Numero es Invalido")
        End Select
    End Sub
End Module
