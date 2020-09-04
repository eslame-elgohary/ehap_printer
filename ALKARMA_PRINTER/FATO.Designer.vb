<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FATO
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FATO))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_CODE_CUST = New System.Windows.Forms.TextBox()
        Me.TXT_CUST_NAME = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_DATE_FATO = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_MONY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_MANGER = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AR_MONY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_FATO_CODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_CHOES = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EDITNAMEBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_PRINT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_CUST)
        Me.GroupBox1.Controls.Add(Me.TXT_CUST_NAME)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_FATO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_MONY)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_MANGER)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_AR_MONY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_FATO_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TXT_CODE_CUST
        '
        Me.TXT_CODE_CUST.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_CUST.Enabled = False
        Me.TXT_CODE_CUST.Location = New System.Drawing.Point(698, 63)
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
        Me.TXT_CUST_NAME.Location = New System.Drawing.Point(370, 63)
        Me.TXT_CUST_NAME.Name = "TXT_CUST_NAME"
        Me.TXT_CUST_NAME.Size = New System.Drawing.Size(278, 29)
        Me.TXT_CUST_NAME.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "تاريخ الفاتورة :"
        '
        'TXT_DATE_FATO
        '
        Me.TXT_DATE_FATO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_FATO.Location = New System.Drawing.Point(78, 19)
        Me.TXT_DATE_FATO.Name = "TXT_DATE_FATO"
        Me.TXT_DATE_FATO.Size = New System.Drawing.Size(182, 29)
        Me.TXT_DATE_FATO.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(648, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "مبلغ الفاتورة :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_MONY.Location = New System.Drawing.Point(496, 106)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Size = New System.Drawing.Size(152, 29)
        Me.TXT_MONY.TabIndex = 11
        Me.TXT_MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "أسم  المختص :"
        '
        'TXT_MANGER
        '
        Me.TXT_MANGER.BackColor = System.Drawing.Color.White
        Me.TXT_MANGER.Enabled = False
        Me.TXT_MANGER.Location = New System.Drawing.Point(10, 63)
        Me.TXT_MANGER.Name = "TXT_MANGER"
        Me.TXT_MANGER.Size = New System.Drawing.Size(250, 29)
        Me.TXT_MANGER.TabIndex = 9
        Me.TXT_MANGER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(654, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "أسم العميل :"
        '
        'TXT_AR_MONY
        '
        Me.TXT_AR_MONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_AR_MONY.Enabled = False
        Me.TXT_AR_MONY.Location = New System.Drawing.Point(10, 106)
        Me.TXT_AR_MONY.Name = "TXT_AR_MONY"
        Me.TXT_AR_MONY.Size = New System.Drawing.Size(480, 29)
        Me.TXT_AR_MONY.TabIndex = 7
        Me.TXT_AR_MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "رقم الفاتورة :"
        '
        'TXT_FATO_CODE
        '
        Me.TXT_FATO_CODE.BackColor = System.Drawing.Color.Aqua
        Me.TXT_FATO_CODE.Location = New System.Drawing.Point(370, 19)
        Me.TXT_FATO_CODE.Name = "TXT_FATO_CODE"
        Me.TXT_FATO_CODE.Size = New System.Drawing.Size(120, 29)
        Me.TXT_FATO_CODE.TabIndex = 5
        Me.TXT_FATO_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(706, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "كود :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(595, 19)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(105, 29)
        Me.TXT_CODE.TabIndex = 3
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TXT_CHOES)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 50)
        Me.Panel1.TabIndex = 13
        '
        'TXT_CHOES
        '
        Me.TXT_CHOES.BackColor = System.Drawing.Color.White
        Me.TXT_CHOES.FormattingEnabled = True
        Me.TXT_CHOES.Items.AddRange(New Object() {"البحث برقم الفاتورة", "البحث بأسم العميل"})
        Me.TXT_CHOES.Location = New System.Drawing.Point(529, 10)
        Me.TXT_CHOES.Name = "TXT_CHOES"
        Me.TXT_CHOES.Size = New System.Drawing.Size(212, 29)
        Me.TXT_CHOES.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(100, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(406, 29)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TIMEREDIT
        '
        '
        'TIMERADD
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(754, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 36
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel4.Text = "الأضافة : "
        '
        'USER_ADD
        '
        Me.USER_ADD.Name = "USER_ADD"
        Me.USER_ADD.Size = New System.Drawing.Size(119, 17)
        Me.USER_ADD.Text = "ToolStripStatusLabel1"
        '
        'DATE_ADD
        '
        Me.DATE_ADD.Name = "DATE_ADD"
        Me.DATE_ADD.Size = New System.Drawing.Size(119, 17)
        Me.DATE_ADD.Text = "ToolStripStatusLabel2"
        '
        'TIME_ADD
        '
        Me.TIME_ADD.Name = "TIME_ADD"
        Me.TIME_ADD.Size = New System.Drawing.Size(119, 17)
        Me.TIME_ADD.Text = "ToolStripStatusLabel3"
        '
        'EDITNAMEBT
        '
        Me.EDITNAMEBT.Name = "EDITNAMEBT"
        Me.EDITNAMEBT.Size = New System.Drawing.Size(52, 17)
        Me.EDITNAMEBT.Text = "التعديل : "
        Me.EDITNAMEBT.Visible = False
        '
        'USER_EDIT
        '
        Me.USER_EDIT.Name = "USER_EDIT"
        Me.USER_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.USER_EDIT.Text = "ToolStripStatusLabel6"
        Me.USER_EDIT.Visible = False
        '
        'DATE_EDIT
        '
        Me.DATE_EDIT.Name = "DATE_EDIT"
        Me.DATE_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.DATE_EDIT.Text = "ToolStripStatusLabel1"
        Me.DATE_EDIT.Visible = False
        '
        'TIME_EDIT
        '
        Me.TIME_EDIT.Name = "TIME_EDIT"
        Me.TIME_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.TIME_EDIT.Text = "ToolStripStatusLabel2"
        Me.TIME_EDIT.Visible = False
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.AllowUserToDeleteRows = False
        Me.DG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DG1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DG1.Location = New System.Drawing.Point(0, 194)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        Me.DG1.RowHeadersVisible = False
        Me.DG1.Size = New System.Drawing.Size(754, 212)
        Me.DG1.TabIndex = 37
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
        'Column3
        '
        Me.Column3.DataPropertyName = "CUST_NAME"
        Me.Column3.HeaderText = "أسم العميل"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
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
        Me.Column5.FillWeight = 30.0!
        Me.Column5.HeaderText = "-"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTN_PRINT)
        Me.Panel2.Controls.Add(Me.BTN_EXIT)
        Me.Panel2.Controls.Add(Me.BTN_DELET)
        Me.Panel2.Controls.Add(Me.BTN_EDIT)
        Me.Panel2.Controls.Add(Me.BTN_SAVE)
        Me.Panel2.Controls.Add(Me.BTN_NEW)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(754, 63)
        Me.Panel2.TabIndex = 38
        '
        'BTN_PRINT
        '
        Me.BTN_PRINT.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PRINT.Appearance.Options.UseFont = True
        Me.BTN_PRINT.ImageOptions.Image = CType(resources.GetObject("BTN_PRINT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_PRINT.Location = New System.Drawing.Point(137, 10)
        Me.BTN_PRINT.Name = "BTN_PRINT"
        Me.BTN_PRINT.Size = New System.Drawing.Size(93, 44)
        Me.BTN_PRINT.TabIndex = 5
        Me.BTN_PRINT.Text = "طباعة"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(12, 10)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(93, 44)
        Me.BTN_EXIT.TabIndex = 4
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(262, 10)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(93, 44)
        Me.BTN_DELET.TabIndex = 3
        Me.BTN_DELET.Text = "حذف"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(387, 10)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(93, 44)
        Me.BTN_EDIT.TabIndex = 2
        Me.BTN_EDIT.Text = "تعديل"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(512, 10)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(93, 44)
        Me.BTN_SAVE.TabIndex = 1
        Me.BTN_SAVE.Text = "حفظ"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(637, 10)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(93, 44)
        Me.BTN_NEW.TabIndex = 0
        Me.BTN_NEW.Text = "جديد"
        '
        'FATO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FATO"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الفواتير"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_MONY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_MANGER As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_AR_MONY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_FATO_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TXT_CUST_NAME As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_DATE_FATO As DateTimePicker
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_PRINT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_CODE_CUST As TextBox
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents TXT_CHOES As ComboBox
End Class
