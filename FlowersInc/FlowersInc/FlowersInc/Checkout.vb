Public Class frmCheckout
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'Output Personal Info to list box

        lstCheck.Items.Add("FIRST NAME: " & txtFirst.Text)
        lstCheck.Items.Add("LAST NAME: " & txtLast.Text)
        lstCheck.Items.Add("Address: " & txtStreet.Text & ", " & txtCity.Text & ", " & txtState.Text & ", " & txtZip.Text)

        'Output user's type from form 3, and type total

        lstCheck.Items.Add("TYPE: " & TYPE & " " & FormatCurrency(Types, 2))

        'Input If End If Statements to Output Accent choices to listbox, and Accent total

        If (frmBouquet.chkMini.Checked = True) Then
            lstCheck.Items.Add("ACCENTS: Mini Spray Roses- $2.65 ")
        End If

        If (frmBouquet.chkBaby.Checked = True) Then
            lstCheck.Items.Add("ACCENTS: Baby's Breath- $1.50 ")
        End If

        If (frmBouquet.chkFern.Checked = True) Then
            lstCheck.Items.Add("ACCENTS: Leather Leaf Fern- $1.25 ")
        End If

        lstCheck.Items.Add("ACCENTS TOTAL: " & FormatCurrency(Accents, 2))

        'Input If End If statments to output Container choice to listbox, and container total

        If (frmBouquet.radVase.Checked = True) Then
            lstCheck.Items.Add("CONTAINER: Vase- $6.00 ")
        End If

        If (frmBouquet.radMason.Checked = True) Then
            lstCheck.Items.Add("CONATINER: Mason- $4.00 ")
        End If

        If (frmBouquet.radBasket.Checked = True) Then
            lstCheck.Items.Add("CONTAINER: Basket- $8.00 ")
        End If

        lstCheck.Items.Add("CONTAINER TOTAL: " & FormatCurrency(Cont, 2))

        'Output subtotal, tax, and total of the user's choices to listbox, and reveals GIF and order confirmation to other listbox

        lstCheck.Items.Add("SUBTOTAL: " & FormatCurrency(Subtotal, 2))

        lstCheck.Items.Add("TAX: " & FormatCurrency(Tax, 2))

        lstCheck.Items.Add("TOTAL: " & FormatCurrency(Total, 2))

        picFlowergif.Visible = True

        lstConfirm.Visible = True

        lstConfirm.Items.Add("Thank you for your order!")

        lstConfirm.Items.Add("We will ship your purchase within 3-5 business days.")

        lstConfirm.Items.Add("Thank you again for shopping with FLOWERS INC.!")

        lstConfirm.Items.Add("Have a great day!")


    End Sub

    'Added a button to allow user to return to the main menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmInc.Show()
    End Sub
End Class