Module Module1

    'This program is calculating the cost of playing a game in which 2 players are must.
    'Charges increase as the no of players exceed from 2.
    'Charges also increase as the no of games exceed from 1.


    Sub Main()
        Dim players As Integer
        Dim charge As Single
        Dim adplayer As Integer              'For determining players greater than 2
        Dim games As Integer


        Console.WriteLine("Input no. of players")
        players = Console.ReadLine()
        Console.WriteLine("Input no. of games to be played by the user")
        games = Console.ReadLine()


        If players = 2 And games = 1 Then
            charge = ((5 * 2) * games)
            Console.WriteLine("Charge is:" & charge)
        ElseIf players > 2 And games = 1 Then
            adplayer = players - 2
            charge = ((5 * 2) * games) + (((5 * 2) + 2) * adplayer * games)
            Console.WriteLine("Charge is:" & charge)
        ElseIf players > 2 And games >= 2 Then
            adplayer = players - 2
            charge = ((5 * 2) * games) + ((5 + 2) * adplayer * games) - ((10 / 100) * (((5 * 2) * games) + ((5 + 2) * adplayer * games)))
            Console.WriteLine("Charge is:" & charge)
        ElseIf players < 2 Then
            Console.WriteLine("Erorr!2 players are must!")

        End If
        Console.ReadKey()
    End Sub

End Module
