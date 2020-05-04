<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picField = New System.Windows.Forms.PictureBox()
        Me.lblBouquet = New System.Windows.Forms.Label()
        Me.lblQuiz = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnBouquet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FLOWERS INC."
        '
        'lblGreetings
        '
        Me.lblGreetings.AutoSize = True
        Me.lblGreetings.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreetings.Location = New System.Drawing.Point(226, 74)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(389, 32)
        Me.lblGreetings.TabIndex = 1
        Me.lblGreetings.Text = "Welcome to Flowers Incorporated!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(661, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Our flowers are grown from our high-grade gardens, enriched with natural, nutrien" &
    "t filled soil!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Thus, providing the healthiest flowers with the most vivid colors!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "All arranged to your liking!"
        '
        'picField
        '
        Me.picField.Image = CType(resources.GetObject("picField.Image"), System.Drawing.Image)
        Me.picField.Location = New System.Drawing.Point(494, 197)
        Me.picField.Name = "picField"
        Me.picField.Size = New System.Drawing.Size(341, 193)
        Me.picField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picField.TabIndex = 5
        Me.picField.TabStop = False
        '
        'lblBouquet
        '
        Me.lblBouquet.AutoSize = True
        Me.lblBouquet.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBouquet.Location = New System.Drawing.Point(58, 319)
        Me.lblBouquet.Name = "lblBouquet"
        Me.lblBouquet.Size = New System.Drawing.Size(417, 17)
        Me.lblBouquet.TabIndex = 6
        Me.lblBouquet.Text = "Or click on the button below, to get started building your bouquet!"
        '
        'lblQuiz
        '
        Me.lblQuiz.AutoSize = True
        Me.lblQuiz.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuiz.Location = New System.Drawing.Point(199, 197)
        Me.lblQuiz.Name = "lblQuiz"
        Me.lblQuiz.Size = New System.Drawing.Size(134, 17)
        Me.lblQuiz.TabIndex = 7
        Me.lblQuiz.Text = "Please take our quiz!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(443, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Choose your favorite flower! Find out what your flower says about you!"
        '
        'btnQuiz
        '
        Me.btnQuiz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuiz.Location = New System.Drawing.Point(202, 270)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(119, 33)
        Me.btnQuiz.TabIndex = 9
        Me.btnQuiz.Text = "Take the Quiz!"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnBouquet
        '
        Me.btnBouquet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBouquet.Location = New System.Drawing.Point(202, 356)
        Me.btnBouquet.Name = "btnBouquet"
        Me.btnBouquet.Size = New System.Drawing.Size(119, 34)
        Me.btnBouquet.TabIndex = 10
        Me.btnBouquet.Text = "Build"
        Me.btnBouquet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(847, 463)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBouquet)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblQuiz)
        Me.Controls.Add(Me.lblBouquet)
        Me.Controls.Add(Me.picField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGreetings)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInc"
        Me.Text = "FLOWERS INC. "
        CType(Me.picField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGreetings As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picField As PictureBox
    Friend WithEvents lblBouquet As Label
    Friend WithEvents lblQuiz As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnBouquet As Button
    Friend WithEvents Button1 As Button
End Class
