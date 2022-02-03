Module Module1

    Sub Main()
        System.Console.WriteLine("Ingrese una frase:")
        Dim str As String = System.Console.ReadLine()
        System.Console.WriteLine(Environment.NewLine)

        System.Console.WriteLine("Resultado")
        System.Console.WriteLine(ReverseCase(str))
        System.Console.ReadLine()

    End Sub

    Public Function ReverseCase(strPhrase As String) As String
        Dim words = strPhrase.Split(" ")

        For index = 0 To words.Length - 1
            If Not String.IsNullOrEmpty(words(index)) Then
                words(index) = words(index).First().ToString().ToLower() + words(index).Substring(1).ToUpper
            End If
        Next

        Return String.Join(" ", words)
    End Function

End Module

