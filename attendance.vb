Imports System.Windows.Forms

Public Class attendance

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = 1 Then
            Label2.Visible = True
            DateTimePicker1.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
        End If

        If ComboBox1.SelectedItem = 2 Then

            DateTimePicker2.Visible = True
            Label24.Visible = True
            Label20.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            DateTimePicker2.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True

        End If

        If ComboBox1.SelectedItem = 3 Then
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            DateTimePicker3.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main()
        If ComboBox1.SelectedItem = 1 Then
            cmd.CommandText = "select * from stdattendance1 where stdid='" & Trim(Me.TextBox1.Text) & "' and Date='" & Trim(Me.DateTimePicker1.Text) & "' and Maths='" & Trim(Me.TextBox2.Text) & "' and Cprogramming='" & Trim(Me.TextBox3.Text) & "' and Chemistry='" & Trim(Me.TextBox4.Text) & "' and Electronics='" & Trim(Me.TextBox5.Text) & "' and Environmental='" & Trim(Me.TextBox6.Text) & "' and  English='" & Trim(Me.TextBox7.Text) & "'"
            cmd.Connection = conn
            ds.Tables.Clear()
            adp.SelectCommand = cmd
            adp.Fill(ds, "tbl")
            If (ds.Tables("tbl").Rows.Count > 0) Then
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                Exit Sub
            End If

            cmd.CommandText = "insert into stdattendance1(stdid,Date,Maths,Cprogramming,Chemistry,Electronics,Environmental,English)values('" & Trim(Me.TextBox1.Text) & "','" & Trim(Me.DateTimePicker1.Text) & "','" & Trim(Me.TextBox2.Text) & "','" & Trim(Me.TextBox3.Text) & "','" & Trim(Me.TextBox4.Text) & "','" & Trim(Me.TextBox5.Text) & "','" & Trim(Me.TextBox6.Text) & "','" & Trim(Me.TextBox7.Text) & "')"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Record Successfully Saved for 1st semester!!", MsgBoxStyle.Information, "GRAPHIC ERA")
            Dim frm = New attendance              'Clear Form' Change the class name if necessary
            frm.Show()
            Me.Close()
            Me.TextBox1.Focus()
        End If

        If ComboBox1.SelectedItem = 2 Then
            cmd.CommandText = "select * from stdattendance2 where stdid='" & Trim(Me.TextBox1.Text) & "' and Date='" & Trim(Me.DateTimePicker2.Text) & "' and Cprogramming='" & Trim(Me.TextBox9.Text) & "' and Maths='" & Trim(Me.TextBox10.Text) & "' and Physics='" & Trim(Me.TextBox11.Text) & "' and Electrical='" & Trim(Me.TextBox12.Text) & "' and HealthPED='" & Trim(Me.TextBox13.Text) & "' and  English='" & Trim(Me.TextBox14.Text) & "'"
            cmd.Connection = conn
            ds.Tables.Clear()
            adp.SelectCommand = cmd
            adp.Fill(ds, "tbl")
            If (ds.Tables("tbl").Rows.Count > 0) Then
                TextBox1.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                Exit Sub
            End If

            cmd.CommandText = "insert into stdattendance2(stdid,Date,Cprogramming,Maths,Physics,Electrical,HealthPED,English)values('" & Trim(Me.TextBox1.Text) & "','" & Trim(Me.DateTimePicker2.Text) & "','" & Trim(Me.TextBox9.Text) & "','" & Trim(Me.TextBox10.Text) & "','" & Trim(Me.TextBox11.Text) & "','" & Trim(Me.TextBox12.Text) & "','" & Trim(Me.TextBox13.Text) & "','" & Trim(Me.TextBox14.Text) & "')"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Record Successfully Saved for 2nd semester!!", MsgBoxStyle.Information, "GRAPHIC ERA")
            Dim frm = New attendance              'Clear Form' Change the class name if necessary
            frm.Show()
            Me.Close()
            Me.TextBox1.Focus()
        End If

        If ComboBox1.SelectedItem = 3 Then
            cmd.CommandText = "select * from stdattendance3 where stdid='" & Trim(Me.TextBox1.Text) & "' and Date='" & Trim(Me.DateTimePicker3.Text) & "' and Logicdesign='" & Trim(Me.TextBox15.Text) & "' and DS='" & Trim(Me.TextBox16.Text) & "' and CPP='" & Trim(Me.TextBox17.Text) & "' and Maths='" & Trim(Me.TextBox18.Text) & "' and CareerSkills='" & Trim(Me.TextBox19.Text) & "' and  Software='" & Trim(Me.TextBox20.Text) & "'"
            cmd.Connection = conn
            ds.Tables.Clear()
            adp.SelectCommand = cmd
            adp.Fill(ds, "tbl")
            If (ds.Tables("tbl").Rows.Count > 0) Then
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
                Exit Sub
            End If

            cmd.CommandText = "insert into stdattendance3(stdid,Date,Logicdesign,DS,CPP,Maths,CareerSkills,Software)values('" & Trim(Me.TextBox1.Text) & "','" & Trim(Me.DateTimePicker3.Text) & "','" & Trim(Me.TextBox15.Text) & "','" & Trim(Me.TextBox16.Text) & "','" & Trim(Me.TextBox17.Text) & "','" & Trim(Me.TextBox18.Text) & "','" & Trim(Me.TextBox19.Text) & "','" & Trim(Me.TextBox20.Text) & "')"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Record Successfully Saved for 3rd semester!!", MsgBoxStyle.Information, "GRAPHIC ERA")
            Dim frm = New attendance              'Clear Form' Change the class name if necessary
            frm.Show()
            Me.Close()
            Me.TextBox1.Focus()
        End If

        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("SELECT SEMESTER FIRST!!", MsgBoxStyle.Critical, "SECURITY")

        End If


    End Sub
End Class
