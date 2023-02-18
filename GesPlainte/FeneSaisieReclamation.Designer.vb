<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeneSaisieReclamation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeneSaisieReclamation))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAvenue = New System.Windows.Forms.TextBox()
        Me.TxtNumParce = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNomsAbo = New System.Windows.Forms.TextBox()
        Me.TxtNumAbo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumPlainte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDatePlainte = New System.Windows.Forms.TextBox()
        Me.CmbLibTypePlainte = New System.Windows.Forms.ComboBox()
        Me.TxtCodeTypePlainte = New System.Windows.Forms.TextBox()
        Me.BtnRetour = New System.Windows.Forms.PictureBox()
        Me.PictureBox_User = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Saisie des Réclamations"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(99, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 3)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(526, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Centre des ventes et Services de Ngiri-Ngiri"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(195, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Société Nationale d'Electricité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "République Démocratique du Congo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtAvenue)
        Me.GroupBox1.Controls.Add(Me.TxtNumParce)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtNomsAbo)
        Me.GroupBox1.Controls.Add(Me.TxtNumAbo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(343, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identification de l'Abonné"
        '
        'TxtAvenue
        '
        Me.TxtAvenue.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAvenue.Location = New System.Drawing.Point(124, 99)
        Me.TxtAvenue.Name = "TxtAvenue"
        Me.TxtAvenue.ReadOnly = True
        Me.TxtAvenue.Size = New System.Drawing.Size(91, 23)
        Me.TxtAvenue.TabIndex = 37
        '
        'TxtNumParce
        '
        Me.TxtNumParce.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumParce.Location = New System.Drawing.Point(221, 99)
        Me.TxtNumParce.Name = "TxtNumParce"
        Me.TxtNumParce.ReadOnly = True
        Me.TxtNumParce.Size = New System.Drawing.Size(32, 23)
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
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Adresse    :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Noms Abonné :"
        '
        'TxtNomsAbo
        '
        Me.TxtNomsAbo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomsAbo.Location = New System.Drawing.Point(124, 62)
        Me.TxtNomsAbo.Name = "TxtNomsAbo"
        Me.TxtNomsAbo.ReadOnly = True
        Me.TxtNomsAbo.Size = New System.Drawing.Size(129, 23)
        Me.TxtNomsAbo.TabIndex = 31
        '
        'TxtNumAbo
        '
        Me.TxtNumAbo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumAbo.Location = New System.Drawing.Point(124, 30)
        Me.TxtNumAbo.MaxLength = 11
        Me.TxtNumAbo.Name = "TxtNumAbo"
        Me.TxtNumAbo.Size = New System.Drawing.Size(129, 23)
        Me.TxtNumAbo.TabIndex = 1
        Me.TxtNumAbo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Numéro Abonné :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Numéro Plainte :"
        '
        'TxtNumPlainte
        '
        Me.TxtNumPlainte.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumPlainte.Location = New System.Drawing.Point(164, 187)
        Me.TxtNumPlainte.Name = "TxtNumPlainte"
        Me.TxtNumPlainte.ReadOnly = True
        Me.TxtNumPlainte.Size = New System.Drawing.Size(129, 23)
        Me.TxtNumPlainte.TabIndex = 24
        Me.TxtNumPlainte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Code Type Plainte :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Libelle Type Plainte :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Date Dépôt Plainte :"
        '
        'TxtDatePlainte
        '
        Me.TxtDatePlainte.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatePlainte.Location = New System.Drawing.Point(164, 217)
        Me.TxtDatePlainte.Name = "TxtDatePlainte"
        Me.TxtDatePlainte.ReadOnly = True
        Me.TxtDatePlainte.Size = New System.Drawing.Size(129, 23)
        Me.TxtDatePlainte.TabIndex = 29
        Me.TxtDatePlainte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbLibTypePlainte
        '
        Me.CmbLibTypePlainte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLibTypePlainte.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLibTypePlainte.FormattingEnabled = True
        Me.CmbLibTypePlainte.Location = New System.Drawing.Point(164, 245)
        Me.CmbLibTypePlainte.Name = "CmbLibTypePlainte"
        Me.CmbLibTypePlainte.Size = New System.Drawing.Size(128, 23)
        Me.CmbLibTypePlainte.TabIndex = 1
        '
        'TxtCodeTypePlainte
        '
        Me.TxtCodeTypePlainte.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodeTypePlainte.Location = New System.Drawing.Point(163, 278)
        Me.TxtCodeTypePlainte.Name = "TxtCodeTypePlainte"
        Me.TxtCodeTypePlainte.ReadOnly = True
        Me.TxtCodeTypePlainte.Size = New System.Drawing.Size(129, 23)
        Me.TxtCodeTypePlainte.TabIndex = 31
        Me.TxtCodeTypePlainte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnRetour
        '
        Me.BtnRetour.Image = CType(resources.GetObject("BtnRetour.Image"), System.Drawing.Image)
        Me.BtnRetour.Location = New System.Drawing.Point(32, 113)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(34, 30)
        Me.BtnRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRetour.TabIndex = 37
        Me.BtnRetour.TabStop = False
        '
        'PictureBox_User
        '
        Me.PictureBox_User.Image = CType(resources.GetObject("PictureBox_User.Image"), System.Drawing.Image)
        Me.PictureBox_User.Location = New System.Drawing.Point(560, 113)
        Me.PictureBox_User.Name = "PictureBox_User"
        Me.PictureBox_User.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_User.TabIndex = 38
        Me.PictureBox_User.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(546, 146)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(52, 17)
        Me.lblUser.TabIndex = 39
        Me.lblUser.Text = "User-Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Retour"
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnEnregistrer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.BtnEnregistrer.Location = New System.Drawing.Point(21, 490)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(105, 31)
        Me.BtnEnregistrer.TabIndex = 2
        Me.BtnEnregistrer.Text = "&Enregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnModifier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ForeColor = System.Drawing.Color.White
        Me.BtnModifier.Location = New System.Drawing.Point(142, 490)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(105, 31)
        Me.BtnModifier.TabIndex = 3
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnAnnuler.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.White
        Me.BtnAnnuler.Location = New System.Drawing.Point(395, 490)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(105, 31)
        Me.BtnAnnuler.TabIndex = 5
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnSupprimer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupprimer.ForeColor = System.Drawing.Color.White
        Me.BtnSupprimer.Location = New System.Drawing.Point(265, 490)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(105, 31)
        Me.BtnSupprimer.TabIndex = 4
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnQuitter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.ForeColor = System.Drawing.Color.White
        Me.BtnQuitter.Location = New System.Drawing.Point(515, 490)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(105, 31)
        Me.BtnQuitter.TabIndex = 6
        Me.BtnQuitter.Text = "&Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(593, 141)
        Me.DataGridView1.TabIndex = 46
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FeneSaisieReclamation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 533)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox_User)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.TxtCodeTypePlainte)
        Me.Controls.Add(Me.CmbLibTypePlainte)
        Me.Controls.Add(Me.TxtDatePlainte)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNumPlainte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeneSaisieReclamation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeneSaisieReclamation"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumPlainte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNomsAbo As TextBox
    Friend WithEvents TxtNumAbo As TextBox
    Friend WithEvents TxtDatePlainte As TextBox
    Friend WithEvents CmbLibTypePlainte As ComboBox
    Friend WithEvents TxtNumParce As TextBox
    Friend WithEvents TxtCodeTypePlainte As TextBox
    Friend WithEvents BtnRetour As PictureBox
    Friend WithEvents PictureBox_User As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtAvenue As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
