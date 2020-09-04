Public Class CUSTFRM
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
    Private Sub CUSTFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        '===========================================
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        TextBox1.Text = ""
        '===============================================
        TXT_CUST_CODE.Text = CODE_GENE("CUSTOMER", "ID") + 1
        '=================================================
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        '=====================================================
        FILL_DGV(DG1, "SELECT * FROM CUSTOMER WHERE CUST_STAT='TRUE'")

    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("A1").ToString = True Then
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_NAME = '" & TXT_CUST_NAME.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد عميل آخر بنفس الأسم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_CUST_NAME.Select()
                    Exit Sub
                Else
                    Dim DR = DT.NewRow
                    DR!CUST_CODE = TXT_CUST_CODE.Text
                    DR!CUST_NAME = TXT_CUST_NAME.Text
                    DR!CUST_ADRRES = TXT_CUST_ADRRES.Text
                    DR!CUST_MANGER = TXT_MANGER.Text
                    DR!CUST_TEL = TXT_TEL.Text
                    DR!CUST_STAT = True
                    DR!ADD_NAME = USER_ADD.Text
                    DR!ADD_DATE = DATE_ADD.Text
                    DR!ADD_TIME = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    BTN_NEW_Click(sender, e)
                End If
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("A2").ToString = True Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_CODE = '" & TXT_CUST_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد عميل آخر بنفس الأسم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_CUST_NAME.Select()
                    Exit Sub
                Else
                    Dim DR = DT.Rows(0)
                    DR!CUST_CODE = TXT_CUST_CODE.Text
                    DR!CUST_NAME = TXT_CUST_NAME.Text
                    DR!CUST_ADRRES = TXT_CUST_ADRRES.Text
                    DR!CUST_MANGER = TXT_MANGER.Text
                    DR!CUST_TEL = TXT_TEL.Text
                    DR!CUST_STAT = True
                    DR!EDIT_NAME = USER_EDIT.Text
                    DR!EDIT_DATE = DATE_EDIT.Text
                    DR!EDIT_TIME = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    BTN_NEW_Click(sender, e)
                End If



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
            If DT0.Rows(0).Item("A3").ToString = True Then


                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_CODE = '" & TXT_CUST_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)

                DR!CUST_STAT = False
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

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DG1.RowsAdded
        For I As Integer = 0 To DG1.Rows.Count - 1
            DG1.Rows(I).Cells(4).Value = "عرض"
            Dim ROW As DataGridViewRow = DG1.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DG1.Click
        If DG1(4, DG1.CurrentRow.Index).Selected = True Then
            Me.SHOW_DETA(DG1.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Sub SHOW_DETA(CODE_)

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_CODE = '" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        TXT_CUST_CODE.Text = DR!CUST_CODE
        TXT_CUST_NAME.Text = DR!CUST_NAME
        TXT_CUST_ADRRES.Text = DR!CUST_ADRRES
        TXT_MANGER.Text = DR!CUST_MANGER
        TXT_TEL.Text = DR!CUST_TEL

        USER_ADD.Text = DR!ADD_NAME
        DATE_ADD.Text = DR!ADD_DATE
        TIME_ADD.Text = DR!ADD_TIME

        BTN_SAVE.Enabled = False
        BTN_EDIT.Enabled = True
        BTN_DELET.Enabled = True
        TIMERADD.Enabled = False
        TIMEREDIT.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_STAT = 'TRUE' AND  CUST_NAME LIKE '%" & TextBox1.Text & "%' ORDER BY ID", SqlConn)
        DA.Fill(DT)
        DG1.DataSource = DT.DefaultView

    End Sub
End Class