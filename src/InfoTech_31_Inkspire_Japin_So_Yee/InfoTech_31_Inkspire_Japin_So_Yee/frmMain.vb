Imports IBM.Data.DB2

Public Class frmMain
    Private DConn As Common.DbConnection

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = btnSalesTransAdd
    End Sub

    Private Sub btnCustAdd_Click(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        frmCustAdd.Show()
    End Sub
    
    Private Sub btnCustEdit_Click(sender As Object, e As EventArgs) Handles btnCustEdit.Click
        frmCustEdit.Show()
    End Sub

    Private Sub btnCustDelete_Click(sender As Object, e As EventArgs) Handles btnCustDelete.Click
        frmCustDelete.Show()
    End Sub

    Private Sub btnEmpAdd_Click(sender As Object, e As EventArgs) Handles btnEmpAdd.Click
        frmEmpAdd.Show()
    End Sub

    Private Sub btnEmpEdit_Click(sender As Object, e As EventArgs) Handles btnEmpEdit.Click
        frmEmpEdit.Show()
    End Sub

    Private Sub btnEmpDelete_Click(sender As Object, e As EventArgs) Handles btnEmpDelete.Click
        frmEmpDelete.Show()
    End Sub

    Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        frmItemAdd.Show()
    End Sub

    Private Sub btnItemEdit_Click(sender As Object, e As EventArgs) Handles btnItemEdit.Click
        frmItemEdit.Show()
    End Sub

    Private Sub btnItemDelete_Click(sender As Object, e As EventArgs) Handles btnItemDelete.Click
        frmItemDelete.Show()
    End Sub

    Private Sub btnSalesTransAdd_Click(sender As Object, e As EventArgs) Handles btnSalesTransAdd.Click
        frmSalesTransAdd.Show()
    End Sub

    Private Sub btnSalesTransView_Click(sender As Object, e As EventArgs) Handles btnSalesTransView.Click
        frmSalesTransView.Show()
    End Sub
    
    Private Sub btnCustAudit_Click(sender As Object, e As EventArgs) Handles btnCustAudit.Click
        frmCustAudit.Show()
    End Sub

    Private Sub btnEmpAudit_Click(sender As Object, e As EventArgs) Handles btnEmpAudit.Click
        frmEmpAudit.Show()
    End Sub

    Private Sub btnItemAudit_Click(sender As Object, e As EventArgs) Handles btnItemAudit.Click
        frmItemAudit.Show()
    End Sub

    Private Sub btnSalesTransAudit_Click(sender As Object, e As EventArgs) Handles btnSalesTransAudit.Click
        frmSalesTransAudit.Show()
    End Sub

    
    Private Sub btnEmpView_Click(sender As Object, e As EventArgs) Handles btnEmpView.Click
        frmEmpView.Show()
    End Sub

    Private Sub btnCustView_Click(sender As Object, e As EventArgs) Handles btnCustView.Click
        frmCustView.Show()
    End Sub

    Private Sub btnItemView_Click(sender As Object, e As EventArgs) Handles btnItemView.Click
        frmItemView.Show()
    End Sub
End Class
