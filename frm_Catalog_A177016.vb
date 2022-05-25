Public Class frm_Catalog_A177016
    Private Sub Catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_Grid()
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
        pic_Me.Image = Image.FromFile("me.jpg")
        refresh_text(lst_Product_id.Text)
        picbox_Id.BackgroundImage = Image.FromFile("Pictures/R001.png")
        picbox_brand.BackgroundImage = Image.FromFile("Images/Rolex.png")




    End Sub


    Private Sub Refresh_Grid()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A177016 ORDER BY FLD_PRODUCT_ID ASC;"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_Product_id.DataSource = mydatatable
        lst_Product_id.DisplayMember = "FLD_PRODUCT_ID"

    End Sub



    Private Sub refresh_text(Id As String)


        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A177016 WHERE FLD_PRODUCT_ID='" & Id & "'"


        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_product_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_product_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_product_bezel.Text = mydatatable.Rows(0).Item("FLD_BEZEL")
        txt_product_dial.Text = mydatatable.Rows(0).Item("FLD_DIAL_COLOUR")
        txt_product_strap.Text = mydatatable.Rows(0).Item("FLD_STRAP_COLOUR")
        txt_product_gender.Text = mydatatable.Rows(0).Item("FLD_GENDER")
        txt_product_detail.Text = mydatatable.Rows(0).Item("FLD_DETAIL")
        txt_product_diameter.Text = mydatatable.Rows(0).Item("FLD_DIAMETER")
        txt_product_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_product_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        picbox_Id.BackgroundImage = Image.FromFile("Pictures/" & Id & ".png")
        Dim brand As String = mydatatable.Rows(0).Item("FLD_BRAND")
        picbox_brand.BackgroundImage = Image.FromFile("Images/" & brand & ".png")


    End Sub

    Private Sub lst_Product_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_Product_id.MouseClick
        refresh_text(lst_Product_id.Text)

    End Sub
    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_A177016.Show()
        Me.Hide()

    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        Me.Refresh()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_Customer_A177016.Show()
        Me.Close()

    End Sub
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_Staff_A177016.Show()
        Me.Close()
    End Sub

    Private Sub btn_order_detail_Click(sender As Object, e As EventArgs) Handles btn_order_detail.Click
        frm_Order_Details_A177016.Show()
        Me.Close()
    End Sub

    Private Sub btn_order_Click_1(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_Order_A177016.Show()
        Me.HIde()
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
        frm_Customer_Management_A177016.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic_Me.Click
        MsgBox("Creator : Mohamad Anwar Bin Bujang")

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub picbox_Id_MouseHover(sender As Object, e As EventArgs) Handles picbox_Id.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub lst_Product_id_MouseHover(sender As Object, e As EventArgs) Handles lst_Product_id.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub picbox_brand_MouseHover(sender As Object, e As EventArgs) Handles picbox_brand.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub frm_Catalog_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()
    End Sub

    Private Sub lst_Product_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Product_id.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub
End Class
