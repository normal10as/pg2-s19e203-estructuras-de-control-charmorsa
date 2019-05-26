Imports System

Module Program
    Sub Main(args As String())
        Dim num As Double
        Dim selecion As Byte
        Console.Write("ingrese un valor: ")
        num = Console.ReadLine()
        Console.WriteLine("     SELECCIONE UNA OPCION: ")
        Console.WriteLine("1-PIE")
        Console.WriteLine("2-PULGADA")
        Console.WriteLine("3-YARDA")
        Console.WriteLine("4-CENTIMETRO")
        Console.WriteLine("5-METRO")
        selecion = Console.ReadLine()
        Call convertir(num, selecion)
    End Sub
    Sub convertir(ByRef n, ByRef s)
        Dim a, b, c, d As Double
        Select Case s
            Case 1
                Console.WriteLine("Usted a ingresado " & n & " PIE/ES")
                a = n * 12
                Console.WriteLine("convertido en pulgadas " & a)
                b = n / 3
                Console.WriteLine("convertido en yardas " & b)
                c = a * 2.54
                Console.WriteLine("convertido en centimetros " & c)
                d = c / 100
                Console.WriteLine("convertido en metros " & d)
            Case 2
                Console.WriteLine("Usted a ingresado " & n & " PULGADA/AS")
                a = n / 12
                Console.WriteLine("convertido en pies " & a)
                b = a / 3
                Console.WriteLine("convertido en yardas " & b)
                c = n * 2.54
                Console.WriteLine("convertido en centimetros " & c)
                d = c / 100
                Console.WriteLine("convertido en metros " & d)
            Case 3
                Console.WriteLine("Usted a ingresado " & n & " YARDA/AS")
                a = n * 3
                Console.WriteLine("convertido en pies " & a)
                b = a * 12
                Console.WriteLine("convertido en pulgadas " & b)
                c = b * 2.54
                Console.WriteLine("convertido en centimetros " & c)
                d = c / 100
                Console.WriteLine("convertido en metros " & d)
            Case 4
                Console.WriteLine("Usted a ingresado " & n & " CENTIMETRO/OS")
                b = n / 2.54
                Console.WriteLine("convertido en pulgadas " & b)
                a = b / 12
                Console.WriteLine("convertido en pies " & a)
                c = a / 3
                Console.WriteLine("convertido en yardas " & c)
                d = n / 100
                Console.WriteLine("convertido en metros " & d)
            Case 5
                Console.WriteLine("Usted a ingresado " & n & " METRO/OS")
                d = n * 100
                Console.WriteLine("convertido en centimetros " & d)
                b = d / 2.54
                Console.WriteLine("convertido en pulgadas " & b)
                a = b / 12
                Console.WriteLine("convertido en pies " & a)
                c = a / 3
                Console.WriteLine("convertido en yardas " & c)

        End Select
    End Sub
End Module
