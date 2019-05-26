Imports System

Module Program
    Sub Main(args As String())
        Dim ang As UShort
        Console.WriteLine("ingrese el grado de un angulo")
        ang = Console.ReadLine()
        Call angulos(ang)
    End Sub

    Sub angulos(ByRef a)
        Select Case a
            Case 0
                Console.Write("ERROR")
            Case Is < 90
                Console.Write("ANGULO AGUDO")
            Case 90
                Console.Write("ANGULO RECTO")
            Case 91 To 179
                Console.Write("ANGULO OBTUSO")
            Case 180
                Console.Write("ANGULO LLANO")
            Case 181 To 359
                Console.Write("ANGULO CONCAVO")
            Case 360
                Console.Write("ERROR")
        End Select
    End Sub
End Module
