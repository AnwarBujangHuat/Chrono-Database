<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashScreen_A177016
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_catalog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.png_clipart_youtube_tutorial_google_play_chrono_trigger_youtube_game_logo_removebg_preview
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(50, 24)
        Me.Label3.MinimumSize = New System.Drawing.Size(333, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 90)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "CHRONO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 25)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Mohamad Anwar Bin Bujang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "A177016"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Niagara Solid", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1128, 103)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Luxurious Time Piece Collection(Swiss Edition)"
        '
        'btn_catalog
        '
        Me.btn_catalog.AllowDrop = True
        Me.btn_catalog.BackColor = System.Drawing.Color.Black
        Me.btn_catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_catalog.Font = New System.Drawing.Font("Stencil", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_catalog.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_catalog.Image = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.canva5_2
        Me.btn_catalog.Location = New System.Drawing.Point(38, 618)
        Me.btn_catalog.Name = "btn_catalog"
        Me.btn_catalog.Size = New System.Drawing.Size(237, 128)
        Me.btn_catalog.TabIndex = 120
        Me.btn_catalog.Text = "Let's Get Started"
        Me.btn_catalog.UseVisualStyleBackColor = False
        '
        'frm_splashScreen_A177016
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.prj_Luxurious_Time_Piece_Collection_Swiss_Edition__A177016.My.Resources.Resources.Untitled
        Me.ClientSize = New System.Drawing.Size(1672, 804)
        Me.Controls.Add(Me.btn_catalog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_splashScreen_A177016"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_splashScreen_A177016"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_catalog As Button
End Class
