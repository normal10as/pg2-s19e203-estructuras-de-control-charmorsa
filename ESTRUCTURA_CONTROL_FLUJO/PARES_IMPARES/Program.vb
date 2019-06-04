Imports System

Module Program
    Sub Main(args As String())

        carga()
    End Sub

    Sub carga()
        Dim num, par, contador_par, contador_impar As UShort
        Console.Write(" Ingrese un numero, finaliza la carga en cero '0': ")
        num = Console.ReadLine()
        Do Until (num = 0)
            par = num Mod 2
            If par = 0 Then
                Console.Write("el numero {0} es par ", num)
                contador_par += 1
            Else
                Console.Write("el numero {0} es par ", num)
                contador_impar += 1
            End If
            Console.Write(" Ingrese otro numero, finaliza la carga en cero '0': ")
            num = Console.ReadLine()
        Loop
        Console.WriteLine("cantidad de numeros pares " & contador_par)
        Console.WriteLine("cantidad de numeros impares " & contador_impar)
    End Sub
End Module
