<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.TbJenis = New System.Windows.Forms.TextBox()
        Me.RtbDesc = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPenerbit = New System.Windows.Forms.TextBox()
        Me.TbLokasiRak = New System.Windows.Forms.TextBox()
        Me.TbTahunTerbit = New System.Windows.Forms.TextBox()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TbStok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbBudaya = New System.Windows.Forms.CheckBox()
        Me.cbTeknologi = New System.Windows.Forms.CheckBox()
        Me.cbSosial = New System.Windows.Forms.CheckBox()
        Me.cbSains = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAddGambar = New System.Windows.Forms.Button()
        Me.btnTambahKoleksi = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Koleksi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 145)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deskripsi"
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(369, 59)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(243, 22)
        Me.TbNama.TabIndex = 6
        '
        'TbJenis
        '
        Me.TbJenis.Location = New System.Drawing.Point(369, 89)
        Me.TbJenis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbJenis.Name = "TbJenis"
        Me.TbJenis.Size = New System.Drawing.Size(243, 22)
        Me.TbJenis.TabIndex = 7
        '
        'RtbDesc
        '
        Me.RtbDesc.Location = New System.Drawing.Point(370, 119)
        Me.RtbDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RtbDesc.Name = "RtbDesc"
        Me.RtbDesc.Size = New System.Drawing.Size(243, 117)
        Me.RtbDesc.TabIndex = 8
        Me.RtbDesc.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 308)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 340)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'TbPenerbit
        '
        Me.TbPenerbit.Location = New System.Drawing.Point(369, 244)
        Me.TbPenerbit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbPenerbit.Name = "TbPenerbit"
        Me.TbPenerbit.Size = New System.Drawing.Size(243, 22)
        Me.TbPenerbit.TabIndex = 13
        '
        'TbLokasiRak
        '
        Me.TbLokasiRak.Location = New System.Drawing.Point(370, 304)
        Me.TbLokasiRak.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbLokasiRak.Name = "TbLokasiRak"
        Me.TbLokasiRak.Size = New System.Drawing.Size(243, 22)
        Me.TbLokasiRak.TabIndex = 14
        '
        'TbTahunTerbit
        '
        Me.TbTahunTerbit.Location = New System.Drawing.Point(370, 274)
        Me.TbTahunTerbit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbTahunTerbit.Name = "TbTahunTerbit"
        Me.TbTahunTerbit.Size = New System.Drawing.Size(243, 22)
        Me.TbTahunTerbit.TabIndex = 15
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(370, 334)
        Me.DtpTanggal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(243, 22)
        Me.DtpTanggal.TabIndex = 16
        '
        'TbStok
        '
        Me.TbStok.Location = New System.Drawing.Point(370, 364)
        Me.TbStok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbStok.Name = "TbStok"
        Me.TbStok.Size = New System.Drawing.Size(243, 22)
        Me.TbStok.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 368)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(188, 394)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Bahasa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Controls.Add(Me.RdIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(369, 394)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(244, 86)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(8, 53)
        Me.RdInggris.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(118, 20)
        Me.RdInggris.TabIndex = 1
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdIndonesia
        '
        Me.RdIndonesia.AutoSize = True
        Me.RdIndonesia.Location = New System.Drawing.Point(9, 25)
        Me.RdIndonesia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdIndonesia.Name = "RdIndonesia"
        Me.RdIndonesia.Size = New System.Drawing.Size(137, 20)
        Me.RdIndonesia.TabIndex = 0
        Me.RdIndonesia.TabStop = True
        Me.RdIndonesia.Text = "Bahasa Indonesia"
        Me.RdIndonesia.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbBudaya)
        Me.GroupBox2.Controls.Add(Me.cbTeknologi)
        Me.GroupBox2.Controls.Add(Me.cbSosial)
        Me.GroupBox2.Controls.Add(Me.cbSains)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 488)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(244, 142)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'cbBudaya
        '
        Me.cbBudaya.AutoSize = True
        Me.cbBudaya.Location = New System.Drawing.Point(8, 110)
        Me.cbBudaya.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbBudaya.Name = "cbBudaya"
        Me.cbBudaya.Size = New System.Drawing.Size(76, 20)
        Me.cbBudaya.TabIndex = 3
        Me.cbBudaya.Text = "Budaya"
        Me.cbBudaya.UseVisualStyleBackColor = True
        '
        'cbTeknologi
        '
        Me.cbTeknologi.AutoSize = True
        Me.cbTeknologi.Location = New System.Drawing.Point(8, 81)
        Me.cbTeknologi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTeknologi.Name = "cbTeknologi"
        Me.cbTeknologi.Size = New System.Drawing.Size(90, 20)
        Me.cbTeknologi.TabIndex = 2
        Me.cbTeknologi.Text = "Teknologi"
        Me.cbTeknologi.UseVisualStyleBackColor = True
        '
        'cbSosial
        '
        Me.cbSosial.AutoSize = True
        Me.cbSosial.Location = New System.Drawing.Point(8, 53)
        Me.cbSosial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSosial.Name = "cbSosial"
        Me.cbSosial.Size = New System.Drawing.Size(67, 20)
        Me.cbSosial.TabIndex = 1
        Me.cbSosial.Text = "Sosial"
        Me.cbSosial.UseVisualStyleBackColor = True
        '
        'cbSains
        '
        Me.cbSains.AutoSize = True
        Me.cbSains.Location = New System.Drawing.Point(9, 25)
        Me.cbSains.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSains.Name = "cbSains"
        Me.cbSains.Size = New System.Drawing.Size(63, 20)
        Me.cbSains.TabIndex = 0
        Me.cbSains.Text = "Sains"
        Me.cbSains.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(187, 488)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Kategori"
        '
        'btnAddGambar
        '
        Me.btnAddGambar.Location = New System.Drawing.Point(7, 215)
        Me.btnAddGambar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddGambar.Name = "btnAddGambar"
        Me.btnAddGambar.Size = New System.Drawing.Size(131, 28)
        Me.btnAddGambar.TabIndex = 2
        Me.btnAddGambar.Text = "Tambah Gambar"
        Me.btnAddGambar.UseVisualStyleBackColor = True
        '
        'btnTambahKoleksi
        '
        Me.btnTambahKoleksi.Location = New System.Drawing.Point(387, 638)
        Me.btnTambahKoleksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTambahKoleksi.Name = "btnTambahKoleksi"
        Me.btnTambahKoleksi.Size = New System.Drawing.Size(201, 27)
        Me.btnTambahKoleksi.TabIndex = 23
        Me.btnTambahKoleksi.Text = "Tambah Koleksi"
        Me.btnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 681)
        Me.Controls.Add(Me.btnTambahKoleksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbStok)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.TbTahunTerbit)
        Me.Controls.Add(Me.TbLokasiRak)
        Me.Controls.Add(Me.TbPenerbit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RtbDesc)
        Me.Controls.Add(Me.TbJenis)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormTambahKoleksi"
        Me.Text = "FormTambahKoleksi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbNama As TextBox
    Friend WithEvents TbJenis As TextBox
    Friend WithEvents RtbDesc As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbPenerbit As TextBox
    Friend WithEvents TbLokasiRak As TextBox
    Friend WithEvents TbTahunTerbit As TextBox
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents TbStok As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdIndonesia As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbBudaya As CheckBox
    Friend WithEvents cbTeknologi As CheckBox
    Friend WithEvents cbSosial As CheckBox
    Friend WithEvents cbSains As CheckBox
    Friend WithEvents btnAddGambar As Button
    Friend WithEvents btnTambahKoleksi As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
