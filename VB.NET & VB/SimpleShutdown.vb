'To remove the 30s timer, remove the "/t 30s" part.
'

Try
            Shell("shutdown.exe  /s /t 30s")
        Catch ex As Exception
            MsgBox("There was an error trying to shutdown.")
        End Try
