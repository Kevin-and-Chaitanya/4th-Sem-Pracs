Imports System.Console
Module Module6
    Sub Main()
        Dim A, B, choice As Integer
        WriteLine("Enter A:")
        A = CInt(ReadLine())
        WriteLine("Enter B:")
        B = CInt(ReadLine())
        WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication, 5. Square, 6.Cube")
        choice = CInt(ReadLine())
        If choice = 1 Then
            WriteLine("Ans is {0}", A + B)
        ElseIf choice = 2 Then
            WriteLine("Ans is {0}", A - B)
        ElseIf choice = 3 Then
            WriteLine("Ans is {0}", A / B)
        ElseIf choice = 4 Then
            WriteLine("Ans is {0}", A * B)
        ElseIf choice = 5 Then
            WriteLine("Ans is {0}", A * A)
        Else choice = 6
            WriteLine("Ans is {0}", B * B * B)
        End If
        Read()
    End Sub
End Module
