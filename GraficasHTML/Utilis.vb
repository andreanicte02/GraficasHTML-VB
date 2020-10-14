Imports System.IO

Module Utilis

    Public Function writeHTML(title As String, nameFile As String) As Integer

        Dim bufferString As New System.Text.StringBuilder
        bufferString.Append($"<!DOCTYPE html> {vbCrLf}")
        bufferString.Append($"<head> {title} </head> {vbCrLf}")
        bufferString.Append($"<body> {vbCrLf}")
        bufferString.Append($"<div id='{nameFile}'> </div> {vbCrLf} ")
        bufferString.Append($"<script src='https://cdn.plot.ly/plotly-latest.min.js'></script> {vbCrLf}")
        bufferString.Append($"<script src='{nameFile}.js'></script> {vbCrLf} ")
        bufferString.Append($"</body>{vbCrLf}")
        bufferString.Append($"</html>{vbCrLf}")

        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter($"{nameFile}.html")
        objStreamWriter.WriteLine(bufferString)
        objStreamWriter.Close()


        Return 1
    End Function


    Public Function writeJS(type As Integer, bufferStringX As System.Text.StringBuilder, bufferStringY As System.Text.StringBuilder, nameFile As String) As Integer

        Dim n1 As String = ""
        Dim n2 As String = ""
        Dim label As String = ""
        If (type = 1) Then
            'es barra'
            label = "bar"
            n1 = "x"
            n2 = "y"

        ElseIf type = 2 Then

            label = "pie"
            n1 = "labels"
            n2 = "values"

        Else
            Return 0


        End If




        Dim bufferString As New System.Text.StringBuilder
        bufferString.Append($"var data = [{vbCrLf}")
        bufferString.Append($"{"{"} {vbCrLf}")
        bufferString.Append($"{n1}: [{bufferStringX.ToString}],{vbCrLf}")
        bufferString.Append($"{n2}: [{bufferStringY.ToString}],{vbCrLf}")
        bufferString.Append($"type: '{label}' {vbCrLf}")
        bufferString.Append("}" + vbCrLf)
        bufferString.Append($"]; {vbCrLf}")
        bufferString.Append($"Plotly.newPlot('{nameFile}', data);")

        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter($"{nameFile}.js")
        objStreamWriter.WriteLine(bufferString)
        objStreamWriter.Close()

        Return 1

    End Function

End Module
