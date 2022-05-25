Public Class frm_Staff_Management_A177016

    Private Sub frm_add_Staff_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_Grid()


        pic_Me.Image = Image.FromFile("me.jpg")
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

        txt_StaffID.Text = generate_staffID()
        AssignValidation(Me.txt_StaffNo, ValidationType.Phone_Number)
    End Sub
    Private Sub Refresh_Grid()
        grd_Staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A177016 ORDER BY FLD_STAFF_ID ASC;")
    End Sub
    Private Sub clear_fields()
        txt_StaffID.Text = ""
        txt_StaffName.Text = ""
        txt_StaffNo.Text = ""

    End Sub
    Private Function generate_staffID() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A177016").Rows(0).Item("LASTID")
        Dim newID As String = "S00" & Mid(lastmatric, 2) + 1
        Return newID


    End Function


    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click

        clear_fields()
        txt_StaffID.Text = generate_staffID()
        generate_staffID()

    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If run_sql_command("INSERT INTO TBL_STAFF_A177016 VALUES ('" & txt_StaffID.Text & "', '" & txt_StaffName.Text & "', '" & txt_StaffNo.Text & "')") Then
            Beep()
            MsgBox("You have successfully added the Staff """ & txt_StaffID.Text & """.")
            Refresh_Grid()
            clear_fields()
        End If


    End Sub


    Private Sub get_current_code()
        Dim current_row As Integer = grd_Staff.CurrentRow.Index
        txt_StaffID.Text = grd_Staff(0, current_row).Value
        txt_StaffName.Text = grd_Staff(1, current_row).Value
        txt_StaffNo.Text = grd_Staff(2, current_row).Value
    End Sub

    Private Sub grd_Staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Staff.CellClick
        get_current_code()

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            run_sql_command("UPDATE  TBL_STAFF_A177016 SET FLD_STAFF_NAME= '" & txt_StaffName.Text & "',FLD_STAFF_PHONE_NUMBER='" & txt_StaffNo.Text & "' WHERE FLD_STAFF_ID='" & txt_StaffID.Text & "'")
            Beep()
            MsgBox("You have successfully updated the Staff """ & txt_StaffID.Text & """.")
            Refresh_Grid()
            clear_fields()
            get_current_code()
        Catch
            MsgBox("NOOB SHIT")
        End Try
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & txt_StaffID.Text & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A177016 WHERE FLD_STAFF_ID='" & txt_StaffID.Text & "'")
            Beep()
            MsgBox("The Staff """ & txt_StaffID.Text & """ has been successfully deleted.")
            Refresh_Grid()
            clear_fields()
            get_current_code()
        End If
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
        Me.Refresh()
    End Sub

    Private Sub btn_customerManagement_Click(sender As Object, e As EventArgs) Handles btn_customerManagement.Click
        frm_Customer_Management_A177016.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic_Me.Click
        MsgBox("Creator : Mohamad Anwar Bin Bujang")

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub grd_Staff_MouseHover(sender As Object, e As EventArgs) Handles grd_Staff.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub PanelAdd_MouseHover(sender As Object, e As EventArgs) Handles PanelAdd.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub grd_Staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Staff.CellContentClick

    End Sub

    Private Sub frm_Staff_Management_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()

    End Sub
End Class