<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpAdd
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtEmpPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmpMInitial = New System.Windows.Forms.TextBox()
        Me.txtEmpFName = New System.Windows.Forms.TextBox()
        Me.txtEmpLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.txtEmpPhoneNum)
        Me.Panel2.Controls.Add(Me.txtEmpAddress)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtEmpId)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(26, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 331)
        Me.Panel2.TabIndex = 46
        '
        'txtEmpPhoneNum
        '
        Me.txtEmpPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpPhoneNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpPhoneNum.Location = New System.Drawing.Point(597, 164)
        Me.txtEmpPhoneNum.Name = "txtEmpPhoneNum"
        Me.txtEmpPhoneNum.Size = New System.Drawing.Size(248, 26)
        Me.txtEmpPhoneNum.TabIndex = 41
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpAddress.Location = New System.Drawing.Point(597, 117)
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(247, 26)
        Me.txtEmpAddress.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(450, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Phone number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(450, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Home Address"
        '
        'txtEmpId
        '
        Me.txtEmpId.Enabled = False
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmpId.Location = New System.Drawing.Point(132, 117)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(176, 26)
        Me.txtEmpId.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmpMInitial)
        Me.GroupBox1.Controls.Add(Me.txtEmpFName)
        Me.GroupBox1.Controls.Add(Me.txtEmpLName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 147)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Full name"
        '
        'txtEmpMInitial
        '
        Me.txtEmpMInitial.Location = New System.Drawing.Point(169, 107)
        Me.txtEmpMInitial.Name = "txtEmpMInitial"
        Me.txtEmpMInitial.Size = New System.Drawing.Size(99, 26)
        Me.txtEmpMInitial.TabIndex = 4
        '
        'txtEmpFName
        '
        Me.txtEmpFName.Location = New System.Drawing.Point(153, 71)
        Me.txtEmpFName.Name = "txtEmpFName"
        Me.txtEmpFName.Size = New System.Drawing.Size(234, 26)
        Me.txtEmpFName.TabIndex = 3
        '
        'txtEmpLName
        '
        Me.txtEmpLName.Location = New System.Drawing.Point(153, 35)
        Me.txtEmpLName.Name = "txtEmpLName"
        Me.txtEmpLName.Size = New System.Drawing.Size(234, 26)
        Me.txtEmpLName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Middle Initial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(27, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ID number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(104, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Add Employee"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 119)
        Me.Panel1.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancel.Location = New System.Drawing.Point(772, 485)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 42)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Location = New System.Drawing.Point(577, 485)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 42)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources._191
        Me.PictureBox2.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources.InkSpire__5_
        Me.PictureBox1.Location = New System.Drawing.Point(601, -72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmEmpAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 549)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmEmpAdd"
        Me.Text = "Add - Employee Management"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtEmpPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpMInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpFName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpLName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
