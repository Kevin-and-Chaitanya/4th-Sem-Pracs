Imports System.Console
Module Module4
    Sub Main()
        Dim Month As Integer
        WriteLine("Enter No")

        Month = CInt(ReadLine())
        Select Case Month
            Case 1
                WriteLine("January")
            Case 2
                WriteLine("February")
            Case 3
                WriteLine("March")
            Case 4
                WriteLine("April")
            Case 5
                WriteLine("May")
            Case 6
                WriteLine("June")
            Case 7
                WriteLine("July")
            Case 8
                WriteLine("August")
            Case 9
                WriteLine("September")
            Case 10
                WriteLine("October")
            Case 11
                WriteLine("November")
            Case 12
                WriteLine("December")
            Case Else
                WriteLine("Wrong Input!!")
        End Select
        Read()
    End Sub
End Module
