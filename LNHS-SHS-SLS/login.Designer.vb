<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logn_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logn_frm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uname_txtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pwd_txtbox = New System.Windows.Forms.TextBox()
        Me.logn_btn = New System.Windows.Forms.Button()
        Me.clrlogn_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'uname_txtbox
        '
        Me.uname_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname_txtbox.Location = New System.Drawing.Point(216, 301)
        Me.uname_txtbox.Name = "uname_txtbox"
        Me.uname_txtbox.Size = New System.Drawing.Size(208, 35)
        Me.uname_txtbox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'pwd_txtbox
        '
        Me.pwd_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd_txtbox.Location = New System.Drawing.Point(216, 349)
        Me.pwd_txtbox.Name = "pwd_txtbox"
        Me.pwd_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd_txtbox.Size = New System.Drawing.Size(208, 35)
        Me.pwd_txtbox.TabIndex = 1
        '
        'logn_btn
        '
        Me.logn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logn_btn.Location = New System.Drawing.Point(216, 410)
        Me.logn_btn.Name = "logn_btn"
        Me.logn_btn.Size = New System.Drawing.Size(83, 43)
        Me.logn_btn.TabIndex = 2
        Me.logn_btn.TabStop = False
        Me.logn_btn.Text = "Log-in"
        Me.logn_btn.UseVisualStyleBackColor = True
        '
        'clrlogn_btn
        '
        Me.clrlogn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrlogn_btn.Location = New System.Drawing.Point(336, 410)
        Me.clrlogn_btn.Name = "clrlogn_btn"
        Me.clrlogn_btn.Size = New System.Drawing.Size(88, 43)
        Me.clrlogn_btn.TabIndex = 4
        Me.clrlogn_btn.TabStop = False
        Me.clrlogn_btn.Text = "Clear"
        Me.clrlogn_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 253)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 90)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LNHS SHS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 90)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Student"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 90)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Locator"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 90)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "System"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(372, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'logn_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 475)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.clrlogn_btn)
        Me.Controls.Add(Me.logn_btn)
        Me.Controls.Add(Me.pwd_txtbox)
        Me.Controls.Add(Me.uname_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "logn_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log-in Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uname_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pwd_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents logn_btn As System.Windows.Forms.Button
    Friend WithEvents clrlogn_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
