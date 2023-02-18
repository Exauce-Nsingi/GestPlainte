<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeneSaisieAbo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeneSaisieAbo))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox_User = New System.Windows.Forms.PictureBox()
        Me.BtnRetour = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridAbo = New System.Windows.Forms.DataGridView()
        Me.CmbTypeAbo = New System.Windows.Forms.ComboBox()
        Me.TxtNomAbo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNumAbonne = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbAvenue = New System.Windows.Forms.ComboBox()
        Me.CmbQuartier = New System.Windows.Forms.ComboBox()
        Me.TxtNumParce = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbCabine = New System.Windows.Forms.ComboBox()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.TxtRechAbo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridAbo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 17)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Retour"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(543, 143)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(52, 17)
        Me.lblUser.TabIndex = 50
        Me.lblUser.Text = "User-Id"
        '
        'PictureBox_User
        '
        Me.PictureBox_User.Image = CType(resources.GetObject("PictureBox_User.Image"), System.Drawing.Image)
        Me.PictureBox_User.Location = New System.Drawing.Point(557, 110)
        Me.PictureBox_User.Name = "PictureBox_User"
        Me.PictureBox_User.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_User.TabIndex = 49
        Me.PictureBox_User.TabStop = False
        '
        'BtnRetour
        '
        Me.BtnRetour.Image = CType(resources.GetObject("BtnRetour.Image"), System.Drawing.Image)
        Me.BtnRetour.Location = New System.Drawing.Point(29, 110)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(34, 30)
        Me.BtnRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRetour.TabIndex = 48
        Me.BtnRetour.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Saisie des Abonnés"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(99, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 3)
        Me.Panel1.TabIndex = 46
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(526, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Centre des ventes et Services de Ngiri-Ngiri"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(195, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Société Nationale d'Electricité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 22)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "République Démocratique du Congo"
        '
        'DataGridAbo
        '
        Me.DataGridAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAbo.Location = New System.Drawing.Point(9, 343)
        Me.DataGridAbo.Name = "DataGridAbo"
        Me.DataGridAbo.Size = New System.Drawing.Size(608, 141)
        Me.DataGridAbo.TabIndex = 61
        '
        'CmbTypeAbo
        '
        Me.CmbTypeAbo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTypeAbo.FormattingEnabled = True
        Me.CmbTypeAbo.Location = New System.Drawing.Point(171, 234)
        Me.CmbTypeAbo.Name = "CmbTypeAbo"
        Me.CmbTypeAbo.Size = New System.Drawing.Size(128, 23)
        Me.CmbTypeAbo.TabIndex = 53
        '
        'TxtNomAbo
        '
        Me.TxtNomAbo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomAbo.Location = New System.Drawing.Point(170, 202)
        Me.TxtNomAbo.Name = "TxtNomAbo"
        Me.TxtNomAbo.Size = New System.Drawing.Size(129, 23)
        Me.TxtNomAbo.TabIndex = 59
        Me.TxtNomAbo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Noms :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Type Abonné :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Libelle Cabine :"
        '
        'TxtNumAbonne
        '
        Me.TxtNumAbonne.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumAbonne.Location = New System.Drawing.Point(170, 172)
        Me.TxtNumAbonne.Name = "TxtNumAbonne"
        Me.TxtNumAbonne.Size = New System.Drawing.Size(129, 23)
        Me.TxtNumAbonne.TabIndex = 55
        Me.TxtNumAbonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Numéro Abonné :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbAvenue)
        Me.GroupBox1.Controls.Add(Me.CmbQuartier)
        Me.GroupBox1.Controls.Add(Me.TxtNumParce)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(329, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 131)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localisation"
        '
        'CmbAvenue
        '
        Me.CmbAvenue.FormattingEnabled = True
        Me.CmbAvenue.Location = New System.Drawing.Point(153, 64)
        Me.CmbAvenue.Name = "CmbAvenue"
        Me.CmbAvenue.Size = New System.Drawing.Size(128, 26)
        Me.CmbAvenue.TabIndex = 39
        '
        'CmbQuartier
        '
        Me.CmbQuartier.FormattingEnabled = True
        Me.CmbQuartier.Location = New System.Drawing.Point(153, 30)
        Me.CmbQuartier.Name = "CmbQuartier"
        Me.CmbQuartier.Size = New System.Drawing.Size(128, 26)
        Me.CmbQuartier.TabIndex = 38
        '
        'TxtNumParce
        '
        Me.TxtNumParce.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumParce.Location = New System.Drawing.Point(153, 101)
        Me.TxtNumParce.Name = "TxtNumParce"
        Me.TxtNumParce.Size = New System.Drawing.Size(50, 23)
        Me.TxtNumParce.TabIndex = 36
        Me.TxtNumParce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Numéro du Parcelle :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Désignation Avenue :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Désignation Quartier :"
        '
        'CmbCabine
        '
        Me.CmbCabine.FormattingEnabled = True
        Me.CmbCabine.Location = New System.Drawing.Point(170, 265)
        Me.CmbCabine.Name = "CmbCabine"
        Me.CmbCabine.Size = New System.Drawing.Size(128, 21)
        Me.CmbCabine.TabIndex = 62
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnQuitter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.ForeColor = System.Drawing.Color.White
        Me.BtnQuitter.Location = New System.Drawing.Point(510, 490)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(105, 31)
        Me.BtnQuitter.TabIndex = 67
        Me.BtnQuitter.Text = "&Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnSupprimer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupprimer.ForeColor = System.Drawing.Color.White
        Me.BtnSupprimer.Location = New System.Drawing.Point(260, 490)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(105, 31)
        Me.BtnSupprimer.TabIndex = 65
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnAnnuler.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.White
        Me.BtnAnnuler.Location = New System.Drawing.Point(390, 490)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(105, 31)
        Me.BtnAnnuler.TabIndex = 66
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnModifier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ForeColor = System.Drawing.Color.White
        Me.BtnModifier.Location = New System.Drawing.Point(137, 490)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(105, 31)
        Me.BtnModifier.TabIndex = 64
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnEnregistrer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.BtnEnregistrer.Location = New System.Drawing.Point(16, 490)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(105, 31)
        Me.BtnEnregistrer.TabIndex = 63
        Me.BtnEnregistrer.Text = "&Enregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = False
        '
        'TxtRechAbo
        '
        Me.TxtRechAbo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRechAbo.Location = New System.Drawing.Point(510, 316)
        Me.TxtRechAbo.Name = "TxtRechAbo"
        Me.TxtRechAbo.Size = New System.Drawing.Size(102, 23)
        Me.TxtRechAbo.TabIndex = 69
        Me.TxtRechAbo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(373, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 18)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Récherche Abonné :"
        '
        'FeneSaisieAbo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 533)
        Me.Controls.Add(Me.TxtRechAbo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.CmbCabine)
        Me.Controls.Add(Me.DataGridAbo)
        Me.Controls.Add(Me.CmbTypeAbo)
        Me.Controls.Add(Me.TxtNomAbo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNumAbonne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox_User)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FeneSaisieAbo"
        Me.Text = "FeneSaisieAbo"
        CType(Me.PictureBox_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridAbo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents PictureBox_User As PictureBox
    Friend WithEvents BtnRetour As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridAbo As DataGridView
    Friend WithEvents CmbTypeAbo As ComboBox
    Friend WithEvents TxtNomAbo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNumAbonne As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbAvenue As ComboBox
    Friend WithEvents CmbQuartier As ComboBox
    Friend WithEvents TxtNumParce As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbCabine As ComboBox
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents TxtRechAbo As TextBox
    Friend WithEvents Label12 As Label
End Class
