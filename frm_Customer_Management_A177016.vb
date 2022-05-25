Public Class frm_Customer_Management_A177016
    Private Sub frm_add_Customer_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_Grid()
        pic_Me.Image = Image.FromFile("me.jpg")
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

        txt_CustomerID.Text = generate_CustomerID()
        AssignValidation(Me.txt_CustomerNo, ValidationType.Phone_Number)
    End Sub
    Private Sub Refresh_Grid()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A177016 ORDER BY FLD_CUSTOMER_ID ASC;"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_Customer.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_CustomerID.Text = ""
        txt_CustomerName.Text = ""
        txt_CustomerNo.Text = ""

    End Sub
    Private Function generate_CustomerID() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A177016").Rows(0).Item("LASTID")


        Dim newID As String = "C00" & Mid(lastmatric, 2) + 1
        Return newID


    End Function

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click

        clear_fields()
        txt_CustomerID.Text = generate_CustomerID()
        generate_CustomerID()

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_Customer.CurrentRow.Index
        txt_CustomerID.Text = grd_Customer(0, current_row).Value
        txt_CustomerName.Text = grd_Customer(1, current_row).Value
        txt_CustomerNo.Text = grd_Customer(2, current_row).Value
    End Sub

    Private Sub grd_Customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Customer.CellClick
        get_current_code()

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            run_sql_command("UPDATE  TBL_CUSTOMER_A177016 SET FLD_CUSTOMER_NAME= '" & txt_CustomerName.Text & "',FLD_CUSTOMER_PHONE_NUMBER='" & txt_CustomerNo.Text & "' WHERE FLD_CUSTOMER_ID='" & txt_CustomerID.Text & "'")
            Beep()
            MsgBox("You have successfully updated the Customer """ & txt_CustomerID.Text & """.")
            Refresh_Grid()
            clear_fields()
            get_current_code()
        Catch
            MsgBox("NO2")
        End Try
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & txt_CustomerID.Text & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A177016 WHERE FLD_CUSTOMER_ID='" & txt_CustomerID.Text & "'")
            Beep()
            MsgBox("The Customer""" & txt_CustomerID.Text & """ has been successfully deleted.")
            Refresh_Grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A177016 VALUES ('" & txt_CustomerID.Text & "', '" & txt_CustomerName.Text & "', " & txt_CustomerNo.Text & ")"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_Customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A177016")
            txt_CustomerID.Text = generate_CustomerID()
            txt_CustomerName.Text = ""
            txt_CustomerNo.Text = ""

            Refresh_Grid()
            clear_fields()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        frm_Catalog_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_Customer_A177016.Show()
        Me.Hide()

    End Sub
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_Staff_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_detail_Click(sender As Object, e As EventArgs) Handles btn_order_detail.Click
        frm_Order_Details_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click_1(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_Order_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_drop_down_MouseHover(sender As Object, e As EventArgs) Handles btn_order_drop_down.MouseHover
        drop_panel.Size = drop_panel.MaximumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub btn_product_MouseHover(sender As Object, e As EventArgs) Handles btn_product.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs)
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub
    Private Sub btn_catalog_MouseHover(sender As Object, e As EventArgs) Handles btn_catalog.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub btn_customer_MouseHover(sender As Object, e As EventArgs) Handles btn_customer.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub btn_staff_MouseHover(sender As Object, e As EventArgs) Handles btn_staff.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub frm_Product_A177016_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub btn_gallery_MouseHover(sender As Object, e As EventArgs) Handles btn_gallery.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

    End Sub

    Private Sub btn_gallery_Click(sender As Object, e As EventArgs) Handles btn_gallery.Click
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel.MinimumSize

    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MaximumSize
    End Sub

    Private Sub btn_admin_MouseHover(sender As Object, e As EventArgs) Handles btn_admin.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MaximumSize

    End Sub

    Private Sub btn_productManagement_Click(sender As Object, e As EventArgs) Handles btn_productManagement.Click
        frm_Product_Management_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staffManagement_Click(sender As Object, e As EventArgs) Handles btn_staffManagement.Click
        frm_Staff_Management_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customerManagement_Click(sender As Object, e As EventArgs) Handles btn_customerManagement.Click
        Me.Refresh()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic_Me.Click
        MsgBox("Creator : Mohamad Anwar Bin Bujang")

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub grd_Staff_MouseHover(sender As Object, e As EventArgs) Handles grd_Customer.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub PanelAdd_MouseHover(sender As Object, e As EventArgs) Handles PanelAdd.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub frm_Customer_Management_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub
End Class