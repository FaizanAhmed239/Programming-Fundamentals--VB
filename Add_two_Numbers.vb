Module Module1
    ' This program inputs two number from the user and sums them, providing the result.


    Sub Main()

        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        Console.WriteLine("Enter the Value of Num 1")
        num1 = Console.ReadLine()

        Console.WriteLine("Enter the Value of Num 2")
        num2 = Console.ReadLine()

        total = num1 + num2
        Console.WriteLine("Total is:" & total)

        Console.ReadKey()


    End Sub

End Module
