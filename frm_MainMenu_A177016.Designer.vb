<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_MainMenu_A177016
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.drop_panel = New System.Windows.Forms.Panel()
        Me.btn_order_drop_down = New System.Windows.Forms.Button()
        Me.btn_order_detail = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picbox_display = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_display = New System.Windows.Forms.Button()
        Me.drop_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.drop_panel3.SuspendLayout()
        Me.drop_panel2.SuspendLayout()
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_customer
        '
        Me.btn_customer.AllowDrop = True
        Me.btn_customer.BackColor = System.Drawing.Color.Black
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_customer.Location = New System.Drawing.Point(375, 14)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(153, 94)
        Me.btn_customer.TabIndex = 3
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.AllowDrop = True
        Me.btn_staff.BackColor = System.Drawing.Color.Black
        Me.btn_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_staff.Location = New System.Drawing.Point(876, 14)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(153, 94)
        Me.btn_staff.TabIndex = 6
        Me.btn_staff.Text = "Our Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'drop_panel
        '
        Me.drop_panel.Controls.Add(Me.btn_order_drop_down)
        Me.drop_panel.Controls.Add(Me.btn_order_detail)
        Me.drop_panel.Controls.Add(Me.btn_order)
        Me.drop_panel.Location = New System.Drawing.Point(708, 10)
        Me.drop_panel.MaximumSize = New System.Drawing.Size(184, 314)
        Me.drop_panel.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel.Name = "drop_panel"
        Me.drop_panel.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel.TabIndex = 3
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.Untitled
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.drop_panel3)
        Me.Panel2.Controls.Add(Me.drop_panel2)
        Me.Panel2.Controls.Add(Me.pic_Me)
        Me.Panel2.Controls.Add(Me.drop_panel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_staff)
        Me.Panel2.Controls.Add(Me.btn_customer)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1672, 816)
        Me.Panel2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.png_clipart_youtube_tutorial_google_play_chrono_trigger_youtube_game_logo_removebg_preview
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.MinimumSize = New System.Drawing.Size(333, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 90)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "CHRONO"
        '
        'drop_panel3
        '
        Me.drop_panel3.Controls.Add(Me.btn_customerManagement)
        Me.drop_panel3.Controls.Add(Me.btn_admin)
        Me.drop_panel3.Controls.Add(Me.btn_staffManagement)
        Me.drop_panel3.Controls.Add(Me.btn_productManagement)
        Me.drop_panel3.Location = New System.Drawing.Point(1005, 10)
        Me.drop_panel3.MaximumSize = New System.Drawing.Size(184, 370)
        Me.drop_panel3.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel3.Name = "drop_panel3"
        Me.drop_panel3.Size = New System.Drawing.Size(184, 370)
        Me.drop_panel3.TabIndex = 55
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
        Me.drop_panel2.Location = New System.Drawing.Point(518, 10)
        Me.drop_panel2.MaximumSize = New System.Drawing.Size(184, 314)
        Me.drop_panel2.MinimumSize = New System.Drawing.Size(184, 94)
        Me.drop_panel2.Name = "drop_panel2"
        Me.drop_panel2.Size = New System.Drawing.Size(184, 289)
        Me.drop_panel2.TabIndex = 54
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
        Me.pic_Me.Location = New System.Drawing.Point(1559, 16)
        Me.pic_Me.Name = "pic_Me"
        Me.pic_Me.Size = New System.Drawing.Size(101, 92)
        Me.pic_Me.TabIndex = 10
        Me.pic_Me.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Cambria Math", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 161)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Luxurious Time Piece Collection(Swiss Edition)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1756, 10)
        Me.Panel1.TabIndex = 7
        '
        'picbox_display
        '
        Me.picbox_display.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.picbox_display.Location = New System.Drawing.Point(-46, -8)
        Me.picbox_display.Name = "picbox_display"
        Me.picbox_display.Size = New System.Drawing.Size(1005, 525)
        Me.picbox_display.TabIndex = 9
        Me.picbox_display.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.picbox_display)
        Me.Panel3.Location = New System.Drawing.Point(12, 299)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(987, 493)
        Me.Panel3.TabIndex = 9
        '
        'btn_display
        '
        Me.btn_display.BackColor = System.Drawing.Color.White
        Me.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_display.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_display.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.right
        Me.btn_display.Location = New System.Drawing.Point(1006, 479)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(32, 97)
        Me.btn_display.TabIndex = 10
        Me.btn_display.UseVisualStyleBackColor = False
        '
        'frm_MainMenu_A177016
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1672, 804)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_MainMenu_A177016"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_MainMenu_A177016"
        Me.drop_panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.drop_panel3.ResumeLayout(False)
        Me.drop_panel2.ResumeLayout(False)
        CType(Me.pic_Me, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents drop_panel As Panel
    Friend WithEvents btn_order_drop_down As Button
    Friend WithEvents btn_order_detail As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents picbox_display As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_display As Button
    Friend WithEvents pic_Me As PictureBox
    Friend WithEvents drop_panel2 As Panel
    Friend WithEvents btn_catalog As Button
    Friend WithEvents btn_gallery As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents drop_panel3 As Panel
    Friend WithEvents btn_staffManagement As Button
    Friend WithEvents btn_productManagement As Button
    Friend WithEvents btn_customerManagement As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents Label3 As Label
End Class
