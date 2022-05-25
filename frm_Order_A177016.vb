Public Class frm_Order_A177016

    Dim newtotal As Integer = 0
    Dim subtotal As Integer
    Private Sub frm_Order_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        pic_Me.Image = Image.FromFile("me.jpg")
        picbox_Id.BackgroundImage = Image.FromFile("Pictures/R001.png")
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
        staff_combobox.SelectedIndex = 0
        Customer_combobox.SelectedIndex = 0
        Quantity_combobox.SelectedIndex = 0
        Selected_Product("R001")
        Timer1.Enabled = True
        date_lbl.Text = Date.Now.ToString("dd-MM-yyyy  HH:mm:ss")
        generate_OrderID()
    End Sub
    Private Sub refresh_grid()

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A177016  ORDER BY FLD_STAFF_ID ASC;"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        staff_combobox.DataSource = mydatatable
        staff_combobox.DisplayMember = "FLD_STAFF_ID"
        lbl_order.Text = generate_OrderID()



        Dim myconnection2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A177016  ORDER BY FLD_CUSTOMER_ID ASC;"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection2)
        myreader2.Fill(mydatatable2)
        Customer_combobox.DataSource = mydatatable2
        Customer_combobox.DisplayMember = "FLD_CUSTOMER_ID"

        Dim myconnection3 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql3 As String = "SELECT * FROM TBL_PRODUCT_A177016 ORDER BY FLD_PRODUCT_ID ASC;"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection3)
        myreader3.Fill(mydatatable3)
        lst_Product_id.DataSource = mydatatable3
        lst_Product_id.DisplayMember = "FLD_PRODUCT_ID"

    End Sub
    Private Function generate_OrderID() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A177016").Rows(0).Item("LASTID")


        Dim newID As String = "O00" & Mid(lastmatric, 2) + 1
        Return newID


    End Function
    Private Sub btn_cart_Click(sender As Object, e As EventArgs) Handles btn_cart.Click
        Dim price As Integer
        Dim quantityproduct As Integer

        lbl_customer.Text = Customer_combobox.Text
        lbl_staff.Text = staff_combobox.Text
        price = txt_product_price.Text
        quantityproduct = Quantity_combobox.Text


        ' For row As Integer = 0 To Me.OrderTable.RowCount - 1


        For Each rows As DataGridViewRow In OrderTable.Rows


                If (rows.Cells(0).Value = txt_product_id.Text) Then
                    rows.Cells(1).Value = Val(rows.Cells(1).Value) + quantityproduct
                    rows.Cells(2).Value = rows.Cells(1).Value * price
                    subtotal = quantityproduct * price
                UpdatePrice(subtotal)

                Return
            Else


            End If
            ' Next
        Next
        subtotal = quantityproduct * price

        Me.OrderTable.Rows.Add(txt_product_id.Text, Quantity_combobox.Text, subtotal)
        UpdatePrice(subtotal)

        Refresh()
    End Sub
    Private Sub UpdatePrice(subtotal As String)


        Dim totalprice As Integer = newtotal + subtotal
        newtotal = totalprice
        lbl_total.Text = newtotal

    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim orderids As String = lbl_order.Text
            Dim customerids As String = lbl_customer.Text
            Dim staffids As String = lbl_staff.Text


            Dim mysqls As String = "INSERT INTO TBL_ORDER_A177016 VALUES ('" & orderids & "', '" & customerids & "', '" & staffids & "', '" & Date.Today & "')"
            Dim mywriters As New OleDb.OleDbCommand(mysqls, myconnection2, mytransaction)
            MsgBox("Transaction 1 successful!")
            mywriters.ExecuteNonQuery()

            ' MsgBox("Transaction  2.1 successful!")
            For i As Integer = 0 To Me.OrderTable.RowCount - 1
                Dim orderidss As String = lbl_order.Text
                Dim productids As String = Me.OrderTable(0, i).Value
                Dim quantitys As String = Me.OrderTable(1, i).Value
                Dim tprices As String = Me.OrderTable(2, i).Value
                ' MsgBox("Transaction  2 successful!")
                Dim mysqlquantity As String = "SELECT * FROM TBL_PRODUCT_A177016 WHERE FLD_PRODUCT_ID='" & productids & "'"
                Dim mydatatablequant As New DataTable
                Dim myreader As New OleDb.OleDbDataAdapter(mysqlquantity, myconnection)
                myreader.Fill(mydatatablequant)
                Dim mysqlcurrentquant As String = mydatatablequant.Rows(0).Item("FLD_QUANTITY")
                Dim quant As Integer = mysqlcurrentquant - quantitys
                If (quant = 0) Then
                    MsgBox("Product is out fo stock")
                End If
                run_sql_query("UPDATE TBL_PRODUCT_A177016 SET FLD_QUANTITY='" & quant & "' WHERE FLD_PRODUCT_ID='" & productids & "'")
                Dim mysql As String = "INSERT INTO TBL_ORDER_DETAILS_A177016 VALUES ('" & orderidss & "', '" & productids & "', '" & quantitys & "', '" & tprices & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                mywriter.ExecuteNonQuery()

            Next

            mytransaction.Commit()
            myconnection2.Close()


            Beep()
            MsgBox("Transaction successful!")

        Catch ex As Exception

            Beep()
            MsgBox("Transaction FAILED!")

            mytransaction.Rollback()
            myconnection2.Close()

        End Try




    End Sub


    Private Sub Selected_Product(Id As String)


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
        txt_product_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        picbox_Id.BackgroundImage = Image.FromFile("Pictures/" & Id & ".png")
        Dim brand As String = mydatatable.Rows(0).Item("FLD_BRAND")



    End Sub

    Private Sub lst_Product_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_Product_id.MouseClick
        Selected_Product(lst_Product_id.Text)

    End Sub


    Private Sub Customer_combobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Customer_combobox.SelectedValueChanged

        Try
            Selected_Customer(Customer_combobox.Text)
        Catch ex As Exception


        End Try

    End Sub


    Private Sub Selected_Customer(CustomerId As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A177016 WHERE FLD_CUSTOMER_ID='" & CustomerId & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        customer_id.Text = CustomerId
        customer_name.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        customer_phone.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_PHONE_NUMBER")



    End Sub

    Private Sub staff_combobox_SelectedValueChanged(sender As Object, e As EventArgs) Handles staff_combobox.SelectedValueChanged
        Try
            Selected_Staff(staff_combobox.Text)
        Catch ex As Exception


        End Try
    End Sub
    Private Sub Selected_Staff(Staffid As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A177016 WHERE FLD_STAFF_ID='" & Staffid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        staff_id.Text = Staffid
        staff_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        staff_phone.Text = mydatatable.Rows(0).Item("FLD_STAFF_PHONE_NUMBER")




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
        Me.Refresh()
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

    Private Sub grd_Customer_MouseHover(sender As Object, e As EventArgs)
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub frm_Order_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()
    End Sub



    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub OrderTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderTable.CellContentClick

    End Sub

    Private Sub drop_panel2_Paint(sender As Object, e As PaintEventArgs) Handles drop_panel2.Paint

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub


End Class