Module DBModule
    Public cn As SqlConnection
    Public filepath As FileInfo
    'Public mf As MainForm ' Global variables
    Public sf As SplashForm
    Public lf As LoginForm
    Public mf As mainForm
    Public mf1 As MainForm2
    Public username As String
    Public password As String
    Public RegNo As String
    Public passingtotal As String
    Public subjid As String
    Public Const title As String = "Entrance Exam System"
    ' Connect to SQL Server and attach givent Database
    Sub ConnectToDB()
        cn = New SqlConnection()
        filepath = New FileInfo("../../Database/projDB.mdf")
        ' MsgBox(filepath.FullName)
        cn.ConnectionString = "Server=.\sqlexpress;AttachDBFileName=" & filepath.FullName & ";Integrated Security=true;User Instance=true"
        ' MsgBox(cn.ConnectionString)
        cn.Open()
    End Sub
    Sub Disconnect()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub
    Sub DisplayInfo(ByVal msg As String)
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub displayWarning(ByVal msg As String)
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Function confirm(ByVal msg As String)
        Dim d As DialogResult = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return d
    End Function
    Function GetTable(ByVal sql As String) As DataTable
        Dim da As New SqlDataAdapter(sql, cn)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function
    Function ExecuteCommand(ByVal sql As String) As Integer
        Dim cmd As New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteNonQuery()
        Return i
    End Function

    Function ExecuteCommand(ByVal sql As String, ByVal msg As String) As Integer
        On Error GoTo xxx
        Dim cmd As New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteNonQuery()
        DisplayInfo(msg)
        Return i
xxx:
    End Function
    Sub FillListView(ByVal lv As ListView, ByVal sql As String)
        On Error GoTo xxx
        Dim da As New SqlDataAdapter(sql, cn)
        Dim dt As New DataTable()
        da.Fill(dt)
        Dim nc As Integer = lv.Columns.Count
        'remove previous all items
        lv.Items.Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim lt As New ListViewItem()
            lt.Text = dt.Rows(i)(0).ToString()

            For j = 1 To nc - 1
                lt.SubItems.Add(IIf(IsDBNull(dt(i)(j)), "", dt.Rows(i)(j).ToString()))
            Next

            lv.Items.Add(lt)
        Next
        Return
xxx:
        MsgBox(Err.Description)
    End Sub
    Sub FillListBox(ByVal lt As ListBox, ByVal sql As String, ByVal displayfield As String, ByVal valuefield As String)
        Dim dt As DataTable = GetTable(sql)
        lt.DataSource = dt
        lt.DisplayMember = displayfield
        lt.ValueMember = valuefield
    End Sub
    Sub FillCombo(ByVal cmb As ComboBox, ByVal sql As String, ByVal displayfield As String, ByVal valuefield As String)
        Dim dt As DataTable = GetTable(sql)
        cmb.DataSource = dt
        cmb.DisplayMember = displayfield
        cmb.ValueMember = valuefield
    End Sub
End Module
