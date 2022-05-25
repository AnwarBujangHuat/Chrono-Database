Public Class frm_MainMenu_A177016


    Private Sub frm_MainMenu_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
        picbox_display.BackgroundImage = Image.FromFile("Catch The Essence of perfect Time/1.png")
        pic_Me.Image = Image.FromFile("me.jpg")

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_Product_A177016.Show()
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
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub

    Private Sub btn_gallery_MouseHover(sender As Object, e As EventArgs) Handles btn_gallery.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MaximumSize
        drop_panel3.Size = drop_panel3.MinimumSize


    End Sub
    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

    End Sub

    Private Sub picbox_display_MouseHover(sender As Object, e As EventArgs) Handles picbox_display.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

    End Sub

    Private Sub btn_display_MouseHover(sender As Object, e As EventArgs) Handles btn_display.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

    End Sub
    Private Sub picbox_display_Click_1(sender As Object, e As EventArgs) Handles picbox_display.Click
        Dim DisplayCounter As Integer
        DisplayCounter = Int((3 * Rnd()) + 1)
        picbox_display.Image = Image.FromFile("Catch The Essence of perfect Time/" & DisplayCounter & ".png")


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
        frm_Customer_Management_A177016.Show()
        Me.Hide()
    End Sub
    Private Sub btn_display_Click_1(sender As Object, e As EventArgs) Handles btn_display.Click
        Dim DisplayCounter As Integer
        DisplayCounter = Int((5 * Rnd()) + 1)
        picbox_display.Image = Image.FromFile("Catch The Essence of perfect Time/" & DisplayCounter & ".png")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic_Me.Click
        MsgBox("Creator : Mohamad Anwar Bin Bujang")

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
