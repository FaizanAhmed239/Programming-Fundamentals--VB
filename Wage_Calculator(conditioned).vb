Module Module1
    ' This program calculates gross pay for a provided hours and pay rate
    ' The conditions are:
    ' 1. If working hours are gteater than 20, then rate would be 1.5 of the rate on hours greater than 20.
    ' 2. Simple calculation for hours less than or equal to 20.

    Sub Main()

        Dim Whour As Integer
        Dim payrate As Decimal
        Dim grosspay As Decimal


        Console.WriteLine("Enter Hours Worked:")
        Whour = Console.ReadLine()
        Console.WriteLine("Enter Pay Rate:")
        payrate = Console.ReadLine()

        If Whour <= 20 Then
            grosspay = payrate * Whour
        Else
            grosspay = (payrate * 20) + ((Whour - 20) * payrate * (1.5))
        End If

        Console.WriteLine(" Worked Hour:" & Whour)
        Console.WriteLine(" Pay Rate:" & payrate)
        Console.WriteLine(" Gross Pay:" & grosspay)

        Console.ReadKey()

    End Sub

End Module
