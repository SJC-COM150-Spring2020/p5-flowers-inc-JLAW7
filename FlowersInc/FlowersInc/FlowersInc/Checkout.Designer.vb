<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Me.lstCheck = New System.Windows.Forms.ListBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFlowergif = New System.Windows.Forms.PictureBox()
        Me.lstConfirm = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpAddress.SuspendLayout()
        CType(Me.picFlowergif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCheck
        '
        Me.lstCheck.FormattingEnabled = True
        Me.lstCheck.Location = New System.Drawing.Point(18, 300)
        Me.lstCheck.Name = "lstCheck"
        Me.lstCheck.Size = New System.Drawing.Size(309, 160)
        Me.lstCheck.TabIndex = 0
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(114, 75)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(81, 20)
        Me.txtFirst.TabIndex = 1
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(114, 107)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(81, 20)
        Me.txtLast.TabIndex = 2
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(71, 31)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(106, 20)
        Me.txtStreet.TabIndex = 3
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(10, 72)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(96, 21)
        Me.lblFirst.TabIndex = 4
        Me.lblFirst.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name:"
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.btnConfirm)
        Me.grpAddress.Controls.Add(Me.lblZip)
        Me.grpAddress.Controls.Add(Me.lblState)
        Me.grpAddress.Controls.Add(Me.txtZip)
        Me.grpAddress.Controls.Add(Me.txtState)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.lblCity)
        Me.grpAddress.Controls.Add(Me.lblStreet)
        Me.grpAddress.Controls.Add(Me.txtStreet)
        Me.grpAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.Location = New System.Drawing.Point(18, 133)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(309, 155)
        Me.grpAddress.TabIndex = 7
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(194, 57)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(99, 40)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(6, 108)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(43, 21)
        Me.lblZip.TabIndex = 10
        Me.lblZip.Text = "Zip: "
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(6, 82)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(53, 21)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "State:"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(71, 109)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(106, 20)
        Me.txtZip.TabIndex = 8
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(71, 83)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(106, 20)
        Me.txtState.TabIndex = 7
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(71, 57)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(106, 20)
        Me.txtCity.TabIndex = 6
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(7, 56)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(44, 21)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City:"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(6, 28)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(59, 21)
        Me.lblStreet.TabIndex = 4
        Me.lblStreet.Text = "Street:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CHECKOUT"
        '
        'picFlowergif
        '
        Me.picFlowergif.Image = CType(resources.GetObject("picFlowergif.Image"), System.Drawing.Image)
        Me.picFlowergif.Location = New System.Drawing.Point(344, 49)
        Me.picFlowergif.Name = "picFlowergif"
        Me.picFlowergif.Size = New System.Drawing.Size(323, 294)
        Me.picFlowergif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlowergif.TabIndex = 9
        Me.picFlowergif.TabStop = False
        Me.picFlowergif.Visible = False
        '
        'lstConfirm
        '
        Me.lstConfirm.FormattingEnabled = True
        Me.lstConfirm.Location = New System.Drawing.Point(344, 349)
        Me.lstConfirm.Name = "lstConfirm"
        Me.lstConfirm.Size = New System.Drawing.Size(323, 69)
        Me.lstConfirm.TabIndex = 10
        Me.lstConfirm.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(437, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "MAIN MENU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(683, 470)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstConfirm)
        Me.Controls.Add(Me.picFlowergif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lstCheck)
        Me.Name = "frmCheckout"
        Me.Text = "Checkout"
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        CType(Me.picFlowergif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCheck As ListBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picFlowergif As PictureBox
    Friend WithEvents lstConfirm As ListBox
    Friend WithEvents Button1 As Button
End Class
