
' Assigned to: Angelique S. So
' Interface by: Angelique S. So
' Summary: Handles editing customer records with real-time DataGridView searching.
' Date Created: 8/18/2026

Imports IBM.Data.DB2
Imports System.Data

Public Class frmCustEdit
    Private DBConn As Common.DbConnection
    Private dtCustomer As DataTable
    Private dvCustomer As DataView

    ' Loading Form & Data
    Private Sub frmCustEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database = inkspire;" + "uid = db2admin;password = db2admin;")
            DBConn.Open()

            txtCustId.ReadOnly = True
            LoadCustomerData()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Populate DataGridView with DB2 Records
    Private Sub LoadCustomerData()
        Try
            Dim str As String
            Dim cmd As DB2Command
            Dim da As DB2DataAdapter

            str = "SELECT CustID, LName, FName, MInitial, CurrDiscount, LastPurchaseDate, DiscountExpiryDate FROM CUSTOMER ORDER BY CustID DESC"
            cmd = New DB2Command(str, DBConn)
            da = New DB2DataAdapter(cmd)

            dtCustomer = New DataTable()
            da.Fill(dtCustomer)

            dvCustomer = New DataView(dtCustomer)
            dgvCustomers.DataSource = dvCustomer
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Real-time ID Filter Search Box
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If dvCustomer IsNot Nothing Then
                Dim filterText As String = txtSearch.Text.Trim()
                If String.IsNullOrEmpty(filterText) Then
                    dvCustomer.RowFilter = String.Empty
                Else
                    ' Filters integer ID cast to string for partial matches
                    dvCustomer.RowFilter = String.Format("CONVERT(CustID, 'System.String') LIKE '%{0}%'", filterText.Replace("'", "''"))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Populate fields when clicking a row in DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtCustId.Text = row.Cells("CustID").Value.ToString()
            txtCustLName.Text = If(IsDBNull(row.Cells("LName").Value), "", row.Cells("LName").Value.ToString())
            txtCustFName.Text = If(IsDBNull(row.Cells("FName").Value), "", row.Cells("FName").Value.ToString())
            txtCustMInitial.Text = If(IsDBNull(row.Cells("MInitial").Value), "", row.Cells("MInitial").Value.ToString())

            ' Set discount radio buttons based on value
            Dim discVal As Decimal = 0D
            If Not IsDBNull(row.Cells("CurrDiscount").Value) Then
                discVal = Convert.ToDecimal(row.Cells("CurrDiscount").Value)
            End If

            currDisc8.Checked = (discVal = 0.08D)
            currDisc13.Checked = (discVal = 0.13D)
            currDisc15.Checked = (discVal = 0.15D)
        End If
    End Sub

    ' UPDATE BUTTON
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCustId.Text) Then
            MsgBox("Please select a customer record to edit.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(Me.txtCustLName.Text) Then
            MsgBox("Please input last name.", MsgBoxStyle.Exclamation)
            txtCustLName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(Me.txtCustFName.Text) Then
            MsgBox("Please input first name.", MsgBoxStyle.Exclamation)
            txtCustFName.Focus()
            Exit Sub
        End If

        Try
            Dim str As String
            Dim cmd As DB2Command
            Dim pr1, pr2, pr3, pr4 As DB2Parameter

            str = "call UPDATE_CUSTOMER(?, ?, ?, ?)"
            cmd = New DB2Command(str, DBConn)

            ' Parameter 1: Last Name
            pr2 = cmd.Parameters.Add("@p1", DB2Type.VarChar)
            pr2.Direction = ParameterDirection.Input
            cmd.Parameters("@p1").Value = txtCustLName.Text.Trim()

            ' Parameter 2: First Name
            pr3 = cmd.Parameters.Add("@p2", DB2Type.VarChar)
            pr3.Direction = ParameterDirection.Input
            cmd.Parameters("@p2").Value = txtCustFName.Text.Trim()

            ' Parameter 3: Middle Initial
            pr4 = cmd.Parameters.Add("@p3", DB2Type.Char)
            pr4.Direction = ParameterDirection.Input
            cmd.Parameters("@p3").Value = If(String.IsNullOrWhiteSpace(txtCustMInitial.Text), DBNull.Value, txtCustMInitial.Text.Trim())

            ' Parameter 4: Discount
            Dim VDiscType As Decimal = 0D
            If currDisc8.Checked Then VDiscType = 0.08D
            If currDisc13.Checked Then VDiscType = 0.13D
            If currDisc15.Checked Then VDiscType = 0.15D

            pr5 = cmd.Parameters.Add("@p4", DB2Type.Decimal)
            pr5.Direction = ParameterDirection.Input
            cmd.Parameters("@p5").Value = VDiscType

            cmd.ExecuteNonQuery()

            MsgBox("Success! Customer record updated.", MsgBoxStyle.Information)

            ' Refresh Grid & Clear inputs
            LoadCustomerData()
            ClearForm()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearForm()
        txtCustId.Clear()
        txtCustLName.Clear()
        txtCustFName.Clear()
        txtCustMInitial.Clear()
        currDisc8.Checked = False
        currDisc13.Checked = False
        currDisc15.Checked = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DBConn.Close()
        Me.Close()
    End Sub
End Class

