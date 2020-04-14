Module Module1

    Sub Main()
        Dim dob As DateTime
        Dim fname, lname As String
        Dim correct As Boolean = False
        Dim person1 As New Person

        Console.WriteLine("Enter first name")
        fname = Console.ReadLine()
        Console.WriteLine("Enter last name")
        lname = Console.ReadLine()
        Console.WriteLine("Enter your dob(mm/dd/yyyy)")


        Do
            correct = DateTime.TryParse(Console.ReadLine(), dob)
            If (Not correct) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You entered invalid date...")
            End If

            If (dob >= DateTime.Now) Then
                correct = False
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You entered dob which is in future")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("Enter dob: ")
            End If
        Loop While (Not correct)

        person1.firstnameProperty = fname
        person1.lastnameProperty = lname
        person1.dobProperty = dob
        person1.printDetails()

        Console.ReadKey()

    End Sub

End Module
