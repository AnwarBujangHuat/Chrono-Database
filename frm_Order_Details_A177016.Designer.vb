<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Order_Details_A177016
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.drop_panel2 = New System.Windows.Forms.Panel()
        Me.btn_catalog = New System.Windows.Forms.Button()
        Me.btn_gallery = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.pic_Me = New System.Windows.Forms.PictureBox()
        Me.drop_panel = New System.Windows.Forms.Panel()
        Me.btn_order_drop_down = New System.Windows.Forms.Button()
        Me.btn_order_detail = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drop_panel3 = New System.Windows.Forms.Panel()
        Me.btn_customerManagement = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.btn_staffManagement = New System.Windows.Forms.Button()
        Me.btn_productManagement = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Datagrid_order = New System.Windows.Forms.DataGridView()
        Me.PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_Order_id = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.drop_panel2.SuspendLayout()
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drop_panel.SuspendLayout()
        Me.drop_panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Datagrid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drop_panel2
        '
        Me.drop_panel2.Controls.Add(Me.btn_catalog)
        Me.drop_panel2.Controls.Add(Me.btn_gallery)
        Me.drop_panel2.Controls.Add(Me.btn_product)
        Me.drop_panel2.Location = New System.Drawing.Point(549, 2)
        Me.drop_panel2.MaximumSize = New System.Drawing.Size(184, 289)
        Me.drop_panel2.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel2.Name = "drop_panel2"
        Me.drop_panel2.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel2.TabIndex = 89
        '
        'btn_catalog
        '
        Me.btn_catalog.AllowDrop = True
        Me.btn_catalog.BackColor = System.Drawing.Color.Black
        Me.btn_catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_catalog.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_catalog.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_catalog.Location = New System.Drawing.Point(16, 189)
        Me.btn_catalog.Name = "btn_catalog"
        Me.btn_catalog.Size = New System.Drawing.Size(153, 84)
        Me.btn_catalog.TabIndex = 29
        Me.btn_catalog.Text = "Catalog"
        Me.btn_catalog.UseVisualStyleBackColor = False
        '
        'btn_gallery
        '
        Me.btn_gallery.AllowDrop = True
        Me.btn_gallery.BackColor = System.Drawing.Color.Black
        Me.btn_gallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_gallery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_gallery.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gallery.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_gallery.Location = New System.Drawing.Point(16, 0)
        Me.btn_gallery.Name = "btn_gallery"
        Me.btn_gallery.Size = New System.Drawing.Size(153, 94)
        Me.btn_gallery.TabIndex = 28
        Me.btn_gallery.Text = "Gallery"
        Me.btn_gallery.UseVisualStyleBackColor = False
        '
        'btn_product
        '
        Me.btn_product.AllowDrop = True
        Me.btn_product.BackColor = System.Drawing.Color.Black
        Me.btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_product.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_product.Location = New System.Drawing.Point(16, 99)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(153, 84)
        Me.btn_product.TabIndex = 27
        Me.btn_product.Text = "Product"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'pic_Me
        '
        Me.pic_Me.Location = New System.Drawing.Point(1556, 9)
        Me.pic_Me.Name = "pic_Me"
        Me.pic_Me.Size = New System.Drawing.Size(101, 92)
        Me.pic_Me.TabIndex = 87
        Me.pic_Me.TabStop = False
        '
        'drop_panel
        '
        Me.drop_panel.Controls.Add(Me.btn_order_drop_down)
        Me.drop_panel.Controls.Add(Me.btn_order_detail)
        Me.drop_panel.Controls.Add(Me.btn_order)
        Me.drop_panel.Location = New System.Drawing.Point(726, 2)
        Me.drop_panel.MaximumSize = New System.Drawing.Size(184, 289)
        Me.drop_panel.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel.Name = "drop_panel"
        Me.drop_panel.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel.TabIndex = 82
        '
        'btn_order_drop_down
        '
        Me.btn_order_drop_down.AllowDrop = True
        Me.btn_order_drop_down.BackColor = System.Drawing.Color.Black
        Me.btn_order_drop_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_order_drop_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_order_drop_down.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_drop_down.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_order_drop_down.Location = New System.Drawing.Point(13, 0)
        Me.btn_order_drop_down.Name = "btn_order_drop_down"
        Me.btn_order_drop_down.Size = New System.Drawing.Size(153, 94)
        Me.btn_order_drop_down.TabIndex = 5
        Me.btn_order_drop_down.Text = "Order Now"
        Me.btn_order_drop_down.UseVisualStyleBackColor = False
        '
        'btn_order_detail
        '
        Me.btn_order_detail.AllowDrop = True
        Me.btn_order_detail.BackColor = System.Drawing.Color.Black
        Me.btn_order_detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_order_detail.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_detail.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_order_detail.Location = New System.Drawing.Point(13, 189)
        Me.btn_order_detail.Name = "btn_order_detail"
        Me.btn_order_detail.Size = New System.Drawing.Size(153, 84)
        Me.btn_order_detail.TabIndex = 5
        Me.btn_order_detail.Text = " Order History"
        Me.btn_order_detail.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.AllowDrop = True
        Me.btn_order.BackColor = System.Drawing.Color.Black
        Me.btn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_order.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_order.Location = New System.Drawing.Point(13, 100)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(153, 83)
        Me.btn_order.TabIndex = 4
        Me.btn_order.Text = "New Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.AllowDrop = True
        Me.btn_staff.BackColor = System.Drawing.Color.Black
        Me.btn_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_staff.Location = New System.Drawing.Point(893, 2)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(153, 94)
        Me.btn_staff.TabIndex = 85
        Me.btn_staff.Text = "Our Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.AllowDrop = True
        Me.btn_customer.BackColor = System.Drawing.Color.Black
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_customer.Location = New System.Drawing.Point(406, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(153, 94)
        Me.btn_customer.TabIndex = 83
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1756, 10)
        Me.Panel1.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Cambria Math", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(33, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 161)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Order Details Table"
        '
        'drop_panel3
        '
        Me.drop_panel3.Controls.Add(Me.btn_customerManagement)
        Me.drop_panel3.Controls.Add(Me.btn_admin)
        Me.drop_panel3.Controls.Add(Me.btn_staffManagement)
        Me.drop_panel3.Controls.Add(Me.btn_productManagement)
        Me.drop_panel3.Location = New System.Drawing.Point(1030, 2)
        Me.drop_panel3.MaximumSize = New System.Drawing.Size(184, 370)
        Me.drop_panel3.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel3.Name = "drop_panel3"
        Me.drop_panel3.Size = New System.Drawing.Size(184, 370)
        Me.drop_panel3.TabIndex = 91
        '
        'btn_customerManagement
        '
        Me.btn_customerManagement.AllowDrop = True
        Me.btn_customerManagement.BackColor = System.Drawing.Color.Black
        Me.btn_customerManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_customerManagement.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customerManagement.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_customerManagement.Location = New System.Drawing.Point(13, 279)
        Me.btn_customerManagement.Name = "btn_customerManagement"
        Me.btn_customerManagement.Size = New System.Drawing.Size(153, 84)
        Me.btn_customerManagement.TabIndex = 6
        Me.btn_customerManagement.Text = "Customer Management"
        Me.btn_customerManagement.UseVisualStyleBackColor = False
        '
        'btn_admin
        '
        Me.btn_admin.AllowDrop = True
        Me.btn_admin.BackColor = System.Drawing.Color.Black
        Me.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_admin.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_admin.Location = New System.Drawing.Point(13, 4)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(153, 94)
        Me.btn_admin.TabIndex = 5
        Me.btn_admin.Text = "Admin"
        Me.btn_admin.UseVisualStyleBackColor = False
        '
        'btn_staffManagement
        '
        Me.btn_staffManagement.AllowDrop = True
        Me.btn_staffManagement.BackColor = System.Drawing.Color.Black
        Me.btn_staffManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_staffManagement.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staffManagement.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_staffManagement.Location = New System.Drawing.Point(13, 189)
        Me.btn_staffManagement.Name = "btn_staffManagement"
        Me.btn_staffManagement.Size = New System.Drawing.Size(153, 84)
        Me.btn_staffManagement.TabIndex = 5
        Me.btn_staffManagement.Text = "Staff Management"
        Me.btn_staffManagement.UseVisualStyleBackColor = False
        '
        'btn_productManagement
        '
        Me.btn_productManagement.AllowDrop = True
        Me.btn_productManagement.BackColor = System.Drawing.Color.Black
        Me.btn_productManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_productManagement.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productManagement.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_productManagement.Location = New System.Drawing.Point(13, 100)
        Me.btn_productManagement.Name = "btn_productManagement"
        Me.btn_productManagement.Size = New System.Drawing.Size(153, 83)
        Me.btn_productManagement.TabIndex = 4
        Me.btn_productManagement.Text = "Product Management"
        Me.btn_productManagement.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Datagrid_order)
        Me.Panel2.Controls.Add(Me.lbl_staffID)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lbl_customerID)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_total)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbl_order_id)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(344, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 581)
        Me.Panel2.TabIndex = 93
        '
        'Datagrid_order
        '
        Me.Datagrid_order.AllowUserToAddRows = False
        Me.Datagrid_order.AllowUserToDeleteRows = False
        Me.Datagrid_order.AllowUserToResizeColumns = False
        Me.Datagrid_order.AllowUserToResizeRows = False
        Me.Datagrid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_order.BackgroundColor = System.Drawing.Color.Black
        Me.Datagrid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagrid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUCT_ID, Me.QUANTITY, Me.PRICE})
        Me.Datagrid_order.GridColor = System.Drawing.Color.Black
        Me.Datagrid_order.Location = New System.Drawing.Point(88, 179)
        Me.Datagrid_order.Name = "Datagrid_order"
        Me.Datagrid_order.ReadOnly = True
        Me.Datagrid_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_order.Size = New System.Drawing.Size(1124, 245)
        Me.Datagrid_order.TabIndex = 109
        '
        'PRODUCT_ID
        '
        Me.PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRODUCT_ID.Frozen = True
        Me.PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.PRODUCT_ID.Name = "PRODUCT_ID"
        Me.PRODUCT_ID.ReadOnly = True
        Me.PRODUCT_ID.Width = 360
        '
        'QUANTITY
        '
        Me.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.QUANTITY.Frozen = True
        Me.QUANTITY.HeaderText = "QUANTITY"
        Me.QUANTITY.Name = "QUANTITY"
        Me.QUANTITY.ReadOnly = True
        Me.QUANTITY.Width = 361
        '
        'PRICE
        '
        Me.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRICE.Frozen = True
        Me.PRICE.HeaderText = "PRICE"
        Me.PRICE.Name = "PRICE"
        Me.PRICE.ReadOnly = True
        Me.PRICE.Width = 360
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.BackColor = System.Drawing.Color.Black
        Me.lbl_staffID.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.ForeColor = System.Drawing.Color.White
        Me.lbl_staffID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_staffID.Location = New System.Drawing.Point(259, 482)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(23, 25)
        Me.lbl_staffID.TabIndex = 108
        Me.lbl_staffID.Text = ": "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Location = New System.Drawing.Point(120, 482)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 25)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Staff ID"
        '
        'lbl_customerID
        '
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.BackColor = System.Drawing.Color.Black
        Me.lbl_customerID.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.ForeColor = System.Drawing.Color.White
        Me.lbl_customerID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_customerID.Location = New System.Drawing.Point(259, 452)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(23, 25)
        Me.lbl_customerID.TabIndex = 106
        Me.lbl_customerID.Text = ": "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(120, 450)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 25)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Customer ID "
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Black
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_date.Location = New System.Drawing.Point(1079, 145)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(23, 25)
        Me.lbl_date.TabIndex = 104
        Me.lbl_date.Text = ": "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(842, 454)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 25)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Total Price : RM "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(937, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 25)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Date Ordered"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Black
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(1011, 455)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(104, 22)
        Me.txt_total.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(503, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(290, 21)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Email : A177016@ukm.siswa.edu.my "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(540, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 21)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "No Tel : 60+01137357541"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(489, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 21)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Fakulti Teknologi Sains Dan Maklumat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(540, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 21)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "UKM Bandar Baru Bangi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Location = New System.Drawing.Point(64, 47)
        Me.Label6.MinimumSize = New System.Drawing.Size(333, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 90)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "CHRONO"
        '
        'lbl_order_id
        '
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.BackColor = System.Drawing.Color.Black
        Me.lbl_order_id.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id.ForeColor = System.Drawing.Color.White
        Me.lbl_order_id.Location = New System.Drawing.Point(1121, 33)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(33, 26)
        Me.lbl_order_id.TabIndex = 2
        Me.lbl_order_id.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1008, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ORDER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "INVOIS"
        '
        'lst_Order_id
        '
        Me.lst_Order_id.BackColor = System.Drawing.Color.Black
        Me.lst_Order_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_Order_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Order_id.ForeColor = System.Drawing.Color.White
        Me.lst_Order_id.FormattingEnabled = True
        Me.lst_Order_id.ItemHeight = 20
        Me.lst_Order_id.Location = New System.Drawing.Point(60, 223)
        Me.lst_Order_id.Name = "lst_Order_id"
        Me.lst_Order_id.Size = New System.Drawing.Size(215, 540)
        Me.lst_Order_id.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.png_clipart_youtube_tutorial_google_play_chrono_trigger_youtube_game_logo_removebg_preview
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.MinimumSize = New System.Drawing.Size(333, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 90)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "CHRONO"
        '
        'frm_Order_Details_A177016
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1672, 804)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lst_Order_id)
        Me.Controls.Add(Me.drop_panel3)
        Me.Controls.Add(Me.drop_panel2)
        Me.Controls.Add(Me.pic_Me)
        Me.Controls.Add(Me.drop_panel)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frm_Order_Details_A177016"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Order_Details_A177016"
        Me.drop_panel2.ResumeLayout(False)
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drop_panel.ResumeLayout(False)
        Me.drop_panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Datagrid_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents drop_panel2 As Panel
    Friend WithEvents btn_catalog As Button
    Friend WithEvents btn_gallery As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents pic_Me As PictureBox
    Friend WithEvents drop_panel As Panel
    Friend WithEvents btn_order_drop_down As Button
    Friend WithEvents btn_order_detail As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents drop_panel3 As Panel
    Friend WithEvents btn_customerManagement As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents btn_staffManagement As Button
    Friend WithEvents btn_productManagement As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_customerID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lst_Order_id As ListBox
    Friend WithEvents Datagrid_order As DataGridView
    Friend WithEvents PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents PRICE As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
