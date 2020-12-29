Imports System.Console

Module Module5
    Sub Main()
        Dim A, B, C As Integer
        WriteLine(" Enter A:")
        A = CInt(ReadLine())
        WriteLine(" Enter B:")
        B = CInt(ReadLine())
        WriteLine(" Enter C:")
        C = CInt(ReadLine())
        If A > B And A > C Then
            WriteLine(A)
        ElseIf B > C Then
            WriteLine(B)
        Else
            WriteLine(C)

            Read()



        End If

    End Sub
End Module
