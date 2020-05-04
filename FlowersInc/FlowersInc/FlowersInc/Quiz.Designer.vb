<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuiz))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpFlowers1 = New System.Windows.Forms.GroupBox()
        Me.radLily = New System.Windows.Forms.RadioButton()
        Me.radSunflower = New System.Windows.Forms.RadioButton()
        Me.radDaffodil = New System.Windows.Forms.RadioButton()
        Me.radDaisy = New System.Windows.Forms.RadioButton()
        Me.radTulip = New System.Windows.Forms.RadioButton()
        Me.radRose = New System.Windows.Forms.RadioButton()
        Me.picRose = New System.Windows.Forms.PictureBox()
        Me.picDaffodil = New System.Windows.Forms.PictureBox()
        Me.picDaisy = New System.Windows.Forms.PictureBox()
        Me.picSunflower = New System.Windows.Forms.PictureBox()
        Me.picTulip = New System.Windows.Forms.PictureBox()
        Me.picLily = New System.Windows.Forms.PictureBox()
        Me.lblRoses = New System.Windows.Forms.Label()
        Me.lstQuiz = New System.Windows.Forms.ListBox()
        Me.lblTulips = New System.Windows.Forms.Label()
        Me.lblDaises = New System.Windows.Forms.Label()
        Me.lblDaffodils = New System.Windows.Forms.Label()
        Me.lblSunflowers = New System.Windows.Forms.Label()
        Me.lblLilies = New System.Windows.Forms.Label()
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.btnExitquiz = New System.Windows.Forms.Button()
        Me.btnClearquiz = New System.Windows.Forms.Button()
        Me.grpFlowers1.SuspendLayout()
        CType(Me.picRose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaffodil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaisy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTulip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What does your Flower say about you?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please type in your name."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(579, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Then choose your favorite flower below, then click the button to reveal what your" &
    " flower says!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(74, 165)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 4
        '
        'grpFlowers1
        '
        Me.grpFlowers1.Controls.Add(Me.radLily)
        Me.grpFlowers1.Controls.Add(Me.radSunflower)
        Me.grpFlowers1.Controls.Add(Me.radDaffodil)
        Me.grpFlowers1.Controls.Add(Me.radDaisy)
        Me.grpFlowers1.Controls.Add(Me.radTulip)
        Me.grpFlowers1.Controls.Add(Me.radRose)
        Me.grpFlowers1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFlowers1.Location = New System.Drawing.Point(15, 191)
        Me.grpFlowers1.Name = "grpFlowers1"
        Me.grpFlowers1.Size = New System.Drawing.Size(267, 160)
        Me.grpFlowers1.TabIndex = 5
        Me.grpFlowers1.TabStop = False
        Me.grpFlowers1.Text = "Flower"
        '
        'radLily
        '
        Me.radLily.AutoSize = True
        Me.radLily.Location = New System.Drawing.Point(154, 115)
        Me.radLily.Name = "radLily"
        Me.radLily.Size = New System.Drawing.Size(55, 25)
        Me.radLily.TabIndex = 5
        Me.radLily.TabStop = True
        Me.radLily.Text = "Lily"
        Me.radLily.UseVisualStyleBackColor = True
        '
        'radSunflower
        '
        Me.radSunflower.AutoSize = True
        Me.radSunflower.Location = New System.Drawing.Point(154, 75)
        Me.radSunflower.Name = "radSunflower"
        Me.radSunflower.Size = New System.Drawing.Size(106, 25)
        Me.radSunflower.TabIndex = 4
        Me.radSunflower.TabStop = True
        Me.radSunflower.Text = "Sunflower"
        Me.radSunflower.UseVisualStyleBackColor = True
        '
        'radDaffodil
        '
        Me.radDaffodil.AutoSize = True
        Me.radDaffodil.Location = New System.Drawing.Point(154, 35)
        Me.radDaffodil.Name = "radDaffodil"
        Me.radDaffodil.Size = New System.Drawing.Size(91, 25)
        Me.radDaffodil.TabIndex = 3
        Me.radDaffodil.TabStop = True
        Me.radDaffodil.Text = "Daffodil"
        Me.radDaffodil.UseVisualStyleBackColor = True
        '
        'radDaisy
        '
        Me.radDaisy.AutoSize = True
        Me.radDaisy.Location = New System.Drawing.Point(16, 115)
        Me.radDaisy.Name = "radDaisy"
        Me.radDaisy.Size = New System.Drawing.Size(70, 25)
        Me.radDaisy.TabIndex = 2
        Me.radDaisy.TabStop = True
        Me.radDaisy.Text = "Daisy"
        Me.radDaisy.UseVisualStyleBackColor = True
        '
        'radTulip
        '
        Me.radTulip.AutoSize = True
        Me.radTulip.Location = New System.Drawing.Point(16, 75)
        Me.radTulip.Name = "radTulip"
        Me.radTulip.Size = New System.Drawing.Size(66, 25)
        Me.radTulip.TabIndex = 1
        Me.radTulip.TabStop = True
        Me.radTulip.Text = "Tulip"
        Me.radTulip.UseVisualStyleBackColor = True
        '
        'radRose
        '
        Me.radRose.AutoSize = True
        Me.radRose.Location = New System.Drawing.Point(16, 35)
        Me.radRose.Name = "radRose"
        Me.radRose.Size = New System.Drawing.Size(64, 25)
        Me.radRose.TabIndex = 0
        Me.radRose.TabStop = True
        Me.radRose.Text = "Rose"
        Me.radRose.UseVisualStyleBackColor = True
        '
        'picRose
        '
        Me.picRose.Image = CType(resources.GetObject("picRose.Image"), System.Drawing.Image)
        Me.picRose.Location = New System.Drawing.Point(296, 165)
        Me.picRose.Name = "picRose"
        Me.picRose.Size = New System.Drawing.Size(277, 186)
        Me.picRose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRose.TabIndex = 6
        Me.picRose.TabStop = False
        Me.picRose.Visible = False
        '
        'picDaffodil
        '
        Me.picDaffodil.Image = CType(resources.GetObject("picDaffodil.Image"), System.Drawing.Image)
        Me.picDaffodil.Location = New System.Drawing.Point(296, 165)
        Me.picDaffodil.Name = "picDaffodil"
        Me.picDaffodil.Size = New System.Drawing.Size(277, 186)
        Me.picDaffodil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaffodil.TabIndex = 7
        Me.picDaffodil.TabStop = False
        Me.picDaffodil.Visible = False
        '
        'picDaisy
        '
        Me.picDaisy.Image = CType(resources.GetObject("picDaisy.Image"), System.Drawing.Image)
        Me.picDaisy.Location = New System.Drawing.Point(296, 165)
        Me.picDaisy.Name = "picDaisy"
        Me.picDaisy.Size = New System.Drawing.Size(277, 186)
        Me.picDaisy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picDaisy.TabIndex = 8
        Me.picDaisy.TabStop = False
        Me.picDaisy.Visible = False
        '
        'picSunflower
        '
        Me.picSunflower.Image = CType(resources.GetObject("picSunflower.Image"), System.Drawing.Image)
        Me.picSunflower.Location = New System.Drawing.Point(296, 165)
        Me.picSunflower.Name = "picSunflower"
        Me.picSunflower.Size = New System.Drawing.Size(277, 186)
        Me.picSunflower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSunflower.TabIndex = 9
        Me.picSunflower.TabStop = False
        Me.picSunflower.Visible = False
        '
        'picTulip
        '
        Me.picTulip.Image = CType(resources.GetObject("picTulip.Image"), System.Drawing.Image)
        Me.picTulip.Location = New System.Drawing.Point(296, 165)
        Me.picTulip.Name = "picTulip"
        Me.picTulip.Size = New System.Drawing.Size(277, 186)
        Me.picTulip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTulip.TabIndex = 10
        Me.picTulip.TabStop = False
        Me.picTulip.Visible = False
        '
        'picLily
        '
        Me.picLily.Image = CType(resources.GetObject("picLily.Image"), System.Drawing.Image)
        Me.picLily.Location = New System.Drawing.Point(296, 164)
        Me.picLily.Name = "picLily"
        Me.picLily.Size = New System.Drawing.Size(277, 187)
        Me.picLily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLily.TabIndex = 11
        Me.picLily.TabStop = False
        Me.picLily.Visible = False
        '
        'lblRoses
        '
        Me.lblRoses.AutoSize = True
        Me.lblRoses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoses.Location = New System.Drawing.Point(672, 169)
        Me.lblRoses.Name = "lblRoses"
        Me.lblRoses.Size = New System.Drawing.Size(59, 21)
        Me.lblRoses.TabIndex = 12
        Me.lblRoses.Text = "ROSES"
        Me.lblRoses.Visible = False
        '
        'lstQuiz
        '
        Me.lstQuiz.FormattingEnabled = True
        Me.lstQuiz.Location = New System.Drawing.Point(590, 201)
        Me.lstQuiz.Name = "lstQuiz"
        Me.lstQuiz.Size = New System.Drawing.Size(226, 147)
        Me.lstQuiz.TabIndex = 13
        '
        'lblTulips
        '
        Me.lblTulips.AutoSize = True
        Me.lblTulips.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTulips.Location = New System.Drawing.Point(668, 169)
        Me.lblTulips.Name = "lblTulips"
        Me.lblTulips.Size = New System.Drawing.Size(63, 21)
        Me.lblTulips.TabIndex = 14
        Me.lblTulips.Text = "TULIPS"
        Me.lblTulips.Visible = False
        '
        'lblDaises
        '
        Me.lblDaises.AutoSize = True
        Me.lblDaises.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaises.Location = New System.Drawing.Point(666, 169)
        Me.lblDaises.Name = "lblDaises"
        Me.lblDaises.Size = New System.Drawing.Size(65, 21)
        Me.lblDaises.TabIndex = 15
        Me.lblDaises.Text = "DAISES"
        Me.lblDaises.Visible = False
        '
        'lblDaffodils
        '
        Me.lblDaffodils.AutoSize = True
        Me.lblDaffodils.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaffodils.Location = New System.Drawing.Point(653, 169)
        Me.lblDaffodils.Name = "lblDaffodils"
        Me.lblDaffodils.Size = New System.Drawing.Size(95, 21)
        Me.lblDaffodils.TabIndex = 16
        Me.lblDaffodils.Text = "DAFFODILS"
        Me.lblDaffodils.Visible = False
        '
        'lblSunflowers
        '
        Me.lblSunflowers.AutoSize = True
        Me.lblSunflowers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSunflowers.Location = New System.Drawing.Point(653, 169)
        Me.lblSunflowers.Name = "lblSunflowers"
        Me.lblSunflowers.Size = New System.Drawing.Size(116, 21)
        Me.lblSunflowers.TabIndex = 17
        Me.lblSunflowers.Text = "SUNFLOWERS"
        Me.lblSunflowers.Visible = False
        '
        'lblLilies
        '
        Me.lblLilies.AutoSize = True
        Me.lblLilies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLilies.Location = New System.Drawing.Point(677, 169)
        Me.lblLilies.Name = "lblLilies"
        Me.lblLilies.Size = New System.Drawing.Size(54, 21)
        Me.lblLilies.TabIndex = 18
        Me.lblLilies.Text = "LILIES"
        Me.lblLilies.Visible = False
        '
        'btnReveal
        '
        Me.btnReveal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReveal.Location = New System.Drawing.Point(387, 244)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(93, 36)
        Me.btnReveal.TabIndex = 19
        Me.btnReveal.Text = "Reveal!"
        Me.btnReveal.UseVisualStyleBackColor = True
        '
        'btnExitquiz
        '
        Me.btnExitquiz.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitquiz.Location = New System.Drawing.Point(681, 402)
        Me.btnExitquiz.Name = "btnExitquiz"
        Me.btnExitquiz.Size = New System.Drawing.Size(135, 47)
        Me.btnExitquiz.TabIndex = 20
        Me.btnExitquiz.Text = "MAIN MENU"
        Me.btnExitquiz.UseVisualStyleBackColor = True
        '
        'btnClearquiz
        '
        Me.btnClearquiz.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearquiz.Location = New System.Drawing.Point(387, 357)
        Me.btnClearquiz.Name = "btnClearquiz"
        Me.btnClearquiz.Size = New System.Drawing.Size(93, 37)
        Me.btnClearquiz.TabIndex = 21
        Me.btnClearquiz.Text = "CLEAR"
        Me.btnClearquiz.UseVisualStyleBackColor = True
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(831, 461)
        Me.Controls.Add(Me.btnClearquiz)
        Me.Controls.Add(Me.btnExitquiz)
        Me.Controls.Add(Me.btnReveal)
        Me.Controls.Add(Me.lstQuiz)
        Me.Controls.Add(Me.grpFlowers1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLilies)
        Me.Controls.Add(Me.lblDaises)
        Me.Controls.Add(Me.lblTulips)
        Me.Controls.Add(Me.lblSunflowers)
        Me.Controls.Add(Me.lblRoses)
        Me.Controls.Add(Me.lblDaffodils)
        Me.Controls.Add(Me.picLily)
        Me.Controls.Add(Me.picTulip)
        Me.Controls.Add(Me.picSunflower)
        Me.Controls.Add(Me.picDaisy)
        Me.Controls.Add(Me.picDaffodil)
        Me.Controls.Add(Me.picRose)
        Me.Name = "frmQuiz"
        Me.Text = "Flower Quiz"
        Me.grpFlowers1.ResumeLayout(False)
        Me.grpFlowers1.PerformLayout()
        CType(Me.picRose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaffodil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaisy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTulip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpFlowers1 As GroupBox
    Friend WithEvents radLily As RadioButton
    Friend WithEvents radSunflower As RadioButton
    Friend WithEvents radDaffodil As RadioButton
    Friend WithEvents radDaisy As RadioButton
    Friend WithEvents radTulip As RadioButton
    Friend WithEvents radRose As RadioButton
    Friend WithEvents picRose As PictureBox
    Friend WithEvents picDaffodil As PictureBox
    Friend WithEvents picDaisy As PictureBox
    Friend WithEvents picSunflower As PictureBox
    Friend WithEvents picTulip As PictureBox
    Friend WithEvents picLily As PictureBox
    Friend WithEvents lblRoses As Label
    Friend WithEvents lstQuiz As ListBox
    Friend WithEvents lblTulips As Label
    Friend WithEvents lblDaises As Label
    Friend WithEvents lblDaffodils As Label
    Friend WithEvents lblSunflowers As Label
    Friend WithEvents lblLilies As Label
    Friend WithEvents btnReveal As Button
    Friend WithEvents btnExitquiz As Button
    Friend WithEvents btnClearquiz As Button
End Class
