<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_A177016
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grd_Product = New System.Windows.Forms.DataGridView()
        Me.drop_panel3 = New System.Windows.Forms.Panel()
        Me.btn_customerManagement = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.btn_staffManagement = New System.Windows.Forms.Button()
        Me.btn_productManagement = New System.Windows.Forms.Button()
        Me.drop_panel2 = New System.Windows.Forms.Panel()
        Me.btn_catalog = New System.Windows.Forms.Button()
        Me.btn_gallery = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.pic_Me = New System.Windows.Forms.PictureBox()
        Me.drop_panel = New System.Windows.Forms.Panel()
        Me.btn_order_drop_down = New System.Windows.Forms.Button()
        Me.btn_order_detail = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grd_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drop_panel3.SuspendLayout()
        Me.drop_panel2.SuspendLayout()
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drop_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_Product
        '
        Me.grd_Product.AllowUserToAddRows = False
        Me.grd_Product.AllowUserToDeleteRows = False
        Me.grd_Product.AllowUserToResizeColumns = False
        Me.grd_Product.AllowUserToResizeRows = False
        Me.grd_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_Product.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Product.Location = New System.Drawing.Point(117, 192)
        Me.grd_Product.Name = "grd_Product"
        Me.grd_Product.Size = New System.Drawing.Size(1485, 549)
        Me.grd_Product.TabIndex = 60
        '
        'drop_panel3
        '
        Me.drop_panel3.Controls.Add(Me.btn_customerManagement)
        Me.drop_panel3.Controls.Add(Me.btn_admin)
        Me.drop_panel3.Controls.Add(Me.btn_staffManagement)
        Me.drop_panel3.Controls.Add(Me.btn_productManagement)
        Me.drop_panel3.Location = New System.Drawing.Point(1001, 3)
        Me.drop_panel3.MaximumSize = New System.Drawing.Size(184, 370)
        Me.drop_panel3.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel3.Name = "drop_panel3"
        Me.drop_panel3.Size = New System.Drawing.Size(184, 370)
        Me.drop_panel3.TabIndex = 100
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
        'drop_panel2
        '
        Me.drop_panel2.Controls.Add(Me.btn_catalog)
        Me.drop_panel2.Controls.Add(Me.btn_gallery)
        Me.drop_panel2.Controls.Add(Me.btn_product)
        Me.drop_panel2.Location = New System.Drawing.Point(514, 3)
        Me.drop_panel2.MaximumSize = New System.Drawing.Size(184, 289)
        Me.drop_panel2.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel2.Name = "drop_panel2"
        Me.drop_panel2.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel2.TabIndex = 99
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
        Me.btn_gallery.Location = New System.Drawing.Point(16, 4)
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
        Me.pic_Me.Location = New System.Drawing.Point(1555, 9)
        Me.pic_Me.Name = "pic_Me"
        Me.pic_Me.Size = New System.Drawing.Size(101, 92)
        Me.pic_Me.TabIndex = 98
        Me.pic_Me.TabStop = False
        '
        'drop_panel
        '
        Me.drop_panel.Controls.Add(Me.btn_order_drop_down)
        Me.drop_panel.Controls.Add(Me.btn_order_detail)
        Me.drop_panel.Controls.Add(Me.btn_order)
        Me.drop_panel.Location = New System.Drawing.Point(704, 3)
        Me.drop_panel.MaximumSize = New System.Drawing.Size(184, 289)
        Me.drop_panel.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel.Name = "drop_panel"
        Me.drop_panel.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel.TabIndex = 92
        '
        'btn_order_drop_down
        '
        Me.btn_order_drop_down.AllowDrop = True
        Me.btn_order_drop_down.BackColor = System.Drawing.Color.Black
        Me.btn_order_drop_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_order_drop_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_order_drop_down.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_drop_down.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_order_drop_down.Location = New System.Drawing.Point(13, 4)
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
        Me.btn_order_detail.Text = "Order History"
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
        Me.btn_order.Text = "Your Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(30, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 28)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Product"
        '
        'btn_staff
        '
        Me.btn_staff.AllowDrop = True
        Me.btn_staff.BackColor = System.Drawing.Color.Black
        Me.btn_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_staff.Location = New System.Drawing.Point(872, 7)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(153, 94)
        Me.btn_staff.TabIndex = 95
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
        Me.btn_customer.Location = New System.Drawing.Point(371, 7)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(153, 94)
        Me.btn_customer.TabIndex = 93
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1756, 10)
        Me.Panel1.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.png_clipart_youtube_tutorial_google_play_chrono_trigger_youtube_game_logo_removebg_preview
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(2, 11)
        Me.Label3.MinimumSize = New System.Drawing.Size(333, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 90)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "CHRONO"
        '
        'frm_product_A177016
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1672, 804)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.drop_panel3)
        Me.Controls.Add(Me.drop_panel2)
        Me.Controls.Add(Me.pic_Me)
        Me.Controls.Add(Me.drop_panel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grd_Product)
        Me.Name = "frm_product_A177016"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_product_A177016"
        CType(Me.grd_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drop_panel3.ResumeLayout(False)
        Me.drop_panel2.ResumeLayout(False)
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drop_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_Product As DataGridView
    Friend WithEvents drop_panel3 As Panel
    Friend WithEvents btn_customerManagement As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents btn_staffManagement As Button
    Friend WithEvents btn_productManagement As Button
    Friend WithEvents drop_panel2 As Panel
    Friend WithEvents btn_catalog As Button
    Friend WithEvents btn_gallery As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents pic_Me As PictureBox
    Friend WithEvents drop_panel As Panel
    Friend WithEvents btn_order_drop_down As Button
    Friend WithEvents btn_order_detail As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
