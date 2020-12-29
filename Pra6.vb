Imports System.Console


Module Module3
    Sub Main()
        Dim CPP, MALP, DBMS, OS, DS, Total, Percent As Integer
        Dim Name, En As String

        WriteLine("Enter Student Name")
        Name = ReadLine()
        WriteLine()


        WriteLine("Enter En")
        En = ReadLine()
        WriteLine()

        WriteLine("Enter CPP marks")
        CPP = CInt(ReadLine())

        WriteLine("Enter MALP marks")
        MALP = CInt(ReadLine())

        WriteLine("Enter DS marks")
        DS = CInt(ReadLine())

        WriteLine("Enter OS marks")
        OS = CInt(ReadLine())

        WriteLine("Enter DBMS marks")
        DBMS = CInt(ReadLine())
        WriteLine()

        Total = OS + MALP + DS + DBMS + CPP
        WriteLine(Total)

        WriteLine()

        Percent = Total / 5
        WriteLine(Percent)
        WriteLine()

        If Percent > 85 Then
            WriteLine("AA")
        ElseIf Percent >= 75 And Percent <= 85 Then
            WriteLine("AB")
        ElseIf Percent >= 65 And Percent <= 75 Then
            WriteLine("BB")
        ElseIf Percent >= 55 And Percent <= 65 Then
            WriteLine("BC")
        ElseIf Percent >= 45 And Percent <= 55 Then
            WriteLine("CC")
        ElseIf Percent >= 40 And Percent <= 45 Then
            WriteLine("CD")
        ElseIf Percent >= 35 And Percent <= 40 Then
            WriteLine("DD")
        Else
            WriteLine("FF")
        End If

        Read()



    End Sub

End Module
