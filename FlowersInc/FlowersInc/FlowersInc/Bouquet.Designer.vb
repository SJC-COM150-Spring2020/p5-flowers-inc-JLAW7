<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBouquet
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
        Me.lblBouquet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpAccent = New System.Windows.Forms.GroupBox()
        Me.chkFern = New System.Windows.Forms.CheckBox()
        Me.chkBaby = New System.Windows.Forms.CheckBox()
        Me.chkMini = New System.Windows.Forms.CheckBox()
        Me.lblRosesb = New System.Windows.Forms.Label()
        Me.grpContainer = New System.Windows.Forms.GroupBox()
        Me.radBasket = New System.Windows.Forms.RadioButton()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.radMason = New System.Windows.Forms.RadioButton()
        Me.radVase = New System.Windows.Forms.RadioButton()
        Me.lblQuantity2 = New System.Windows.Forms.Label()
        Me.txtTypes = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.lblLiliesb = New System.Windows.Forms.Label()
        Me.lblDaisesb = New System.Windows.Forms.Label()
        Me.lblHydrangeas = New System.Windows.Forms.Label()
        Me.lblQuantity1 = New System.Windows.Forms.Label()
        Me.lblContainer = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnClearb = New System.Windows.Forms.Button()
        Me.btnExitb = New System.Windows.Forms.Button()
        Me.grpAccent.SuspendLayout()
        Me.grpContainer.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBouquet
        '
        Me.lblBouquet.AutoSize = True
        Me.lblBouquet.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBouquet.Location = New System.Drawing.Point(255, 9)
        Me.lblBouquet.Name = "lblBouquet"
        Me.lblBouquet.Size = New System.Drawing.Size(350, 47)
        Me.lblBouquet.TabIndex = 0
        Me.lblBouquet.Text = "Build Your Bouquet!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "In the Types box, please type in the flower you desire."
        '
        'grpAccent
        '
        Me.grpAccent.Controls.Add(Me.chkFern)
        Me.grpAccent.Controls.Add(Me.chkBaby)
        Me.grpAccent.Controls.Add(Me.chkMini)
        Me.grpAccent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccent.Location = New System.Drawing.Point(294, 162)
        Me.grpAccent.Name = "grpAccent"
        Me.grpAccent.Size = New System.Drawing.Size(261, 188)
        Me.grpAccent.TabIndex = 4
        Me.grpAccent.TabStop = False
        Me.grpAccent.Text = "Accents (Select Any)"
        '
        'chkFern
        '
        Me.chkFern.AutoSize = True
        Me.chkFern.Location = New System.Drawing.Point(19, 120)
        Me.chkFern.Name = "chkFern"
        Me.chkFern.Size = New System.Drawing.Size(159, 25)
        Me.chkFern.TabIndex = 2
        Me.chkFern.Text = "Leather Leaf Fern"
        Me.chkFern.UseVisualStyleBackColor = True
        '
        'chkBaby
        '
        Me.chkBaby.AutoSize = True
        Me.chkBaby.Location = New System.Drawing.Point(19, 85)
        Me.chkBaby.Name = "chkBaby"
        Me.chkBaby.Size = New System.Drawing.Size(132, 25)
        Me.chkBaby.TabIndex = 1
        Me.chkBaby.Text = "Baby's Breath"
        Me.chkBaby.UseVisualStyleBackColor = True
        '
        'chkMini
        '
        Me.chkMini.AutoSize = True
        Me.chkMini.Location = New System.Drawing.Point(19, 50)
        Me.chkMini.Name = "chkMini"
        Me.chkMini.Size = New System.Drawing.Size(158, 25)
        Me.chkMini.TabIndex = 0
        Me.chkMini.Text = "Mini Spray Roses"
        Me.chkMini.UseVisualStyleBackColor = True
        '
        'lblRosesb
        '
        Me.lblRosesb.AutoSize = True
        Me.lblRosesb.Location = New System.Drawing.Point(38, 25)
        Me.lblRosesb.Name = "lblRosesb"
        Me.lblRosesb.Size = New System.Drawing.Size(53, 21)
        Me.lblRosesb.TabIndex = 8
        Me.lblRosesb.Text = "Roses"
        '
        'grpContainer
        '
        Me.grpContainer.Controls.Add(Me.radBasket)
        Me.grpContainer.Controls.Add(Me.btnCheck)
        Me.grpContainer.Controls.Add(Me.radMason)
        Me.grpContainer.Controls.Add(Me.radVase)
        Me.grpContainer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpContainer.Location = New System.Drawing.Point(561, 162)
        Me.grpContainer.Name = "grpContainer"
        Me.grpContainer.Size = New System.Drawing.Size(265, 188)
        Me.grpContainer.TabIndex = 9
        Me.grpContainer.TabStop = False
        Me.grpContainer.Text = "Container (Select One)"
        '
        'radBasket
        '
        Me.radBasket.AutoSize = True
        Me.radBasket.Location = New System.Drawing.Point(17, 120)
        Me.radBasket.Name = "radBasket"
        Me.radBasket.Size = New System.Drawing.Size(78, 25)
        Me.radBasket.TabIndex = 2
        Me.radBasket.TabStop = True
        Me.radBasket.Text = "Basket"
        Me.radBasket.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(156, 150)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(103, 32)
        Me.btnCheck.TabIndex = 18
        Me.btnCheck.Text = "CHECKOUT"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'radMason
        '
        Me.radMason.AutoSize = True
        Me.radMason.Location = New System.Drawing.Point(17, 85)
        Me.radMason.Name = "radMason"
        Me.radMason.Size = New System.Drawing.Size(105, 25)
        Me.radMason.TabIndex = 1
        Me.radMason.TabStop = True
        Me.radMason.Text = "Mason Jar"
        Me.radMason.UseVisualStyleBackColor = True
        '
        'radVase
        '
        Me.radVase.AutoSize = True
        Me.radVase.Location = New System.Drawing.Point(17, 50)
        Me.radVase.Name = "radVase"
        Me.radVase.Size = New System.Drawing.Size(63, 25)
        Me.radVase.TabIndex = 0
        Me.radVase.TabStop = True
        Me.radVase.Text = "Vase"
        Me.radVase.UseVisualStyleBackColor = True
        '
        'lblQuantity2
        '
        Me.lblQuantity2.AutoSize = True
        Me.lblQuantity2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity2.Location = New System.Drawing.Point(30, 329)
        Me.lblQuantity2.Name = "lblQuantity2"
        Me.lblQuantity2.Size = New System.Drawing.Size(95, 21)
        Me.lblQuantity2.TabIndex = 11
        Me.lblQuantity2.Text = "QUANTITY:"
        '
        'txtTypes
        '
        Me.txtTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypes.Location = New System.Drawing.Point(74, 104)
        Me.txtTypes.Name = "txtTypes"
        Me.txtTypes.Size = New System.Drawing.Size(100, 20)
        Me.txtTypes.TabIndex = 12
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(136, 330)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 13
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.lblLiliesb)
        Me.grpType.Controls.Add(Me.lblDaisesb)
        Me.grpType.Controls.Add(Me.txtTypes)
        Me.grpType.Controls.Add(Me.lblHydrangeas)
        Me.grpType.Controls.Add(Me.lblRosesb)
        Me.grpType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.Location = New System.Drawing.Point(12, 165)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(276, 142)
        Me.grpType.TabIndex = 14
        Me.grpType.TabStop = False
        Me.grpType.Text = "Types"
        '
        'lblLiliesb
        '
        Me.lblLiliesb.AutoSize = True
        Me.lblLiliesb.Location = New System.Drawing.Point(146, 63)
        Me.lblLiliesb.Name = "lblLiliesb"
        Me.lblLiliesb.Size = New System.Drawing.Size(49, 21)
        Me.lblLiliesb.TabIndex = 11
        Me.lblLiliesb.Text = "Lilies"
        '
        'lblDaisesb
        '
        Me.lblDaisesb.AutoSize = True
        Me.lblDaisesb.Location = New System.Drawing.Point(38, 63)
        Me.lblDaisesb.Name = "lblDaisesb"
        Me.lblDaisesb.Size = New System.Drawing.Size(59, 21)
        Me.lblDaisesb.TabIndex = 10
        Me.lblDaisesb.Text = "Daises"
        '
        'lblHydrangeas
        '
        Me.lblHydrangeas.AutoSize = True
        Me.lblHydrangeas.Location = New System.Drawing.Point(123, 25)
        Me.lblHydrangeas.Name = "lblHydrangeas"
        Me.lblHydrangeas.Size = New System.Drawing.Size(101, 21)
        Me.lblHydrangeas.TabIndex = 9
        Me.lblHydrangeas.Text = "Hydrangeas"
        '
        'lblQuantity1
        '
        Me.lblQuantity1.AutoSize = True
        Me.lblQuantity1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity1.Location = New System.Drawing.Point(242, 77)
        Me.lblQuantity1.Name = "lblQuantity1"
        Me.lblQuantity1.Size = New System.Drawing.Size(363, 21)
        Me.lblQuantity1.TabIndex = 15
        Me.lblQuantity1.Text = "Then list the amount desired in the quantity box."
        '
        'lblContainer
        '
        Me.lblContainer.AutoSize = True
        Me.lblContainer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainer.Location = New System.Drawing.Point(233, 98)
        Me.lblContainer.Name = "lblContainer"
        Me.lblContainer.Size = New System.Drawing.Size(382, 21)
        Me.lblContainer.TabIndex = 16
        Me.lblContainer.Text = "Then selesct your accents, and preferred container."
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheck.Location = New System.Drawing.Point(309, 119)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(238, 21)
        Me.lblCheck.TabIndex = 17
        Me.lblCheck.Text = "Click CHECKOUT when finished."
        '
        'btnClearb
        '
        Me.btnClearb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearb.Location = New System.Drawing.Point(83, 377)
        Me.btnClearb.Name = "btnClearb"
        Me.btnClearb.Size = New System.Drawing.Size(103, 32)
        Me.btnClearb.TabIndex = 18
        Me.btnClearb.Text = "CLEAR"
        Me.btnClearb.UseVisualStyleBackColor = True
        '
        'btnExitb
        '
        Me.btnExitb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitb.Location = New System.Drawing.Point(685, 402)
        Me.btnExitb.Name = "btnExitb"
        Me.btnExitb.Size = New System.Drawing.Size(141, 49)
        Me.btnExitb.TabIndex = 19
        Me.btnExitb.Text = "MAIN MENU"
        Me.btnExitb.UseVisualStyleBackColor = True
        '
        'frmBouquet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(838, 463)
        Me.Controls.Add(Me.btnClearb)
        Me.Controls.Add(Me.btnExitb)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lblContainer)
        Me.Controls.Add(Me.lblQuantity1)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity2)
        Me.Controls.Add(Me.grpContainer)
        Me.Controls.Add(Me.grpAccent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBouquet)
        Me.Name = "frmBouquet"
        Me.Text = "Build Your Bouquet"
        Me.grpAccent.ResumeLayout(False)
        Me.grpAccent.PerformLayout()
        Me.grpContainer.ResumeLayout(False)
        Me.grpContainer.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBouquet As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpAccent As GroupBox
    Friend WithEvents lblRosesb As Label
    Friend WithEvents grpContainer As GroupBox
    Friend WithEvents chkFern As CheckBox
    Friend WithEvents chkBaby As CheckBox
    Friend WithEvents chkMini As CheckBox
    Friend WithEvents radBasket As RadioButton
    Friend WithEvents radMason As RadioButton
    Friend WithEvents radVase As RadioButton
    Friend WithEvents lblQuantity2 As Label
    Friend WithEvents txtTypes As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents grpType As GroupBox
    Friend WithEvents lblLiliesb As Label
    Friend WithEvents lblDaisesb As Label
    Friend WithEvents lblHydrangeas As Label
    Friend WithEvents lblQuantity1 As Label
    Friend WithEvents lblContainer As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblCheck As Label
    Friend WithEvents btnClearb As Button
    Friend WithEvents btnExitb As Button
End Class
