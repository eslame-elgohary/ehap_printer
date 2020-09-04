Public Class REFATO
    Dim ARABIC As New ClassConvertNO
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA WHERE CODE_FATO ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من رقم الفاتورة")
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_FATO
            TXT_FATO_CODE.Text = DR!CODE_NUM
            TXT_DATE_FATO.Text = DR!DATE_FATO
            TXT_CODE_CUST.Text = DR!CUST_CODE
            TXT_MONY.Text = DR!MONY_FATO

            USER_ADD.Text = DR!ADD_NAME
            DATE_ADD.Text = DR!ADD_DATE
            TIME_ADD.Text = DR!ADD_TIME

            BTN_DELET.Enabled = True
            BTN_EDIT.Enabled = True
            BTN_SAVE.Enabled = False
            TIMERADD.Enabled = False
            TIMEREDIT.Enabled = True

        End If



    End Sub
    Private Sub TIMERADD_Tick(sender As Object, e As EventArgs) Handles TIMERADD.Tick
        USER_ADD.Text = HOME.T_USERS.Text
        DATE_ADD.Text = Date.Today
        TIME_ADD.Text = TimeOfDay
        EDITNAMEBT.Visible = False
        USER_EDIT.Visible = False
        DATE_EDIT.Visible = False
        TIME_EDIT.Visible = False
    End Sub

    Private Sub TIMEREDIT_Tick(sender As Object, e As EventArgs) Handles TIMEREDIT.Tick
        EDITNAMEBT.Visible = True
        USER_EDIT.Visible = True
        DATE_EDIT.Visible = True
        TIME_EDIT.Visible = True
        USER_EDIT.Text = HOME.T_USERS.Text
        DATE_EDIT.Text = Date.Today
        TIME_EDIT.Text = TimeOfDay
    End Sub
    Private Sub FATO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub
    Sub CUST()
        TXT_FATO_CODE.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA WHERE STAT_FATO ='TRUE' AND TYPE_FATO = 'غير مدفوعة'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_FATO_CODE.Items.Add(DT.Rows(I).Item("CODE_NUM"))
        Next
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        CUST()
        '===========================================
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        TextBox1.Text = ""
        TXT_FATO_CODE.Text = ""
        '===============================================
        'TXT_CODE.Text = CODE_GENE("FATORA", "ID") + 1
        '=================================================
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        '=====================================================
        FILL_DGV(DG1, "SELECT * FROM FATORA_V WHERE STAT_FATO='TRUE' AND TYPE_FATO = 'مدفوعة' ORDER BY ID DESC")
        TXT_CHOES.SelectedIndex = 0
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub TXT_CODE_CUST_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_CUST.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_CODE ='" & TXT_CODE_CUST.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CUST_NAME.Text = DT.Rows(I).Item("CUST_NAME")
            TXT_MANGER.Text = DT.Rows(I).Item("CUST_MANGER")
        Next
    End Sub
    Private Sub DG1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DG1.RowsAdded
        For I As Integer = 0 To DG1.Rows.Count - 1
            DG1.Rows(I).Cells(5).Value = "عرض"
            Dim ROW As DataGridViewRow = DG1.Rows(I)
        Next
    End Sub

    Private Sub DG1_Click(sender As Object, e As EventArgs) Handles DG1.Click
        If DG1(5, DG1.CurrentRow.Index).Selected = True Then
            Me.SHOW_DETA(DG1.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("B1").ToString = True Then
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA WHERE CODE_FATO='" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)
                DR!CODE_FATO = TXT_CODE.Text
                DR!CODE_NUM = TXT_FATO_CODE.Text
                DR!DATE_FATO = TXT_DATE_FATO.Text
                DR!CUST_CODE = TXT_CODE_CUST.Text
                DR!MONY_FATO = TXT_MONY.Text
                DR!MONY_AR_FATO = TXT_AR_MONY.Text
                DR!STAT_FATO = True
                DR!EDIT_NAME = USER_EDIT.Text
                DR!EDIT_DATE = DATE_EDIT.Text
                DR!EDIT_TIME = TIME_EDIT.Text
                DR!TYPE_FATO = "مدفوعة"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show("تمت عملية تسديد الفاتورة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BTN_NEW_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub
    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("B3").ToString = True Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA WHERE CODE_FATO='" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)

                DR!TYPE_FATO = "غير مدفوعة"
                DR!EDIT_NAME = USER_EDIT.Text
                DR!EDIT_DATE = DATE_EDIT.Text
                DR!EDIT_TIME = TIME_EDIT.Text

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show("تمت عملية الحذف بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BTN_NEW_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BTN_PRINT_Click(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
        If TXT_CODE_CUST.Text = "" Then

            MessageBox.Show("لايمكن طباعة فاتورة خالية", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_CUST_NAME.Select()
            Exit Sub
        Else


            Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
            Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
            Dim DS0 As New DataSet
            ADP0.Fill(DS0)
            Dim DT0 = DS0.Tables(0)
            If DT0.Rows.Count > 0 Then
                If DT0.Rows(0).Item("B4").ToString = True Then

                    Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA_V WHERE CODE_FATO ='" & TXT_CODE.Text & "' ", SqlConn)
                    DA.Fill(DT)

                    Dim REP As New FATORA_CRS
                    REP.SetDataSource(DT)
                    Dim FRM As New FORALL
                    FRM.CrystalReportViewer1.ReportSource = REP
                    FRM.ShowDialog()
                Else
                    MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        End If
    End Sub

    Private Sub TXT_MONY_TextChanged(sender As Object, e As EventArgs) Handles TXT_MONY.TextChanged
        If TXT_MONY.Text = "" Or TXT_MONY.Text = "0" Then
            TXT_AR_MONY.Text = ""
        Else
            TXT_AR_MONY.Text = ARABIC.ConvertToArabic(TXT_MONY.Text)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TXT_CHOES.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM FATORA_V WHERE STAT_FATO ='TRUE' AND TYPE_FATO = 'مدفوعة' AND CODE_NUM LIKE '%" & TextBox1.Text & "%' ORDER BY ID DESC  ", SqlConn)
            DA.Fill(DT)
            DG1.DataSource = DT.DefaultView
        End If
        If TXT_CHOES.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM FATORA_V WHERE STAT_FATO ='TRUE' AND TYPE_FATO = 'مدفوعة' AND CUST_NAME LIKE '%" & TextBox1.Text & "%' ORDER BY ID DESC  ", SqlConn)
            DA.Fill(DT)
            DG1.DataSource = DT.DefaultView
        End If

    End Sub

    Private Sub TXT_FATO_CODE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_FATO_CODE.SelectedIndexChanged

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA_V WHERE CODE_NUM ='" & TXT_FATO_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_CUST.Text = DT.Rows(I).Item("CUST_CODE")
            TXT_MANGER.Text = DT.Rows(I).Item("CUST_MANGER")
            TXT_MONY.Text = DT.Rows(I).Item("MONY_FATO")
            TXT_CODE.Text = DT.Rows(I).Item("CODE_FATO")
        Next

    End Sub
End Class