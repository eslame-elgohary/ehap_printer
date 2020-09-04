<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_ALL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REP_ALL))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_DATE_END = New System.Windows.Forms.DateTimePicker()
        Me.TXT_CODE_CUST = New System.Windows.Forms.TextBox()
        Me.TXT_CUST_NAME = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_DATE_START = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.SimpleButton2)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_END)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_CUST)
        Me.GroupBox1.Controls.Add(Me.TXT_CUST_NAME)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_START)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(965, 63)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(6, 20)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(40, 35)
        Me.SimpleButton3.TabIndex = 41
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(129, 20)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 35)
        Me.SimpleButton2.TabIndex = 40
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(64, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(40, 35)
        Me.SimpleButton1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(677, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "حتي :"
        '
        'TXT_DATE_END
        '
        Me.TXT_DATE_END.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_END.Location = New System.Drawing.Point(533, 22)
        Me.TXT_DATE_END.Name = "TXT_DATE_END"
        Me.TXT_DATE_END.Size = New System.Drawing.Size(142, 29)
        Me.TXT_DATE_END.TabIndex = 17
        '
        'TXT_CODE_CUST
        '
        Me.TXT_CODE_CUST.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_CUST.Enabled = False
        Me.TXT_CODE_CUST.Location = New System.Drawing.Point(482, 22)
        Me.TXT_CODE_CUST.Name = "TXT_CODE_CUST"
        Me.TXT_CODE_CUST.Size = New System.Drawing.Size(32, 29)
        Me.TXT_CODE_CUST.TabIndex = 16
        Me.TXT_CODE_CUST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_CODE_CUST.Visible = False
        '
        'TXT_CUST_NAME
        '
        Me.TXT_CUST_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_CUST_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_CUST_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_CUST_NAME.FormattingEnabled = True
        Me.TXT_CUST_NAME.Location = New System.Drawing.Point(185, 22)
        Me.TXT_CUST_NAME.Name = "TXT_CUST_NAME"
        Me.TXT_CUST_NAME.Size = New System.Drawing.Size(247, 29)
        Me.TXT_CUST_NAME.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(881, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "الفترة من :"
        '
        'TXT_DATE_START
        '
        Me.TXT_DATE_START.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_START.Location = New System.Drawing.Point(726, 22)
        Me.TXT_DATE_START.Name = "TXT_DATE_START"
        Me.TXT_DATE_START.Size = New System.Drawing.Size(153, 29)
        Me.TXT_DATE_START.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "أسم العميل :"
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.AllowUserToDeleteRows = False
        Me.DG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column4, Me.Column5})
        Me.DG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG1.Location = New System.Drawing.Point(0, 63)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        Me.DG1.RowHeadersVisible = False
        Me.DG1.Size = New System.Drawing.Size(965, 411)
        Me.DG1.TabIndex = 38
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "CODE_FATO"
        Me.Column6.HeaderText = "CODE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_NUM"
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "رقم الفاتورة"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DATE_FATO"
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "تاريخ الفاتورة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "MONY_FATO"
        Me.Column4.FillWeight = 50.0!
        Me.Column4.HeaderText = "مبلغ الفاتورة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "TYPE_FATO"
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "-"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REP_ALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "REP_ALL"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير عن عميل"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_DATE_END As DateTimePicker
    Friend WithEvents TXT_CODE_CUST As TextBox
    Friend WithEvents TXT_CUST_NAME As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_DATE_START As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
