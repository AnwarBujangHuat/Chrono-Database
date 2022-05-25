Imports System.IO

Public Class frm_Product_Management_A177016
    Dim defaultpicture As String = Application.StartupPath & "\Images\unknown.png"
    Private Sub frm_add_Product_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_Grid()
        pic_Me.Image = Image.FromFile("me.jpg")
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize

        txt_picture.Text = defaultpicture
        picbox_watch.BackgroundImage = Image.FromFile(defaultpicture)
        txt_Productid.Text = generate_ProductID()

        AssignValidation(Me.txt_Productprice, ValidationType.Only_Numbers)
        AssignValidation(Me.txt_Productbezel, ValidationType.Only_Characters)
        AssignValidation(Me.txt_Productdial, ValidationType.Only_Characters)
        AssignValidation(Me.txt_Productgender, ValidationType.Only_Characters)
        AssignValidation(Me.txt_Productstrap, ValidationType.Only_Characters)
        AssignValidation(Me.txt_Productdiameter, ValidationType.Only_Numbers)
        AssignValidation(Me.txt_Productwarranty, ValidationType.Only_Numbers)
        AssignValidation(Me.txt_Productquantity, ValidationType.Only_Numbers)




    End Sub
    Private Sub Refresh_Grid()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A177016  ORDER BY FLD_PRODUCT_ID ASC;"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_Product.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()


        txt_Productid.Text = ""
        txt_Productbrand.Text = ""
        txt_Productname.Text = ""
        txt_Productprice.Text = ""
        txt_Productbezel.Text = ""
        txt_Productdial.Text = ""
        txt_Productstrap.Text = ""
        txt_Productgender.Text = ""
        txt_Productwaterproof.Text = ""
        txt_Productdiameter.Text = ""
        txt_Productwarranty.Text = ""
        txt_Productquantity.Text = ""





    End Sub
    Private Function generate_ProductID() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A177016").Rows(0).Item("LASTID")


        Dim newID As String = "R0" & Mid(lastmatric, 2) + 1
        Return newID


    End Function


    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        picbox_watch.BackgroundImage = Image.FromFile(defaultpicture)
        clear_fields()
        txt_Productid.Text = generate_ProductID()
        generate_ProductID()

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_Product.CurrentRow.Index

        txt_Productid.Text = grd_Product(0, current_row).Value
        txt_Productbrand.Text = grd_Product(1, current_row).Value
        txt_Productname.Text = grd_Product(2, current_row).Value
        txt_Productprice.Text = grd_Product(3, current_row).Value
        txt_Productbezel.Text = grd_Product(4, current_row).Value
        txt_Productdial.Text = grd_Product(5, current_row).Value
        txt_Productstrap.Text = grd_Product(6, current_row).Value
        txt_Productgender.Text = grd_Product(7, current_row).Value
        txt_Productwaterproof.Text = grd_Product(8, current_row).Value
        txt_Productdiameter.Text = grd_Product(9, current_row).Value
        txt_Productwarranty.Text = grd_Product(10, current_row).Value
        txt_Productquantity.Text = grd_Product(11, current_row).Value

        picbox_watch.BackgroundImage = SafeImageFromFile("Pictures/" & txt_Productid.Text & ".png")
    End Sub

    Private Sub grd_Product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Product.CellClick
        get_current_code()

    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try

            run_sql_command("UPDATE  TBL_PRODUCT_A177016 SET FLD_BRAND= '" & txt_Productbrand.Text & "',FLD_PRODUCT_NAME='" & txt_Productname.Text &
                            "',FLD_PRICE='" & txt_Productprice.Text & "',FLD_BEZEL='" & txt_Productbezel.Text & "',FLD_DIAL_COLOUR='" & txt_Productdial.Text & "',FLD_STRAP_COLOUR='" & txt_Productstrap.Text &
                            "',FLD_GENDER='" & txt_Productgender.Text & "',FLD_DETAIL='" & txt_Productwaterproof.Text & "',FLD_DIAMETER='" & txt_Productdiameter.Text & "',FLD_WARRANTY='" & txt_Productwarranty.Text &
                            "',FLD_QUANTITY='" & txt_Productquantity.Text & "' WHERE FLD_PRODUCT_ID='" & txt_Productid.Text & "'")
            Beep()
            MsgBox("You have successfully updated the product """ & txt_Productid.Text & """.")
            Refresh_Grid()
            clear_fields()
            get_current_code()
        Catch
            MsgBox("NO2")
        End Try
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        picbox_watch.BackgroundImage = Nothing
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & txt_Productid.Text & """?", MsgBoxStyle.YesNo)
        Dim id As String = txt_Productid.Text
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A177016 WHERE FLD_PRODUCT_ID='" & txt_Productid.Text & "'")
            Beep()
            MsgBox("The Product""" & txt_Productid.Text & """ has been successfully deleted.")
            Refresh_Grid()
            clear_fields()
            System.IO.File.Delete("Pictures\" & id & ".png")


        End If

    End Sub
    Public Shared Function SafeImageFromFile(id As String) As Image

        Using fs As New FileStream(id, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using

    End Function

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCT_A177016 VALUES ('" & txt_Productid.Text & "', '" & txt_Productbrand.Text & "','" & txt_Productname.Text & "', '" & txt_Productprice.Text & "','" & txt_Productbezel.Text & "', '" & txt_Productdial.Text & "','" & txt_Productstrap.Text & "', '" & txt_Productgender.Text & "','" & txt_Productwaterproof.Text & "', '" & txt_Productdiameter.Text & "','" & txt_Productwarranty.Text & "', '" & txt_Productquantity.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_Productid.Text & ".png")
            picbox_watch.BackgroundImage = Image.FromFile(defaultpicture)

            grd_Product.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A177016")
            txt_Productid.Text = generate_ProductID()
            txt_Productbrand.Text = ""
            txt_Productname.Text = ""
            txt_Productprice.Text = ""
            txt_Productbezel.Text = ""
            txt_Productdial.Text = ""
            txt_Productstrap.Text = ""
            txt_Productgender.Text = ""
            txt_Productwaterproof.Text = ""
            txt_Productdiameter.Text = ""
            txt_Productwarranty.Text = ""
            txt_Productquantity.Text = ""

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
        Me.Refresh()
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

    Private Sub grd_Staff_MouseHover(sender As Object, e As EventArgs) Handles grd_Product.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub PanelAdd_MouseHover(sender As Object, e As EventArgs) Handles PanelAdd.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub btn_addImage_Click(sender As Object, e As EventArgs) Handles btn_addImage.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PNG files (*.png)|*.png"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picbox_watch.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Else
            picbox_watch.BackgroundImage = Image.FromFile(defaultpicture)
        End If

        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub grd_Product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Product.CellContentClick

    End Sub

    Private Sub PanelAdd_Paint(sender As Object, e As PaintEventArgs) Handles PanelAdd.Paint

    End Sub

    Private Sub frm_Product_Management_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub
End Class