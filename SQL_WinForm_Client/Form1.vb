Public Class Form1

    Dim Command = New ServiceReference1.SQLServiceClient
    Dim SQLCommand As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        RichTextBox1.Text = Command.GetData(TextBox1.Text)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQLCommand = "SELECT Serial, ModelName FROM TestDB.dbo.TestTable"
        TextBox1.Text = SQLCommand
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SQLCommand = "SELECT Count (Serial) FROM TestDB.dbo.TestTable "
        SQLCommand += "WHERE Serial='231'"
        TextBox1.Text = SQLCommand

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SQLCommand = "INSERT INTO TestDB.dbo.TestTable (Serial,ModelName,CycleStartTmp,CycleEndTemp,Cycletime) "
        SQLCommand += "Values (" & "3456" & ",2,3,4,5) "
        TextBox1.Text = SQLCommand

    End Sub
End Class
