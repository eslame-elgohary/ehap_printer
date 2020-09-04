<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class HOME
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T_TIME = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T_DATE = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T_USERS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CODE_USERBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MACHINBTN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.التكويداتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.أضافةعميلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المستخدمينالصلاحياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.أضافةمستخدمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.أضافةصلاحياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الفواتيرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةفاتورةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تسديدفاتورةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.التقريرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.كشفحسابعميلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNBACKUP = New System.Windows.Forms.ToolStripMenuItem()
        Me.BT_EXIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.STB_EXIT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_JOGOUT = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.T_TIME, Me.ToolStripStatusLabel3, Me.T_DATE, Me.ToolStripStatusLabel5, Me.T_USERS, Me.CODE_USERBT, Me.ToolStripStatusLabel4, Me.MACHINBTN})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 30)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 73
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripStatusLabel1.Text = "الوقت : "
        '
        'T_TIME
        '
        Me.T_TIME.ForeColor = System.Drawing.Color.Navy
        Me.T_TIME.Name = "T_TIME"
        Me.T_TIME.Size = New System.Drawing.Size(206, 25)
        Me.T_TIME.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(76, 25)
        Me.ToolStripStatusLabel3.Text = "التاريخ : "
        '
        'T_DATE
        '
        Me.T_DATE.ForeColor = System.Drawing.Color.Green
        Me.T_DATE.Name = "T_DATE"
        Me.T_DATE.Size = New System.Drawing.Size(206, 25)
        Me.T_DATE.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripStatusLabel5.Text = "أسم المستخدم : "
        '
        'T_USERS
        '
        Me.T_USERS.ForeColor = System.Drawing.Color.Maroon
        Me.T_USERS.Name = "T_USERS"
        Me.T_USERS.Size = New System.Drawing.Size(206, 25)
        Me.T_USERS.Text = "ToolStripStatusLabel6"
        '
        'CODE_USERBT
        '
        Me.CODE_USERBT.ActiveLinkColor = System.Drawing.Color.Red
        Me.CODE_USERBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CODE_USERBT.Name = "CODE_USERBT"
        Me.CODE_USERBT.Size = New System.Drawing.Size(206, 25)
        Me.CODE_USERBT.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(206, 25)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'MACHINBTN
        '
        Me.MACHINBTN.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MACHINBTN.Name = "MACHINBTN"
        Me.MACHINBTN.Size = New System.Drawing.Size(20, 25)
        Me.MACHINBTN.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FloralWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.التكويداتToolStripMenuItem, Me.الفواتيرToolStripMenuItem, Me.التقريرToolStripMenuItem, Me.ToolStripMenuItem1, Me.BT_EXIT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 72
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'التكويداتToolStripMenuItem
        '
        Me.التكويداتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.أضافةعميلToolStripMenuItem, Me.المستخدمينالصلاحياتToolStripMenuItem})
        Me.التكويداتToolStripMenuItem.Name = "التكويداتToolStripMenuItem"
        Me.التكويداتToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.التكويداتToolStripMenuItem.Text = "التكويدات"
        '
        'أضافةعميلToolStripMenuItem
        '
        Me.أضافةعميلToolStripMenuItem.Name = "أضافةعميلToolStripMenuItem"
        Me.أضافةعميلToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.أضافةعميلToolStripMenuItem.Text = "أضافة عملاء"
        '
        'المستخدمينالصلاحياتToolStripMenuItem
        '
        Me.المستخدمينالصلاحياتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.أضافةمستخدمToolStripMenuItem, Me.أضافةصلاحياتToolStripMenuItem})
        Me.المستخدمينالصلاحياتToolStripMenuItem.Name = "المستخدمينالصلاحياتToolStripMenuItem"
        Me.المستخدمينالصلاحياتToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.المستخدمينالصلاحياتToolStripMenuItem.Text = "المستخدمين / الصلاحيات"
        '
        'أضافةمستخدمToolStripMenuItem
        '
        Me.أضافةمستخدمToolStripMenuItem.Name = "أضافةمستخدمToolStripMenuItem"
        Me.أضافةمستخدمToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.أضافةمستخدمToolStripMenuItem.Text = "أضافة مستخدم"
        '
        'أضافةصلاحياتToolStripMenuItem
        '
        Me.أضافةصلاحياتToolStripMenuItem.Name = "أضافةصلاحياتToolStripMenuItem"
        Me.أضافةصلاحياتToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.أضافةصلاحياتToolStripMenuItem.Text = "أضافة صلاحيات"
        '
        'الفواتيرToolStripMenuItem
        '
        Me.الفواتيرToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةفاتورةToolStripMenuItem, Me.تسديدفاتورةToolStripMenuItem})
        Me.الفواتيرToolStripMenuItem.Name = "الفواتيرToolStripMenuItem"
        Me.الفواتيرToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.الفواتيرToolStripMenuItem.Text = "الفواتير"
        '
        'اضافةفاتورةToolStripMenuItem
        '
        Me.اضافةفاتورةToolStripMenuItem.Name = "اضافةفاتورةToolStripMenuItem"
        Me.اضافةفاتورةToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.اضافةفاتورةToolStripMenuItem.Text = "اضافة فاتورة"
        '
        'تسديدفاتورةToolStripMenuItem
        '
        Me.تسديدفاتورةToolStripMenuItem.Name = "تسديدفاتورةToolStripMenuItem"
        Me.تسديدفاتورةToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.تسديدفاتورةToolStripMenuItem.Text = "تسديد فاتورة"
        '
        'التقريرToolStripMenuItem
        '
        Me.التقريرToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.كشفحسابعميلToolStripMenuItem})
        Me.التقريرToolStripMenuItem.Name = "التقريرToolStripMenuItem"
        Me.التقريرToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.التقريرToolStripMenuItem.Text = "التقرير"
        '
        'كشفحسابعميلToolStripMenuItem
        '
        Me.كشفحسابعميلToolStripMenuItem.Name = "كشفحسابعميلToolStripMenuItem"
        Me.كشفحسابعميلToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.كشفحسابعميلToolStripMenuItem.Text = "كشف حساب عميل"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNBACKUP})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "."
        '
        'BTNBACKUP
        '
        Me.BTNBACKUP.Name = "BTNBACKUP"
        Me.BTNBACKUP.Size = New System.Drawing.Size(119, 22)
        Me.BTNBACKUP.Text = "BACKUP"
        '
        'BT_EXIT
        '
        Me.BT_EXIT.Name = "BT_EXIT"
        Me.BT_EXIT.Size = New System.Drawing.Size(51, 20)
        Me.BT_EXIT.Text = "الخروج"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightBlue
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STB_EXIT, Me.ToolStripSeparator3, Me.BT_JOGOUT})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 55)
        Me.ToolStrip1.TabIndex = 75
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'STB_EXIT
        '
        Me.STB_EXIT.Image = CType(resources.GetObject("STB_EXIT.Image"), System.Drawing.Image)
        Me.STB_EXIT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.STB_EXIT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.STB_EXIT.Name = "STB_EXIT"
        Me.STB_EXIT.Size = New System.Drawing.Size(91, 52)
        Me.STB_EXIT.Text = "الخروج"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 55)
        '
        'BT_JOGOUT
        '
        Me.BT_JOGOUT.AutoSize = False
        Me.BT_JOGOUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_JOGOUT.Image = Global.ALKARMA_PRINTER.My.Resources.Resources.iconfinder_security__key__lock__protect_2537334
        Me.BT_JOGOUT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_JOGOUT.Name = "BT_JOGOUT"
        Me.BT_JOGOUT.Size = New System.Drawing.Size(50, 52)
        Me.BT_JOGOUT.Text = "تغيير المستخدم"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ALKARMA_PRINTER.My.Resources.Resources.karma_logo_02
        Me.PictureBox1.Location = New System.Drawing.Point(0, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 489)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'HOME
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HOME"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الرئيسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents T_TIME As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents T_DATE As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents T_USERS As ToolStripStatusLabel
    Friend WithEvents CODE_USERBT As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents MACHINBTN As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents التكويداتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BTNBACKUP As ToolStripMenuItem
    Friend WithEvents BT_EXIT As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents STB_EXIT As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BT_JOGOUT As ToolStripButton
    Friend WithEvents أضافةعميلToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents المستخدمينالصلاحياتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents أضافةمستخدمToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents أضافةصلاحياتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الفواتيرToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اضافةفاتورةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents التقريرToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents كشفحسابعميلToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents تسديدفاتورةToolStripMenuItem As ToolStripMenuItem

#End Region
End Class
