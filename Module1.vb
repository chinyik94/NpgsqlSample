Module Module1

    Sub Main()
        Using context As New C4WX1Entities
            Dim errorLog As New ErrorLog

            errorLog.ErrorDetails = "Test Error"
            errorLog.DateCreated = Now()
            context.ErrorLog.Add(errorLog)

            context.SaveChanges()
        End Using
    End Sub

End Module
