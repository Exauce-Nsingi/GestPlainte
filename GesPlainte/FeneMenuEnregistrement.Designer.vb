<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeneMenuEnregistrement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeneMenuEnregistrement))
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.BtnReclamation = New System.Windows.Forms.PictureBox()
        Me.BtnSaisie = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReclamation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaisie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(540, 133)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(54, 18)
        Me.LblUser.TabIndex = 46
        Me.LblUser.Text = "User-Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Saisie Réclamation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Saisie Abonné"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(547, 102)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'BtnRetour
        '
        Me.BtnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BtnRetour.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetour.ForeColor = System.Drawing.Color.White
        Me.BtnRetour.Location = New System.Drawing.Point(261, 320)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(105, 31)
        Me.BtnRetour.TabIndex = 41
        Me.BtnRetour.Text = "&Retour"
        Me.BtnRetour.UseVisualStyleBackColor = False
        '
        'BtnReclamation
        '
        Me.BtnReclamation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReclamation.Image = CType(resources.GetObject("BtnReclamation.Image"), System.Drawing.Image)
        Me.BtnReclamation.Location = New System.Drawing.Point(406, 165)
        Me.BtnReclamation.Name = "BtnReclamation"
        Me.BtnReclamation.Size = New System.Drawing.Size(109, 113)
        Me.BtnReclamation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnReclamation.TabIndex = 40
        Me.BtnReclamation.TabStop = False
        '
        'BtnSaisie
        '
        Me.BtnSaisie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaisie.Image = CType(resources.GetObject("BtnSaisie.Image"), System.Drawing.Image)
        Me.BtnSaisie.Location = New System.Drawing.Point(134, 165)
        Me.BtnSaisie.Name = "BtnSaisie"
        Me.BtnSaisie.Size = New System.Drawing.Size(112, 113)
        Me.BtnSaisie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSaisie.TabIndex = 39
        Me.BtnSaisie.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(217, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 23)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Menu des Enregistrement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(91, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 3)
        Me.Panel1.TabIndex = 36
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(518, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Centre des ventes et Services de Ngiri-Ngiri"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(195, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Société National d'Electricité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "République Démocratique du Congo"
        '
        'FeneMenuEnregistrement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 379)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnReclamation)
        Me.Controls.Add(Me.BtnSaisie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeneMenuEnregistrement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeneMenuEnregistrement"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReclamation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaisie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BtnRetour As Button
    Friend WithEvents BtnReclamation As PictureBox
    Friend WithEvents BtnSaisie As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
