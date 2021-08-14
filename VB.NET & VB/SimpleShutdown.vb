'To remove the 30s timer, remove the "/t 30s" part.
'Catch is optional and you can change the catch method too.

Try
            Shell("shutdown.exe  /s /t 30s")
        Catch ex As Exception
            MsgBox("There was an error trying to shutdown.")
        End Try
