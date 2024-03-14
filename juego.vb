Imports System

Module Program
    Public Class animales
        Private numpatas As Double
        Private numojos As Double
        Private dientes As Double
        Private pelo As Boolean
        Private Nombre As String
        Private comestible As Boolean
        Private vida As Integer




        Public Sub inicializar()
            Console.WriteLine("Cuántas patas tiene?")
            numpatas = Console.ReadLine()
            Console.WriteLine("Cuántos ojos tiene?")
            numojos = Console.ReadLine()
            Console.WriteLine("Cuántas dientes tiene?")
            dientes = Console.ReadLine()
            Console.WriteLine("Tiene pelo?")
            pelo = Console.ReadLine()
            Console.WriteLine("Cómo se llama?")
            Nombre = Console.ReadLine()
            Console.WriteLine("Es comestible?")
            comestible = Console.ReadLine()
            Console.WriteLine("Este animal tiene 100 de vida")
            vida = 100
        End Sub

        Public Sub imprimir()
            Console.WriteLine("Patas:  ")
            Console.WriteLine(numpatas)
            Console.WriteLine("Ojos:  ")
            Console.WriteLine(numojos)
            Console.WriteLine("Dientes:  ")
            Console.WriteLine(dientes)
            Console.WriteLine("Pelo:  ")
            Console.WriteLine(pelo)
            Console.WriteLine("Se llama:  ")
            Console.WriteLine(Nombre)
            Console.WriteLine("Es comestible?:  ")
            Console.WriteLine(comestible)

        End Sub

        Public Sub golpe()
            vida = vida - 10
            Console.WriteLine("Le queda de vida ")
            Console.WriteLine(vida)
        End Sub

        Public Sub posion()
            vida = vida + 50
            Console.WriteLine("Le queda de vida ")
            Console.WriteLine(vida)

        End Sub


    End Class
    Sub Main(args As String())

        Dim kanguro As New animales()
        Dim araña As New animales()
        Dim oso As New animales()
        Dim sapo As New animales()


        kanguro.inicializar()
        kanguro.imprimir()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()

        araña.inicializar()
        araña.imprimir()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()

        oso.inicializar()
        oso.imprimir()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()
        oso.golpe()

        sapo.inicializar()
        sapo.imprimir()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()
        sapo.golpe()







        Console.WriteLine("Hello World!")
    End Sub
End Module
