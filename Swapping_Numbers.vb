Module Module1
    ' This program is taking input of two numbers and then swapping them using a "temporary" variable.

    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim T As Integer

        Console.WriteLine("Input the value of A")
        A = Console.ReadLine()
        Console.WriteLine("Input the value of B")
        B = Console.ReadLine()

        If A > B Then                                             'Swapping Conditions
            T = A
            A = B
            B = T

        End If
        Console.WriteLine("The value of A is:" & A)
        Console.WriteLine("The value of B is:" & B)

        Console.ReadKey()
    End Sub

End Module
