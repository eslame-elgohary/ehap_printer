Public Class REP_ALL
    Private Sub REP_ALL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CUST()
        TXT_CUST_NAME.SelectedIndex = -1
        TXT_DATE_END.Text = Date.Today
        TXT_DATE_START.Text = Date.Today
    End Sub
    Sub CUST()
        TXT_CUST_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_STAT ='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CUST_NAME.Items.Add(DT.Rows(I).Item("CUST_NAME"))
        Next
    End Sub
    Private Sub TXT_CODE_CUST_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_CUST.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_CODE ='" & TXT_CODE_CUST.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CUST_NAME.Text = DT.Rows(I).Item("CUST_NAME")
        Next
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If TXT_CODE_CUST.Text = "" Then
            MessageBox.Show("من فضلك أختار أسم العميل")
            TXT_CUST_NAME.Select()
            Exit Sub
        Else
            FILL_DGV(DG1, "SELECT * FROM FATORA_V WHERE CUST_CODE ='" & TXT_CODE_CUST.Text & "' AND DATE_FATO > = '" & TXT_DATE_START.Text & "' AND DATE_FATO < = '" & TXT_DATE_END.Text & "' ORDER BY ID DESC")
            For Each r As DataGridViewRow In DG1.Rows
                Select Case r.Cells.Item(4).Value
                    Case "مدفوعة"
                        r.Cells.Item(4).Style.ForeColor = Color.Green
                    Case Else
                        r.Cells.Item(4).Style.ForeColor = Color.Red
                End Select
            Next
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If TXT_CODE_CUST.Text = "" Then
            MessageBox.Show("من فضلك أختار أسم العميل")
            TXT_CUST_NAME.Select()
            Exit Sub
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATORA_V WHERE CUST_CODE ='" & TXT_CODE_CUST.Text & "' AND DATE_FATO > = '" & TXT_DATE_START.Text & "' AND DATE_FATO < = '" & TXT_DATE_END.Text & "' AND TYPE_FATO = 'غير مدفوعة'", SqlConn)
            DA.Fill(DT)

            Dim REP As New FATORA_CRS
            REP.SetDataSource(DT)
            Dim FRM As New FORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If
    End Sub

    Private Sub TXT_CUST_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_CUST_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUST_NAME ='" & TXT_CUST_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_CUST.Text = DT.Rows(I).Item("CUST_CODE")
        Next
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Dispose()
    End Sub
End Class