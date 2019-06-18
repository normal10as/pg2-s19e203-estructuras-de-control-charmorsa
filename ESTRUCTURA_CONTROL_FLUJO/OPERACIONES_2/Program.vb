Imports System

Module Program
    Enum operacion As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub Main(args As String())
        Dim v1, v2, v3, v4 As Integer
        Dim ope As operacion
        v1 = carga()
        v2 = carga()
        v3 = carga()
        v4 = carga()
        Console.WriteLine("1=suma / 2=resta / 3=multiplicacion / 4=divicion")
        ope = carga()
        Call resultado(ope, v1, v2)
        Call resultado(ope, v1, v2, v3)
        Call resultado(ope, v1, v2, v3, v4)

    End Sub

    Function carga() As Integer
        Console.Write("Ingrese un valor: ")
        Return Console.ReadLine()
    End Function

    Function enumeracion(opcion1 As operacion, valor1 As Integer, valor2 As Integer) As Integer

        Select Case opcion1
            Case operacion.suma
                Return valor1 + valor2
            Case operacion.resta
                Return valor1 - valor2
            Case operacion.multiplicacion
                Return valor1 * valor2
            Case operacion.division
                Return valor1 / valor2
            Case Is > 4
                Return valor1 + valor2
        End Select
    End Function

    Function enumeracion(opcion2 As operacion, valor1 As Integer, valor2 As Integer, valor3 As Integer) As Integer

        Select Case opcion2
            Case operacion.suma
                Return enumeracion(opcion2, valor1, valor2) + valor3
            Case operacion.resta
                Return enumeracion(opcion2, valor1, valor2) - valor3
            Case operacion.multiplicacion
                Return enumeracion(opcion2, valor1, valor2) * valor3
            Case operacion.division
                Return enumeracion(opcion2, valor1, valor2) / valor3
            Case Is > 4
                Return enumeracion(opcion2, valor1, valor2) + valor3
        End Select
    End Function

    Function enumeracion(opcion3 As operacion, valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer) As Integer

        Select Case opcion3
            Case operacion.suma
                Return enumeracion(opcion3, valor1, valor2) + enumeracion(opcion3, valor3, valor4)
            Case operacion.resta
                Return enumeracion(opcion3, valor1, valor2) - enumeracion(opcion3, valor3, valor4)
            Case operacion.multiplicacion
                Return enumeracion(opcion3, valor1, valor2) * enumeracion(opcion3, valor3, valor4)
            Case operacion.division
                Return enumeracion(opcion3, valor1, valor2) / enumeracion(opcion3, valor3, valor4)
            Case Is > 4
                Return enumeracion(opcion3, valor1, valor2) + enumeracion(opcion3, valor3, valor4)
        End Select
    End Function


    Sub resultado(op, val1, val2)
        Console.WriteLine("{0} {1} {2} = {3}", val1, op, val2, enumeracion(op, val1, val2))
    End Sub

    Sub resultado(op, val1, val2, val3)
        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", val1, op, val2, op, val3, enumeracion(op, val1, val2, val3))
    End Sub

    Sub resultado(op, val1, val2, val3, val4)
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} = (7)", val1, op, val2, op, val3, op, val4, enumeracion(op, val1, val2, val3, val4))
    End Sub
End Module
