Public Class Class1
    Public Shared Function LongDate(AnyDate As Date) As String
        Dim Suffix As String
        Select Case Day(AnyDate)
            Case 1, 21, 31
                Suffix = "st"
            Case 2, 22
                Suffix = "nd"
            Case 3, 23
                Suffix = "rd"
            Case Else
                Suffix = "th"
        End Select

        Return Format(AnyDate, "dddd d") & Suffix & Format(AnyDate, " MMMM yyyy")
    End Function
End Class
