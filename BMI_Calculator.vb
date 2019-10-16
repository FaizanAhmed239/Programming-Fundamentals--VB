Module Module1

    ' This program is A BMI application! It takes 30 inputs, of ID, Weight and Height and calculates the BMI using formula
    ' Messages are also provided Throughout

    Sub Main()
        Dim Id As Integer
        Dim weight As Integer
        Dim height As Integer
        Dim BMI As Integer

        For x = 1 To 30
            Console.WriteLine("Input ID")
            Id = Console.ReadLine()

            Console.WriteLine("Input weight(in kgs)")
            weight = Console.ReadLine()

            Console.WriteLine("Input height(in metres)")
            height = Console.ReadLine()

            BMI = weight / (height * height)
            Console.WriteLine("ID:" & Id)

            If BMI > 25 Then
                Console.WriteLine("Over Weight" &vbNewLine)
            ElseIf BMI < 25 And BMI > 19 Then
                Console.WriteLine("Normal" &vbNewLine)
            ElseIf BMI < 19 Then
                Console.WriteLine("Under Weight" &vbNewLine)
            End If


        Next
        Console.ReadKey()
    End Sub

End Module
