Public Class frm_Order_Details_A177016
    Dim Totals As Integer = 0
    Private Sub frm_Order_Details_A177016_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        pic_Me.Image = Image.FromFile("me.jpg")
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
        DisplayInvois("O001")
        Datagrid_order.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub
    Private Sub refresh_grid()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Luxurious TimePiece Collection(Swiss Edition).accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A177016 ORDER BY FLD_ORDER_ID ASC "
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_Order_id.DataSource = mydatatable
        lst_Order_id.DisplayMember = "FLD_ORDER_ID"
    End Sub


    Private Sub lst_Order_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_Order_id.MouseClick
        DisplayInvois(lst_Order_id.Text)

    End Sub



    Private Sub DisplayInvois(orderID As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A177016 WHERE FLD_ORDER_ID='" & orderID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        For row As Integer = 0 To Me.Datagrid_order.RowCount - 1
            For Each rows As DataGridViewRow In Datagrid_order.Rows
                Datagrid_order.Rows.Remove(rows)
            Next
            Totals = 0
        Next
        lbl_order_id.Text = orderID
        lbl_customerID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        lbl_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_DATE_ORDERED")

        Dim mysql2 As String = "SELECT * FROM TBL_ORDER_DETAILS_A177016 WHERE FLD_ORDER_ID='" & orderID & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        Dim totalrow As String = run_sql_query("SELECT COUNT (*) AS TOTALROW FROM TBL_ORDER_DETAILS_A177016 WHERE FLD_ORDER_ID='" & orderID & "'").Rows(0).Item("TOTALROW")
        Dim totalrowcount As Integer = totalrow


        For i As Integer = 0 To totalrowcount - 1
            'Dim PRODUCTID As String = mydatatable2.Rows(i).Item("FLD_PRODUCT_ID")
            Dim mysql3 As String = "SELECT * FROM TBL_PRODUCT_A177016 WHERE FLD_PRODUCT_ID='" & mydatatable2.Rows(i).Item("FLD_PRODUCT_ID") & "'"
            Dim mydatatable3 As New DataTable
            Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
            myreader3.Fill(mydatatable3)

            Dim PRODUCTNAME As String = mydatatable3.Rows(0).Item("FLD_PRODUCT_NAME")
            Me.Datagrid_order.Rows.Add(PRODUCTNAME, mydatatable2.Rows(i).Item("FLD_QUANTITY"), mydatatable2.Rows(i).Item("FLD_TOTAL_PRICE"))
            CalculatedTotal(mydatatable2.Rows(i).Item("FLD_TOTAL_PRICE"))
        Next

    End Sub

    Private Sub CalculatedTotal(prices As Integer)

        Dim FinalTotal As Integer = Totals + prices
        Totals = FinalTotal
        txt_total.Text = Totals

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

        Me.Refresh()
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

    Private Sub frm_Order_Details_A177016_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_MainMenu_A177016.Close()
    End Sub



    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        drop_panel.Size = drop_panel.MinimumSize
        drop_panel2.Size = drop_panel2.MinimumSize
        drop_panel3.Size = drop_panel3.MinimumSize
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_MainMenu_A177016.Show()
        Me.Hide()
    End Sub
End Class