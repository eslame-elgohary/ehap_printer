Public Class HOME
    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_connection()
        Timer1.Start()
        ESLAME()
        MACHINBTN.Text = My.Computer.Name
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        T_TIME.Text = TimeOfDay
        T_DATE.Text = Date.Today

    End Sub
    Sub ESLAME()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT TOP 1 REALY_NAME,CODE_USER FROM ESLAME_LO WHERE MA='" & My.Computer.Name & "' ORDER BY ID DESC ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            T_USERS.Text = DT.Rows(0).Item("REALY_NAME")
            CODE_USERBT.Text = DT.Rows(0).Item("CODE_USER")
        End If

    End Sub

    Private Sub BTNBACKUP_Click(sender As Object, e As EventArgs) Handles BTNBACKUP.Click
        If MessageBox.Show("هل ترغب فى عمل نسخة أحتياطية للبرنامج ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ROLES("UP", BACKUPFRM)
            Catch EX As Exception

            End Try

        End If
    End Sub

    Private Sub أضافةمستخدمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles أضافةمستخدمToolStripMenuItem.Click
        Try
            ROLES("I", USERSFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub أضافةصلاحياتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles أضافةصلاحياتToolStripMenuItem.Click
        Try
            ROLES("J", USERSLAHFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub أضافةعميلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles أضافةعميلToolStripMenuItem.Click
        Try
            ROLES("A", CUSTFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub اضافةفاتورةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةفاتورةToolStripMenuItem.Click
        Try
            ROLES("B", FATO)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub كشفحسابعميلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles كشفحسابعميلToolStripMenuItem.Click
        REP_ALL.ShowDialog()
    End Sub

    Private Sub BT_EXIT_Click(sender As Object, e As EventArgs) Handles BT_EXIT.Click
        If MessageBox.Show("هل ترغب فى عمل نسخة أحتياطية للبرنامج ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ROLES("UP", BACKUPFRM)
            Catch EX As Exception
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub STB_EXIT_Click(sender As Object, e As EventArgs) Handles STB_EXIT.Click
        If MessageBox.Show("هل ترغب فى عمل نسخة أحتياطية للبرنامج ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ROLES("UP", BACKUPFRM)
            Catch EX As Exception
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub BT_JOGOUT_Click(sender As Object, e As EventArgs) Handles BT_JOGOUT.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub تسديدفاتورةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسديدفاتورةToolStripMenuItem.Click
        REFATO.ShowDialog()
    End Sub
End Class
