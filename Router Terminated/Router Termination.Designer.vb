<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RouterTerminated
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Abort = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.credits = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleFlashOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeFlashOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Lime
        Me.Title.Location = New System.Drawing.Point(296, 24)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(435, 29)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Router Termination System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(241, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.SpringGreen
        Me.TextBox1.Location = New System.Drawing.Point(43, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Ex. 10.0.0.0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.SpringGreen
        Me.TextBox2.Location = New System.Drawing.Point(289, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 22)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Ex. 80"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data to Send:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Clear)
        Me.GroupBox1.Controls.Add(Me.Abort)
        Me.GroupBox1.Controls.Add(Me.Start)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("AR DESTINE", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 188)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Terminator"
        '
        'Clear
        '
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Clear.Location = New System.Drawing.Point(251, 140)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(97, 35)
        Me.Clear.TabIndex = 6
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Abort
        '
        Me.Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abort.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abort.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Abort.Location = New System.Drawing.Point(137, 140)
        Me.Abort.Name = "Abort"
        Me.Abort.Size = New System.Drawing.Size(97, 35)
        Me.Abort.TabIndex = 5
        Me.Abort.Text = "Abort"
        Me.Abort.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("AR DESTINE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Start.Location = New System.Drawing.Point(18, 140)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(97, 35)
        Me.Start.TabIndex = 4
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.LightGreen
        Me.TextBox3.Location = New System.Drawing.Point(119, 92)
        Me.TextBox3.MaxLength = 327688999
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 23)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "Ex. YOU HAVE BEEN HACKED"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'credits
        '
        Me.credits.AutoSize = True
        Me.credits.Font = New System.Drawing.Font("AR DESTINE", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.credits.Location = New System.Drawing.Point(538, 53)
        Me.credits.Name = "credits"
        Me.credits.Size = New System.Drawing.Size(165, 17)
        Me.credits.TabIndex = 8
        Me.credits.Text = "Made by RepCity Mafia"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.Red
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(31, 273)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(330, 303)
        Me.ListBox1.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("AR DESTINE", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightGreen
        Me.GroupBox2.Location = New System.Drawing.Point(470, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 175)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ONLINE Checker"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AR DESTINE", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(125, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Check "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(108, 75)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 26)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "Ex. 10.0.0.0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("AR DESTINE", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Ivory
        Me.Label5.Location = New System.Drawing.Point(113, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("AR DESTINE", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Victim's IP:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Button2.Location = New System.Drawing.Point(946, 552)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "What Is My Current IP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Castellar", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(43, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 40)
        Me.Label6.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(867, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 67)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Router_Terminated.My.Resources.Resources.rmob_logo
        Me.PictureBox1.Location = New System.Drawing.Point(881, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlashingToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FlashingToolStripMenuItem
        '
        Me.FlashingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem, Me.TitleFlashOffToolStripMenuItem, Me.WelcomeFlashOffToolStripMenuItem})
        Me.FlashingToolStripMenuItem.Name = "FlashingToolStripMenuItem"
        Me.FlashingToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.FlashingToolStripMenuItem.Text = "Flashing"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'TitleFlashOffToolStripMenuItem
        '
        Me.TitleFlashOffToolStripMenuItem.Name = "TitleFlashOffToolStripMenuItem"
        Me.TitleFlashOffToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TitleFlashOffToolStripMenuItem.Text = "Title Flash Off"
        '
        'WelcomeFlashOffToolStripMenuItem
        '
        Me.WelcomeFlashOffToolStripMenuItem.Name = "WelcomeFlashOffToolStripMenuItem"
        Me.WelcomeFlashOffToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.WelcomeFlashOffToolStripMenuItem.Text = "Welcome Flash Off"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("AR DESTINE", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(449, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 211)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Website Resolver"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("AR DESTINE", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(137, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 39)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Find IP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Castellar", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Website Resolver"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Red
        Me.TextBox6.Location = New System.Drawing.Point(128, 118)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(157, 23)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Red
        Me.TextBox5.Location = New System.Drawing.Point(129, 77)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(157, 23)
        Me.TextBox5.TabIndex = 2
        Me.TextBox5.Text = "Ex. Google.com"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(25, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "IP Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(44, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Website:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Castellar", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(483, 535)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(292, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Welcome, To Terminator"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'RouterTerminated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1154, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.credits)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RouterTerminated"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Router Termination System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Clear As Button
    Friend WithEvents Abort As Button
    Friend WithEvents Start As Button
    Friend WithEvents credits As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents FlashingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleFlashOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WelcomeFlashOffToolStripMenuItem As ToolStripMenuItem
End Class
