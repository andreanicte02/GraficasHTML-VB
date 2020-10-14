Imports System.IO

Public Class Grafica

    'Andrea Nicte Vicente Campos
    'Para uso de los industriales de la 092 xD
    'chale
    'F si no les gusta 
    'Solo crea archivos html y los js para que se puedan mostrar graficas en html
    'hace uso de la libreria https://cdn.plot.ly/plotly-latest.min.js


    Dim nameFile As String
    Dim title As String
    Dim bufferStringX As New System.Text.StringBuilder
    Dim bufferStringY As New System.Text.StringBuilder
    Dim tipo As Integer = 0



    Public Sub New(nameFile As String, title As String, tipo As Integer)
        Me.nameFile = nameFile
        Me.title = title
        Me.tipo = tipo
        'tipo 1 es barra, tipo 2 es circulo'

    End Sub

    Function test() As Integer
        Dim g As New Grafica("prueba1", "titulo", 1)

        g.setEjes("pespi", "5")
        g.setEjes("coca", "7")
        g.setEjes("pizza", "5")

        Utilis.writeHTML(g.title, g.nameFile)
        Utilis.writeJS(g.tipo, g.bufferStringX, g.bufferStringY, g.nameFile)
        g.openInWIndows()

        Return 1

    End Function



    Public Function setEjes(itemX As String, itemY As String) As Integer

        Me.bufferStringX.Append($"'{itemX}',")
        Me.bufferStringY.Append($"'{itemY}',")


        Return 1
    End Function


    Public Function create() As Integer

        Utilis.writeHTML(Me.title, Me.nameFile)

        Utilis.writeJS(Me.tipo, Me.bufferStringX, Me.bufferStringY, Me.nameFile)

        Return 1


    End Function


    Public Function openInWIndows() As Integer

        Process.Start($"{Me.nameFile}.html")
        Return 1

    End Function


End Class
