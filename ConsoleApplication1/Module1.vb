Module Module1

    Sub Main(args As String())
        Dim ancho, longitud, metrocuadrado As Integer
        Dim datos As Decimal



        metrocuadrado = 5000
        Console.WriteLine("EL METRO CUADRADO DEL TERRENO VALE: " & metrocuadrado)


        Console.Write("ingresa el ancho del terreno: ")
        ancho = Console.ReadLine()
        Console.Write("ingresa la longitud del terreno: ")
        longitud = Console.ReadLine()

        datos = ancho * longitud * metrocuadrado


        Console.Write("Costo del terreno: " & datos)

        Console.ReadLine()











    End Sub

End Module
