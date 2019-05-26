Imports System
Imports System.DateTime
Module Program
    Enum meses
        nomes
        ENERO
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
        Dim m As meses
        Console.Write("Ingrese el numero de un mes: ")
        m = Console.ReadLine()
        Console.Write(m.ToString)
        Call dia(m)

    End Sub
    Sub dia(d)
        Select Case d
            Case 1, 3, 5, 7, 8, 10, 12
                Console.Write(" tiene 31 dias")
            Case 2
                Console.Write(bisiesto(d))
            Case 4, 6, 9, 11
                Console.Write(" tiene 30 dias")
        End Select
    End Sub

    Function bisiesto(b) As String
        Dim r As String
        Dim ano As Integer
        ano = Now.Year
        If ((ano Mod 4) = 0) And ((ano) Mod 100 <> 0) Or ((ano Mod 400) = 0) Then
            r = " tiene 29 dias"
            Return r
        Else
            r = " tiene 28 dias"
            Return r
        End If
    End Function
End Module
