Imports System.Data.SqlClient


Public Class Form1
    Public StringName(10) As String
    Public EM_U(1000) As Integer
    Public MR_B(1000) As Boolean
    Public EM_S As String


    Public Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Run As Boolean = 1

        While Run = True
            Try
                ' TRANSFER DATA
                For index = 1 To 10
                    EM_U(index) = AxDBCommManager1.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, index)
                    MR_B(index) = AxDBCommManager1.ReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, index)

                Next

                AxDBCommManager1.ReadText(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 2000, 100, EM_S)

            Catch ex As Exception
                StringName(0) = "NOT CONNECTED"
                StringName(1) = ""
                Run = 0
                BackgroundWorker1.CancelAsync()
            End Try
        End While
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            AxDBCommManager1.Connect()

            If AxDBCommManager1.GetMode() = True Then
                StringName(0) = "CONNECTED"
                StringName(1) = "RUN MODE"
            Else
                StringName(0) = "CONNECTED"
                StringName(1) = "PROGRAM MODE"
            End If

            If BackgroundWorker1.IsBusy = False Then
                BackgroundWorker1.RunWorkerAsync()
                Timer1.Start()
                TmrSQL_CheckUsage.Start()
                TmrSQL_Update.Start()
            End If
        Catch ex As Exception
            MsgBox("Cannot connect to PLC, Please check that communication is selcted correctly")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_MC_Status.Text = StringName(0)
        Label2.Text = StringName(1)
        TextBox1.Text = EM_U(1)
        TextBox5.Text = EM_U(2)
        TextBox7.Text = EM_U(3)
        TextBox9.Text = EM_U(4)
        TextBox2.Text = EM_S
        TextBox11.Text = EM_S
        TextBox12.Text = EM_U(9)
        TextBox13.Text = EM_U(10)
        RadioButton1.Checked = MR_B(1)
        RadioButton8.Checked = MR_B(1)
        RadioButton2.Checked = MR_B(2)
        RadioButton9.Checked = MR_B(2)
        RadioButton3.Checked = MR_B(3)
        RadioButton4.Checked = MR_B(4)
        RadioButton5.Checked = MR_B(5)
        RadioButton6.Checked = MR_B(6)
        RadioButton7.Checked = MR_B(7)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 1)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 3, 1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 3, 0)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 4, 1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 4, 0)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 5, 1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 5, 0)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 6, 1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 6, 0)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 7, 1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 7, 0)
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 1, TextBox3.Text)
        Catch ex As Exception
            MsgBox("Wrong Data Format")
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Try
            AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 2, TextBox4.Text)
        Catch ex As Exception
            MsgBox("Wrong Data Format")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Try
            AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 3, TextBox6.Text)
        Catch ex As Exception
            MsgBox("Wrong Data Format")
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Try
            AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 4, TextBox8.Text)
        Catch ex As Exception
            MsgBox("Wrong Data Format")
        End Try
    End Sub



    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            AxDBCommManager1.WriteText(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 2000, 100, TextBox10.Text)
        Catch ex As Exception
            MsgBox("Wrong Data Format")
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim results As String = ""
        RichTextBox1.Text = ""
        Try
            '------------Create a Connection object
            myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
            '------------Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT ToolUsageCount FROM [StampDept].[dbo].[Toolusage] WHERE ToolBarcode='" & TextBox11.Text & "'"
            '------------Open the connection.
            myConn.Open()
            '------------Call the Reading Procedure
            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            Dim Value1 As Int64

            Value1 = myReader.FieldCount

            If Value1 > 0 Then

                If myReader.Read() Then

                    Select Case myReader.GetFieldType(0).ToString

                        Case "System.String"
                            results = results & myReader.GetString(0)
                            RichTextBox1.Text = results
                        Case "System.Int32"
                            results = results & myReader.GetInt32(0).ToString
                            RichTextBox1.Text = results
                    End Select

                    Do While myReader.Read()

                        For i As Integer = 1 To Value1
                            If i = 1 Then

                                Select Case myReader.GetFieldType(i).ToString

                                    Case "System.String"
                                        results = results & myReader.GetString(i)
                                    Case "System.Int32"
                                        results = results & myReader.GetInt32(i).ToString
                                End Select

                            Else

                                Select Case myReader.GetFieldType(i).ToString

                                    Case "System.String"
                                        results = results & vbTab & myReader.GetString(i)
                                    Case "System.Int32"
                                        results = results & vbTab & myReader.GetString(i)
                                End Select
                            End If
                        Next

                        results = results & vbLf
                        RichTextBox1.Text = results

                    Loop
                Else
                    results = 0
                    RichTextBox1.Text = results
                End If
            Else
                results = myReader.RecordsAffected().ToString
                RichTextBox1.Text = results
            End If



            myReader.Close()
            myConn.Close()
            Try
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 9, results)
            Catch ex As Exception
                MsgBox("Wrong Data Format")
            End Try


        Catch ex As Exception
            results = ex.Message
            RichTextBox1.Text = results
        End Try


    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim results As String = ""
        RichTextBox1.Text = ""
        Try
            '------------Create a Connection object
            myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
            '------------Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "BEGIN
   IF NOT EXISTS (SELECT  ToolBarcode FROM [StampDept].[dbo].[Toolusage] 
                   WHERE ToolBarcode = '" & TextBox11.Text & "')
	   BEGIN
			INSERT INTO StampDept.dbo.Toolusage (ToolBarcode,ToolUsageCount,LastUpdateTime) 
			Values ('" & TextBox11.Text & "', + 1,CURRENT_TIMESTAMP)
			PRINT 'INSERTED'
	   END

    ELSE
    
	   BEGIN
			UPDATE StampDept.dbo.Toolusage  
			SET ToolUsageCount = ToolUsageCount + 1,LastUpdateTime = CURRENT_TIMESTAMP
			WHERE ToolBarcode = '" & TextBox11.Text & "'
				SELECT ToolUsageCount FROM [StampDept].[dbo].[Toolusage] 
				WHERE ToolBarcode='" & TextBox11.Text & "'
			
	   END
END"

            '------------Open the connection.
            myConn.Open()
            '------------Call the Reading Procedure
            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            Dim Value1 As Int64

            Value1 = myReader.FieldCount

            If Value1 > 0 Then

                If myReader.Read() Then

                    Select Case myReader.GetFieldType(0).ToString

                        Case "System.String"
                            results = results & myReader.GetString(0)
                            RichTextBox1.Text = results
                        Case "System.Int32"
                            results = results & myReader.GetInt32(0).ToString
                            RichTextBox1.Text = results
                    End Select

                    Do While myReader.Read()

                        For i As Integer = 1 To Value1
                            If i = 1 Then

                                Select Case myReader.GetFieldType(i).ToString

                                    Case "System.String"
                                        results = results & myReader.GetString(i)
                                    Case "System.Int32"
                                        results = results & myReader.GetInt32(i).ToString
                                End Select

                            Else

                                Select Case myReader.GetFieldType(i).ToString

                                    Case "System.String"
                                        results = results & vbTab & myReader.GetString(i)
                                    Case "System.Int32"
                                        results = results & vbTab & myReader.GetString(i)
                                End Select
                            End If
                        Next

                        results = results & vbLf
                        RichTextBox1.Text = results

                    Loop
                Else
                    results = "No Data"
                    RichTextBox1.Text = results
                End If
            Else
                results = "Records Affected :" + myReader.RecordsAffected().ToString
                RichTextBox1.Text = results
            End If



            myReader.Close()
            myConn.Close()
            Try
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 10, results)
            Catch ex As Exception
                MsgBox("Wrong Data Format")
            End Try

        Catch ex As Exception
            results = ex.Message
            RichTextBox1.Text = results
        End Try
    End Sub

    Private Sub TmrSQL_CheckUsage_Tick(sender As Object, e As EventArgs) Handles TmrSQL_CheckUsage.Tick
        If MR_B(1) = True Then
            Dim myConn As SqlConnection
            Dim myCmd As SqlCommand
            Dim myReader As SqlDataReader
            Dim results As String = ""
            RichTextBox1.Text = ""
            Try
                '------------Create a Connection object
                myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
                '------------Create a Command object.
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "SELECT ToolUsageCount FROM [StampDept].[dbo].[Toolusage] WHERE ToolBarcode='" & TextBox11.Text & "'"
                '------------Open the connection.
                myConn.Open()
                '------------Call the Reading Procedure
                myReader = myCmd.ExecuteReader()
                'Concatenate the query result into a string.
                Dim Value1 As Int64

                Value1 = myReader.FieldCount

                If Value1 > 0 Then

                    If myReader.Read() Then

                        Select Case myReader.GetFieldType(0).ToString

                            Case "System.String"
                                results = results & myReader.GetString(0)
                                RichTextBox1.Text = results
                            Case "System.Int32"
                                results = results & myReader.GetInt32(0).ToString
                                RichTextBox1.Text = results
                        End Select

                        Do While myReader.Read()

                            For i As Integer = 1 To Value1
                                If i = 1 Then

                                    Select Case myReader.GetFieldType(i).ToString

                                        Case "System.String"
                                            results = results & myReader.GetString(i)
                                        Case "System.Int32"
                                            results = results & myReader.GetInt32(i).ToString
                                    End Select

                                Else

                                    Select Case myReader.GetFieldType(i).ToString

                                        Case "System.String"
                                            results = results & vbTab & myReader.GetString(i)
                                        Case "System.Int32"
                                            results = results & vbTab & myReader.GetString(i)
                                    End Select
                                End If
                            Next

                            results = results & vbLf
                            RichTextBox1.Text = results

                        Loop
                    Else
                        results = 0
                        RichTextBox1.Text = results
                    End If
                Else
                    results = "Records Affected :" + myReader.RecordsAffected().ToString
                    RichTextBox1.Text = results
                End If



                myReader.Close()
                myConn.Close()
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 0)
                Try
                    AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 9, results)
                Catch ex As Exception
                    MsgBox("Wrong Data Format")
                End Try

            Catch ex As Exception
                results = ex.Message
                RichTextBox1.Text = results
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 0)
            End Try
        End If
    End Sub

    Private Sub TmrSQL_Update_Tick(sender As Object, e As EventArgs) Handles TmrSQL_Update.Tick
        If MR_B(2) = True Then
            Dim myConn As SqlConnection
            Dim myCmd As SqlCommand
            Dim myReader As SqlDataReader
            Dim results As String = ""
            RichTextBox1.Text = ""
            Try
                '------------Create a Connection object
                myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
                '------------Create a Command object.
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "BEGIN
   IF NOT EXISTS (SELECT  ToolBarcode FROM [StampDept].[dbo].[Toolusage] 
                   WHERE ToolBarcode = '" & TextBox11.Text & "')
	   BEGIN
			INSERT INTO StampDept.dbo.Toolusage (ToolBarcode,ToolUsageCount,LastUpdateTime) 
			Values ('" & TextBox11.Text & "', + 1,CURRENT_TIMESTAMP)
			PRINT 'INSERTED'
	   END

    ELSE
    
	   BEGIN
			UPDATE StampDept.dbo.Toolusage  
			SET ToolUsageCount = ToolUsageCount + 1,LastUpdateTime = CURRENT_TIMESTAMP
			WHERE ToolBarcode = '" & TextBox11.Text & "'
				SELECT ToolUsageCount FROM [StampDept].[dbo].[Toolusage] 
				WHERE ToolBarcode='" & TextBox11.Text & "'
			
	   END
END"

                '------------Open the connection.
                myConn.Open()
                '------------Call the Reading Procedure
                myReader = myCmd.ExecuteReader()
                'Concatenate the query result into a string.
                Dim Value1 As Int64

                Value1 = myReader.FieldCount

                If Value1 > 0 Then

                    If myReader.Read() Then

                        Select Case myReader.GetFieldType(0).ToString

                            Case "System.String"
                                results = results & myReader.GetString(0)
                                RichTextBox1.Text = results
                            Case "System.Int32"
                                results = results & myReader.GetInt32(0).ToString
                                RichTextBox1.Text = results
                        End Select

                        Do While myReader.Read()

                            For i As Integer = 1 To Value1
                                If i = 1 Then

                                    Select Case myReader.GetFieldType(i).ToString

                                        Case "System.String"
                                            results = results & myReader.GetString(i)
                                        Case "System.Int32"
                                            results = results & myReader.GetInt32(i).ToString
                                    End Select

                                Else

                                    Select Case myReader.GetFieldType(i).ToString

                                        Case "System.String"
                                            results = results & vbTab & myReader.GetString(i)
                                        Case "System.Int32"
                                            results = results & vbTab & myReader.GetString(i)
                                    End Select
                                End If
                            Next

                            results = results & vbLf
                            RichTextBox1.Text = results

                        Loop
                    Else
                        results = "No Data"
                        RichTextBox1.Text = results
                    End If
                Else
                    results = myReader.RecordsAffected().ToString
                    RichTextBox1.Text = results
                End If



                myReader.Close()
                myConn.Close()
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 0)
                Try
                    AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM, 10, results)
                Catch ex As Exception
                    MsgBox("Wrong Data Format")
                End Try
            Catch ex As Exception
                results = ex.Message
                RichTextBox1.Text = results
                AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 0)
            End Try
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 1)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 1, 0)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 1)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        AxDBCommManager1.WriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_MR, 2, 0)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StampDeptDataSet.Toolusage' table. You can move, or remove it, as needed.
        Me.ToolusageTableAdapter.Fill(Me.StampDeptDataSet.Toolusage)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'TODO: This line of code loads data into the 'StampDeptDataSet.Toolusage' table. You can move, or remove it, as needed.
        Me.ToolusageTableAdapter.Fill(Me.StampDeptDataSet.Toolusage)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.ToolusageTableAdapter.Update(Me.StampDeptDataSet.Toolusage)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        AxDBCommManager1.ShowPropertyPages()
    End Sub


    Private Sub ToolStripComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripComboBox1.KeyDown
        If ToolStripComboBox1.Text <> "" And e.KeyCode = Keys.Return Then
            Me.StampDeptDataSet.Toolusage.DefaultView.RowFilter = "ToolBarCode = '" & ToolStripComboBox1.Text & "'"
        Else
            Me.StampDeptDataSet.Toolusage.DefaultView.RowFilter = ""
        End If
        'Me.ToolusageTableAdapter.Fill(Me.StampDeptDataSet.Toolusage.DefaultView.Table)
        DataGridView1.DataSource = Me.StampDeptDataSet.Toolusage.DefaultView
    End Sub

    Private Sub TmrToolbarcodeUpdate_Tick(sender As Object, e As EventArgs) Handles TmrToolbarcodeUpdate.Tick

        txtToolBarCodeCount.Text = ToolusageTableAdapter.GetToolUsageCount(txtToolBarCode.Text)


    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim rowTop = 100



        e.Graphics.DrawString("ID",
                             Me.Font, Brushes.Black, New Point(100, rowTop))

        e.Graphics.DrawString("ToolBarcode",
                             Me.Font, Brushes.Black, New Point(200, rowTop))

        e.Graphics.DrawString("ToolUsageCount",
                             Me.Font, Brushes.Black, New Point(300, rowTop))

        e.Graphics.DrawString("LastUpdateTime",
                             Me.Font, Brushes.Black, New Point(400, rowTop))

        rowTop += 40

        e.Graphics.DrawLine(Pens.Black, 100, 120, 600, 120)

        For Each row As DataRow In Me.StampDeptDataSet.Toolusage.Rows

            e.Graphics.DrawString(row("ID"),
                             Me.Font, Brushes.Black, New Point(100, rowTop))

            e.Graphics.DrawString(row("ToolBarcode"),
                             Me.Font, Brushes.Black, New Point(200, rowTop))

            e.Graphics.DrawString(row("ToolUsageCount"),
                             Me.Font, Brushes.Black, New Point(300, rowTop))

            e.Graphics.DrawString(row("LastUpdateTime"),
                             Me.Font, Brushes.Black, New Point(400, rowTop))


            rowTop += 25
        Next



    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'PrintPreviewDialog1.ShowDialog()
        ViewReport.Show()
    End Sub
End Class
