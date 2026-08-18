<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTransAdd
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnAddLine = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtItemNum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSalesORNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSalesTransClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscAmt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(28, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1203, 305)
        Me.Panel2.TabIndex = 58
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnAddLine)
        Me.GroupBox5.Controls.Add(Me.btnFind)
        Me.GroupBox5.Controls.Add(Me.txtItemName)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtQty)
        Me.GroupBox5.Controls.Add(Me.txtPrice)
        Me.GroupBox5.Controls.Add(Me.txtItemNum)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(22, 179)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1153, 108)
        Me.GroupBox5.TabIndex = 87
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Item Entry"
        '
        'btnAddLine
        '
        Me.btnAddLine.BackColor = System.Drawing.Color.White
        Me.btnAddLine.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnAddLine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddLine.ForeColor = System.Drawing.Color.Navy
        Me.btnAddLine.Location = New System.Drawing.Point(988, 34)
        Me.btnAddLine.Name = "btnAddLine"
        Me.btnAddLine.Size = New System.Drawing.Size(147, 60)
        Me.btnAddLine.TabIndex = 100
        Me.btnAddLine.Text = "+ Add Item"
        Me.btnAddLine.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnFind.Location = New System.Drawing.Point(133, 35)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(53, 26)
        Me.btnFind.TabIndex = 106
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtItemName.Location = New System.Drawing.Point(211, 66)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(324, 28)
        Me.txtItemName.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(207, 38)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Item Name"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtQty.Location = New System.Drawing.Point(777, 66)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(176, 28)
        Me.txtQty.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPrice.Location = New System.Drawing.Point(563, 63)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(185, 28)
        Me.txtPrice.TabIndex = 6
        '
        'txtItemNum
        '
        Me.txtItemNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtItemNum.Location = New System.Drawing.Point(26, 67)
        Me.txtItemNum.Name = "txtItemNum"
        Me.txtItemNum.Size = New System.Drawing.Size(160, 28)
        Me.txtItemNum.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(773, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Quantity"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(559, 40)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Price"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(25, 39)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Item Number"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtCustID)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtSaleDate)
        Me.GroupBox3.Controls.Add(Me.txtEmpID)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtSalesORNum)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(22, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1153, 70)
        Me.GroupBox3.TabIndex = 86
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identification"
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCustID.Location = New System.Drawing.Point(620, 36)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(128, 26)
        Me.txtCustID.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(820, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Transaction Date"
        '
        'txtSaleDate
        '
        Me.txtSaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtSaleDate.Location = New System.Drawing.Point(965, 35)
        Me.txtSaleDate.Name = "txtSaleDate"
        Me.txtSaleDate.Size = New System.Drawing.Size(170, 26)
        Me.txtSaleDate.TabIndex = 7
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpID.Location = New System.Drawing.Point(364, 36)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(128, 26)
        Me.txtEmpID.TabIndex = 89
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(509, 40)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Customer ID"
        '
        'txtSalesORNum
        '
        Me.txtSalesORNum.Enabled = False
        Me.txtSalesORNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSalesORNum.Location = New System.Drawing.Point(133, 34)
        Me.txtSalesORNum.Name = "txtSalesORNum"
        Me.txtSalesORNum.Size = New System.Drawing.Size(128, 26)
        Me.txtSalesORNum.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(268, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cashier ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(21, 38)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "OR Number"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(104, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Add Sales Transaction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1293, 119)
        Me.Panel1.TabIndex = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Image = Global.InfoTech_31_Inkspire_Japin_So_Yee.My.Resources.Resources.InkSpire__5_
        Me.PictureBox1.Location = New System.Drawing.Point(920, -79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(28, 454)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1203, 182)
        Me.Panel3.TabIndex = 88
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 125)
        Me.DataGridView1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Line Items"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnSalesTransClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(28, 723)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 112)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action Buttons"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Honeydew
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(40, 35)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(231, 60)
        Me.btnSave.TabIndex = 107
        Me.btnSave.Text = "Save Transaction"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSalesTransClose
        '
        Me.btnSalesTransClose.BackColor = System.Drawing.Color.White
        Me.btnSalesTransClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSalesTransClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesTransClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnSalesTransClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnSalesTransClose.Location = New System.Drawing.Point(479, 35)
        Me.btnSalesTransClose.Name = "btnSalesTransClose"
        Me.btnSalesTransClose.Size = New System.Drawing.Size(129, 61)
        Me.btnSalesTransClose.TabIndex = 107
        Me.btnSalesTransClose.Text = "Close"
        Me.btnSalesTransClose.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MistyRose
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(277, 35)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(196, 61)
        Me.btnCancel.TabIndex = 106
        Me.btnCancel.Text = "Cancel/Clear"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGrandTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDiscAmt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(755, 667)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 168)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Totals"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrandTotal.Location = New System.Drawing.Point(224, 107)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(231, 38)
        Me.txtGrandTotal.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(44, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 31)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Grand Total"
        '
        'txtDiscAmt
        '
        Me.txtDiscAmt.Enabled = False
        Me.txtDiscAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtDiscAmt.Location = New System.Drawing.Point(224, 67)
        Me.txtDiscAmt.Name = "txtDiscAmt"
        Me.txtDiscAmt.Size = New System.Drawing.Size(233, 32)
        Me.txtDiscAmt.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(55, 70)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 26)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Total Discount"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtSubTotal.Location = New System.Drawing.Point(224, 27)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(231, 32)
        Me.txtSubTotal.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(66, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 26)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Item Subtotal"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Button1.Location = New System.Drawing.Point(754, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 26)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmSalesTransAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 857)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalesTransAdd"
        Me.Text = "Add - Sales Transaction"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSalesORNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnAddLine As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSalesTransClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
