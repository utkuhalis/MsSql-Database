Imports System.Data.SqlClient
Public Class Form1
    Dim connect As New SqlConnection("database=DB;Data Source=UTKU\SQLEXPRESS;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim rdr As SqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserID.Clear()
        UserPW.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserID.Text = "" Or UserPW.Text = "" Then
            MsgBox("Kutuları boş bırakmayın lütfen", MsgBoxStyle.Information, Me.Text)
        Else
            UserID.Enabled = False
            UserPW.Enabled = False
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                cmd.CommandText = "Select * from Users Where uid=@uid and password=@password"
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar).Value = UserID.Text
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = UserPW.Text
                rdr = cmd.ExecuteReader()
                If rdr.HasRows() Then
                    connect.Close()
                    ChangeForm()
                Else
                    MsgBox("Yanlış bilgi girildi", MsgBoxStyle.Information, Me.Text)
                    UserID.Enabled = True
                    UserPW.Enabled = True
                End If
            End If
        End If

    End Sub

    Sub ChangeForm()
        Me.MaximumSize = New Size(800, 500)
        Me.Text = "MainForm"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
            ds.Clear()
            cmd.Parameters.Clear()
            cmd.Connection = connect
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From Product"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            ComboBox1.Items.Clear()
            For Each item As DataGridViewColumn In DataGridView1.Columns
                ComboBox1.Items.Add(item.Name)
            Next
            connect.Close()
        End If
        Timer1.Start()
        Login.Visible = False
        Login.Enabled = False
        MainForm.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Width = 800 And Me.Height = 500 Then
            Timer1.Stop()
            MainForm.Enabled = True
        Else
            If Not Me.Width = 800 Then
                Me.Width += 2
            End If

            If Not Me.Height = 500 Then
                Me.Height += 2
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Text = "Login"
        Timer2.Start()
        MainForm.Visible = False
        MainForm.Enabled = False
        Login.Visible = True
        UserID.Enabled = True
        UserPW.Enabled = True
        Button2.PerformClick()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Width = 400 And Me.Height = 400 Then
            Timer2.Stop()
            Login.Enabled = True
        Else
            If Not Me.Width = 400 Then
                Me.Width -= 2
            End If

            If Not Me.Height = 400 Then
                Me.Height -= 2
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not TextBox2.Text = "" And Not ComboBox1.Text = "" Then
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From Product Where " & ComboBox1.Text & " = @value"
                cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = TextBox2.Text
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                ComboBox1.Items.Clear()
                For Each item As DataGridViewColumn In DataGridView1.Columns
                    ComboBox1.Items.Add(item.Name)
                Next
                connect.Close()
            End If
        Else
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From Product"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                ComboBox1.Items.Clear()
                For Each item As DataGridViewColumn In DataGridView1.Columns
                    ComboBox1.Items.Add(item.Name)
                Next
                connect.Close()
            End If
            MsgBox("Lütfen boş alan bırakmayınız", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProductAdd.Enabled = True
        ProductAdd.Visible = True
        ProductInfo.Visible = False
        ProductInfo.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Bu ürünü silmek istediğinizden emin misiniz?", MsgBoxStyle.YesNo, Me.Text) = DialogResult.Yes Then
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Delete Product Where ID=@ID"
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Label7.Text
                cmd.ExecuteNonQuery()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From Product"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                ComboBox1.Items.Clear()
                For Each item As DataGridViewColumn In DataGridView1.Columns
                    ComboBox1.Items.Add(item.Name)
                Next
                connect.Close()
                MsgBox("Başarıyla silindi", MsgBoxStyle.Information, Me.Text)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(400, 400)
        Me.MaximumSize = New Size(400, 400)
        Me.MinimumSize = New Size(400, 400)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim Srow As Integer = DataGridView1.CurrentCell.RowIndex
            Dim Scolumn As Integer = DataGridView1.CurrentCell.ColumnIndex
            Label7.Text = DataGridView1.Rows(Srow).Cells(0).Value
            TextBox1.Text = DataGridView1.Rows(Srow).Cells(1).Value
            TextBox8.Text = DataGridView1.Rows(Srow).Cells(2).Value
            TextBox3.Text = DataGridView1.Rows(Srow).Cells(3).Value
            TextBox4.Text = DataGridView1.Rows(Srow).Cells(4).Value
        End If
        ProductInfo.Visible = True
        ProductInfo.Enabled = True
        ProductAdd.Enabled = False
        ProductAdd.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Bu ürünü güncellemek istediğinizden emin misiniz?", MsgBoxStyle.YesNo, Me.Text) = DialogResult.Yes Then
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update Product Set Title=@title, ProductNo=@productno, Price=@price, ProductCount=@productcount Where ID=@ID"
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Label7.Text
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@productno", SqlDbType.Int).Value = TextBox8.Text
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = TextBox3.Text
                cmd.Parameters.Add("@productcount", SqlDbType.Int).Value = TextBox4.Text
                cmd.ExecuteNonQuery()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From Product"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                ComboBox1.Items.Clear()
                For Each item As DataGridViewColumn In DataGridView1.Columns
                    ComboBox1.Items.Add(item.Name)
                Next
                connect.Close()
                MsgBox("Başarıyla güncellendi", MsgBoxStyle.Information, Me.Text)
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("Bu ürünü eklemek istediğinizden emin misiniz?", MsgBoxStyle.YesNo, Me.Text) = DialogResult.Yes Then
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Insert into Product (Title, ProductNo, Price, ProductCount)values(@title, @productno, @price, @productcount)"
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = TextBox7.Text
                cmd.Parameters.Add("@productno", SqlDbType.Int).Value = TextBox9.Text
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = TextBox6.Text
                cmd.Parameters.Add("@productcount", SqlDbType.Int).Value = TextBox5.Text
                cmd.ExecuteNonQuery()
                ds.Clear()
                cmd.Parameters.Clear()
                cmd.Connection = connect
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * From Product"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                ComboBox1.Items.Clear()
                For Each item As DataGridViewColumn In DataGridView1.Columns
                    ComboBox1.Items.Add(item.Name)
                Next
                connect.Close()
                MsgBox("Başarıyla eklendi", MsgBoxStyle.Information, Me.Text)
                ProductAdd.Visible = False
                ProductAdd.Enabled = False
            End If
        End If
    End Sub
End Class
