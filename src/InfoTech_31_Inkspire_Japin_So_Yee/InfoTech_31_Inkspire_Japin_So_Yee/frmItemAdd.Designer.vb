<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemAdd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ItemMarkUp100 = New System.Windows.Forms.RadioButton()
        Me.ItemMarkUp70 = New System.Windows.Forms.RadioButton()
        Me.ItemMarkUp40 = New System.Windows.Forms.RadioButton()
        Me.txtItemCostPr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemSellPr = New System.Windows.Forms.TextBox()
        Me.txtItemNm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemIDNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtItemCostPr)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtItemSellPr)
        Me.Panel2.Controls.Add(Me.txtItemNm)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtItemIDNum)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Panel2.Location = New System.Drawing.Point(27, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(737, 253)
        Me.Panel2.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ItemMarkUp100)
        Me.GroupBox1.Controls.Add(Me.ItemMarkUp70)
        Me.GroupBox1.Controls.Add(Me.ItemMarkUp40)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 64)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mark Up"
        '
        'ItemMarkUp100
        '
        Me.ItemMarkUp100.AutoSize = True
        Me.ItemMarkUp100.Location = New System.Drawing.Point(270, 27)
        Me.ItemMarkUp100.Name = "ItemMarkUp100"
        Me.ItemMarkUp100.Size = New System.Drawing.Size(72, 24)
        Me.ItemMarkUp100.TabIndex = 90
        Me.ItemMarkUp100.TabStop = True
        Me.ItemMarkUp100.Text = "100%"
        Me.ItemMarkUp100.UseVisualStyleBackColor = True
        '
        'ItemMarkUp70
        '
        Me.ItemMarkUp70.AutoSize = True
        Me.ItemMarkUp70.Location = New System.Drawing.Point(159, 27)
        Me.ItemMarkUp70.Name = "ItemMarkUp70"
        Me.ItemMarkUp70.Size = New System.Drawing.Size(63, 24)
        Me.ItemMarkUp70.TabIndex = 89
        Me.ItemMarkUp70.TabStop = True
        Me.ItemMarkUp70.Text = "70%"
        Me.ItemMarkUp70.UseVisualStyleBackColor = True
        '
        'ItemMarkUp40
        '
        Me.ItemMarkUp40.AutoSize = True
        Me.ItemMarkUp40.Location = New System.Drawing.Point(40, 27)
        Me.ItemMarkUp40.Name = "ItemMarkUp40"
        Me.ItemMarkUp40.Size = New System.Drawing.Size(63, 24)
        Me.ItemMarkUp40.TabIndex = 88
        Me.ItemMarkUp40.TabStop = True
        Me.ItemMarkUp40.Text = "40%"
        Me.ItemMarkUp40.UseVisualStyleBackColor = True
        '
        'txtItemCostPr
        '
        Me.txtItemCostPr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtItemCostPr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemCostPr.Location = New System.Drawing.Point(148, 148)
        Me.txtItemCostPr.Name = "txtItemCostPr"
        Me.txtItemCostPr.Size = New System.Drawing.Size(143, 26)
        Me.txtItemCostPr.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(47, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Cost Price"
        '
        'txtItemSellPr
        '
        Me.txtItemSellPr.Enabled = False
        Me.txtItemSellPr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtItemSellPr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemSellPr.Location = New System.Drawing.Point(148, 190)
        Me.txtItemSellPr.Name = "txtItemSellPr"
        Me.txtItemSellPr.Size = New System.Drawing.Size(143, 26)
        Me.txtItemSellPr.TabIndex = 95
        '
        'txtItemNm
        '
        Me.txtItemNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtItemNm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemNm.Location = New System.Drawing.Point(396, 104)
        Me.txtItemNm.Name = "txtItemNm"
        Me.txtItemNm.Size = New System.Drawing.Size(317, 26)
        Me.txtItemNm.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(26, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Selling Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(328, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Name"
        '
        'txtItemIDNum
        '
        Me.txtItemIDNum.Enabled = False
        Me.txtItemIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtItemIDNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItemIDNum.Location = New System.Drawing.Point(148, 104)
        Me.txtItemIDNum.Name = "txtItemIDNum"
        Me.txtItemIDNum.Size = New System.Drawing.Size(143, 26)
        Me.txtItemIDNum.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(47, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "ID number"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources._19
        Me.PictureBox2.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(104, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Add Item"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 119)
        Me.Panel1.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources.InkSpire__5_
        Me.PictureBox1.Location = New System.Drawing.Point(457, -65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancel.Location = New System.Drawing.Point(629, 403)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 42)
        Me.btnCancel.TabIndex = 57
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
        Me.btnSave.Location = New System.Drawing.Point(437, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 42)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmItemAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 467)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmItemAdd"
        Me.Text = "Add - Item Management"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemMarkUp100 As System.Windows.Forms.RadioButton
    Friend WithEvents ItemMarkUp70 As System.Windows.Forms.RadioButton
    Friend WithEvents ItemMarkUp40 As System.Windows.Forms.RadioButton
    Friend WithEvents txtItemCostPr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemSellPr As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemIDNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
