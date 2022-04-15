Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Sub Login()
        Dim SQLConn As SqlConnection
        SQLConn = New SqlConnection("Data Source = LAPTOP-266TTPJD; Initial Catalog=ASPLogin; Integrated Security= True;")
        Dim SQLAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * from useraccount WHERE UserName='" + txtusername.Text + "'AND Password='" + txtpassword.Text + "';", SQLConn)
        Dim DT As DataTable = New DataTable
        SQLAdapter.Fill(DT)

        If DT.Rows.Count Then
            messagelbl.Visible = True

            messagelbl.Text = "Succcessful Login"
            messagelbl.BackColor = System.Drawing.Color.Green
        Else
            messagelbl.Visible = True
            messagelbl.Text = "Failed Login"
            messagelbl.BackColor = System.Drawing.Color.Red
        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()

    End Sub
End Class