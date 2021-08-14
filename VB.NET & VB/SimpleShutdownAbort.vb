'Catch is optional and you can change the catch method too.
Try
            Shell("shutdown /a")
        Catch ex As Exception
            MsgBox("There was an error trying to abort the current shutdown.")
        End Try
