Module Module1

    'This program takes 5000 codes from the user and validates if the code exists in the rack of CD, DVD, Videos or Books.
    'It determines the no of items existing within a range! 

    Sub Main()
        Dim code As Integer
        Dim DVD As Integer
        Dim CD As Integer
        Dim video As Integer
        Dim books As Integer
        Dim total As Integer

        For i = 1 To 5000 Step 1000

            Console.WriteLine("Input code")
            code = Console.ReadLine()
            If code >= 10000 And code < 20000 Then
                CD = CD + 1
            ElseIf code >= 20000 And code < 30000 Then
                DVD = DVD + 1
            ElseIf code >= 30000 And code < 40000 Then
                video = video + 1
            ElseIf code >= 40000 And code < 50000 Then
                books = books + 1
            ElseIf code < 10000 And code > 50000 Then
                Console.WriteLine("Item number is wrong")
            End If
        Next

        total = CD + DVD + video + books
        Console.WriteLine("Total no. of CDs is:" & CD)
        Console.WriteLine("Total no. of DVDs is:" & DVD)
        Console.WriteLine("Total no. of Videos is:" & video)
        Console.WriteLine("Total no. of books is:" & books)
        Console.ReadKey()


    End Sub

End Module
