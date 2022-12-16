<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoKoleksi
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblLokasi = New System.Windows.Forms.Label()
        Me.LblTanggalMasuk = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.ListBoxKategori = New System.Windows.Forms.ListBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(19, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 148)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Info Koleksi"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(184, 62)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(48, 16)
        Me.LblNama.TabIndex = 2
        Me.LblNama.Text = "Label2"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(184, 95)
        Me.LblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(48, 16)
        Me.LblJenis.TabIndex = 3
        Me.LblJenis.Text = "Label3"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(184, 127)
        Me.LblDeskripsi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(48, 16)
        Me.LblDeskripsi.TabIndex = 4
        Me.LblDeskripsi.Text = "Label4"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(184, 160)
        Me.LblPenerbit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(48, 16)
        Me.LblPenerbit.TabIndex = 5
        Me.LblPenerbit.Text = "Label5"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(184, 193)
        Me.LblTahunTerbit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(48, 16)
        Me.LblTahunTerbit.TabIndex = 6
        Me.LblTahunTerbit.Text = "Label6"
        '
        'LblLokasi
        '
        Me.LblLokasi.AutoSize = True
        Me.LblLokasi.Location = New System.Drawing.Point(184, 225)
        Me.LblLokasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLokasi.Name = "LblLokasi"
        Me.LblLokasi.Size = New System.Drawing.Size(48, 16)
        Me.LblLokasi.TabIndex = 7
        Me.LblLokasi.Text = "Label7"
        '
        'LblTanggalMasuk
        '
        Me.LblTanggalMasuk.AutoSize = True
        Me.LblTanggalMasuk.Location = New System.Drawing.Point(184, 254)
        Me.LblTanggalMasuk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTanggalMasuk.Name = "LblTanggalMasuk"
        Me.LblTanggalMasuk.Size = New System.Drawing.Size(48, 16)
        Me.LblTanggalMasuk.TabIndex = 8
        Me.LblTanggalMasuk.Text = "Label8"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(184, 284)
        Me.LblStok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(48, 16)
        Me.LblStok.TabIndex = 9
        Me.LblStok.Text = "Label9"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(184, 313)
        Me.LblBahasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(55, 16)
        Me.LblBahasa.TabIndex = 10
        Me.LblBahasa.Text = "Label10"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(184, 345)
        Me.LblKategori.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(57, 16)
        Me.LblKategori.TabIndex = 11
        Me.LblKategori.Text = "Kategori"
        '
        'ListBoxKategori
        '
        Me.ListBoxKategori.FormattingEnabled = True
        Me.ListBoxKategori.ItemHeight = 16
        Me.ListBoxKategori.Location = New System.Drawing.Point(188, 366)
        Me.ListBoxKategori.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxKategori.Name = "ListBoxKategori"
        Me.ListBoxKategori.Size = New System.Drawing.Size(203, 116)
        Me.ListBoxKategori.TabIndex = 12
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(419, 511)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(100, 28)
        Me.closeBtn.TabIndex = 13
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'FormInfoKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 554)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.ListBoxKategori)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.LblTanggalMasuk)
        Me.Controls.Add(Me.LblLokasi)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormInfoKoleksi"
        Me.Text = "FormInfoKoleksi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblLokasi As Label
    Friend WithEvents LblTanggalMasuk As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblKategori As Label
    Friend WithEvents ListBoxKategori As ListBox
    Friend WithEvents closeBtn As Button
End Class
