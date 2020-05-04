'Declare Global Variables

Module Globals
    Public Types, Accents, Cont, Quantity, Tax, Subtotal, Total As Double
    Public TYPE As String
End Module

'Dim variables

Public Class frmBouquet
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Types = 0

        Accents = 0

        Cont = 0

        TYPE = txtTypes.Text

        Const T As Double = 0.08875

        Quantity = CInt(txtQuantity.Text)

        'Calculate and prep user's choices to be output to form 4, using If End If Statements

        If (txtTypes.Text = "Roses") Then
            Types = Types + 2.8 * (txtQuantity.Text)

        ElseIf (txtTypes.Text = "Daises") Then
            Types = Types + 2 * (txtQuantity.Text)

        ElseIf (txtTypes.Text = "Hydrangeas") Then
            Types = Types + 5 * (txtQuantity.Text)

        ElseIf (txtTypes.Text = "Lilies") Then
            Types = Types + 3 * (txtQuantity.Text)

        End If

        If (chkMini.Checked = True) Then
            Accents = Accents + 2.65
        End If

        If (chkBaby.Checked = True) Then
            Accents = Accents + 1.5
        End If

        If (chkFern.Checked = True) Then
            Accents = Accents + 1.25
        End If

        If (radVase.Checked = True) Then
            Cont = Cont + 6

        ElseIf (radMason.Checked = True) Then
            Cont = Cont + 4

        ElseIf (radBasket.Checked = True) Then
            Cont = Cont + 8

        End If

        'Dim additional variables

        Subtotal = Types + Accents + Cont
        Tax = Subtotal * T
        Total = Subtotal + Tax

        'Show form 4 yet hide form 3

        frmCheckout.Show()
        Me.Hide()


    End Sub

    Private Sub btnClearb_Click(sender As Object, e As EventArgs) Handles btnClearb.Click
        txtTypes.Clear()
        txtQuantity.Clear()
        chkMini.Checked = False
        chkBaby.Checked = False
        chkFern.Checked = False
        radVase.Checked = False
        radMason.Checked = False
        radBasket.Checked = False
    End Sub

    Private Sub btnExitb_Click(sender As Object, e As EventArgs) Handles btnExitb.Click
        Me.Close()
        frmInc.Show()
    End Sub
End Class