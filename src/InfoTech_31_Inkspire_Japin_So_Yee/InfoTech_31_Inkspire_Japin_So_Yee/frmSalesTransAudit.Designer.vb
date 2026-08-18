<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTransAudit
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
        Me.btnSaleTransClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SalesTransDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesTransDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaleTransClose
        '
        Me.btnSaleTransClose.BackColor = System.Drawing.Color.White
        Me.btnSaleTransClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSaleTransClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaleTransClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSaleTransClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaleTransClose.Location = New System.Drawing.Point(1061, 707)
        Me.btnSaleTransClose.Name = "btnSaleTransClose"
        Me.btnSaleTransClose.Size = New System.Drawing.Size(101, 42)
        Me.btnSaleTransClose.TabIndex = 133
        Me.btnSaleTransClose.Text = "Close"
        Me.btnSaleTransClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.SalesTransDataGridView)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(24, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1138, 559)
        Me.Panel2.TabIndex = 132
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources._23
        Me.PictureBox2.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'SalesTransDataGridView
        '
        Me.SalesTransDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesTransDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.SalesTransDataGridView.Location = New System.Drawing.Point(22, 107)
        Me.SalesTransDataGridView.Name = "SalesTransDataGridView"
        Me.SalesTransDataGridView.RowTemplate.Height = 24
        Me.SalesTransDataGridView.Size = New System.Drawing.Size(1082, 425)
        Me.SalesTransDataGridView.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(104, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Audit Sales Transaction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 119)
        Me.Panel1.TabIndex = 131
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources.InkSpire__5_
        Me.PictureBox1.Location = New System.Drawing.Point(858, -67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmSalesTransAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.Controls.Add(Me.btnSaleTransClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalesTransAudit"
        Me.Text = "frmSalesTransAudit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesTransDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaleTransClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SalesTransDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
