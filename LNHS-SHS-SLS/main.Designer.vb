<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.lctstud_btn = New System.Windows.Forms.Button()
        Me.shwmap_btn = New System.Windows.Forms.Button()
        Me.abt_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ecdschd_btn = New System.Windows.Forms.Button()
        Me.ecdsec_btn = New System.Windows.Forms.Button()
        Me.ecdstud_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lctstud_btn
        '
        Me.lctstud_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lctstud_btn.Location = New System.Drawing.Point(12, 161)
        Me.lctstud_btn.Name = "lctstud_btn"
        Me.lctstud_btn.Size = New System.Drawing.Size(323, 86)
        Me.lctstud_btn.TabIndex = 1
        Me.lctstud_btn.TabStop = False
        Me.lctstud_btn.Text = "Locate Students"
        Me.lctstud_btn.UseVisualStyleBackColor = True
        '
        'shwmap_btn
        '
        Me.shwmap_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shwmap_btn.Location = New System.Drawing.Point(12, 339)
        Me.shwmap_btn.Name = "shwmap_btn"
        Me.shwmap_btn.Size = New System.Drawing.Size(323, 86)
        Me.shwmap_btn.TabIndex = 1
        Me.shwmap_btn.TabStop = False
        Me.shwmap_btn.Text = "Show Map"
        Me.shwmap_btn.UseVisualStyleBackColor = True
        '
        'abt_btn
        '
        Me.abt_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.abt_btn.Location = New System.Drawing.Point(12, 520)
        Me.abt_btn.Name = "abt_btn"
        Me.abt_btn.Size = New System.Drawing.Size(323, 86)
        Me.abt_btn.TabIndex = 1
        Me.abt_btn.TabStop = False
        Me.abt_btn.Text = "About"
        Me.abt_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 68.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1326, 102)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LNHS SHS Student Locator System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 572)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ecdschd_btn
        '
        Me.ecdschd_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ecdschd_btn.Location = New System.Drawing.Point(1035, 520)
        Me.ecdschd_btn.Name = "ecdschd_btn"
        Me.ecdschd_btn.Size = New System.Drawing.Size(323, 86)
        Me.ecdschd_btn.TabIndex = 1
        Me.ecdschd_btn.TabStop = False
        Me.ecdschd_btn.Text = "Encode Schedule Info"
        Me.ecdschd_btn.UseVisualStyleBackColor = True
        '
        'ecdsec_btn
        '
        Me.ecdsec_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.ecdsec_btn.Location = New System.Drawing.Point(1035, 339)
        Me.ecdsec_btn.Name = "ecdsec_btn"
        Me.ecdsec_btn.Size = New System.Drawing.Size(323, 86)
        Me.ecdsec_btn.TabIndex = 1
        Me.ecdsec_btn.TabStop = False
        Me.ecdsec_btn.Text = "Encode Section Info"
        Me.ecdsec_btn.UseVisualStyleBackColor = True
        '
        'ecdstud_btn
        '
        Me.ecdstud_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.ecdstud_btn.Location = New System.Drawing.Point(1035, 161)
        Me.ecdstud_btn.Name = "ecdstud_btn"
        Me.ecdstud_btn.Size = New System.Drawing.Size(323, 86)
        Me.ecdstud_btn.TabIndex = 1
        Me.ecdstud_btn.TabStop = False
        Me.ecdstud_btn.Text = "Encode Student Info"
        Me.ecdstud_btn.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 747)
        Me.Controls.Add(Me.ecdstud_btn)
        Me.Controls.Add(Me.ecdsec_btn)
        Me.Controls.Add(Me.ecdschd_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.abt_btn)
        Me.Controls.Add(Me.shwmap_btn)
        Me.Controls.Add(Me.lctstud_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lctstud_btn As System.Windows.Forms.Button
    Friend WithEvents shwmap_btn As System.Windows.Forms.Button
    Friend WithEvents abt_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ecdschd_btn As System.Windows.Forms.Button
    Friend WithEvents ecdsec_btn As System.Windows.Forms.Button
    Friend WithEvents ecdstud_btn As System.Windows.Forms.Button
End Class
