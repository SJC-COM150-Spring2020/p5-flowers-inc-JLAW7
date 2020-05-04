'Used If Else If statements for user, outputing their choices to a listbox ith choice's picture and phrase.

Public Class frmQuiz
    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click

        If (radRose.Checked = True) Then
            picRose.Visible = True
            lblRoses.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose roses!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Roses - You think with your heart,")
            lstQuiz.Items.Add("and know how to make a statement!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        ElseIf (radTulip.Checked = True) Then
            picTulip.Visible = True
            lblTulips.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose tulips!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Tulips - You are thoughtful and confident,")
            lstQuiz.Items.Add("and are always coordinated.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        ElseIf (radDaisy.Checked = True) Then
            picDaisy.Visible = True
            lblDaises.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose daises!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Daisies - You are an optimist who can find")
            lstQuiz.Items.Add("the good in any bad situation.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        ElseIf (radDaffodil.Checked = True) Then
            picDaffodil.Visible = True
            lblDaffodils.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose daffodils!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Daffodils - You are fun and laid-back")
            lstQuiz.Items.Add("and always put friends and family first.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        ElseIf (radSunflower.Checked = True) Then
            picSunflower.Visible = True
            lblSunflowers.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose sunflowers!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Sunflowers - You love to be around people")
            lstQuiz.Items.Add("and make new friends.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        ElseIf (radLily.Checked = True) Then
            picLily.Visible = True
            lblLilies.Visible = True
            btnReveal.Visible = False
            lstQuiz.Items.Add(txtName.Text & "-" & " You chose lilies!")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Lilies - You are hard worker")
            lstQuiz.Items.Add("and proud of all you accomplish.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Next, please click the EXIT button")
            lstQuiz.Items.Add("to return to the home screen.")
            lstQuiz.Items.Add("")
            lstQuiz.Items.Add("Then click on the build button")
            lstQuiz.Items.Add("to start your bouquet!")
        End If
    End Sub

    'added exit button to close quiz and return to main form

    Private Sub btnExitquiz_Click(sender As Object, e As EventArgs) Handles btnExitquiz.Click

        Me.Close()
        frmInc.Show()

    End Sub

    'Added clear button, removing user's choices and data, allowing for the user to take the quiz again.

    Private Sub btnClearquiz_Click(sender As Object, e As EventArgs) Handles btnClearquiz.Click
        lstQuiz.Items.Clear()
        radSunflower.Checked = False
        radDaisy.Checked = False
        radRose.Checked = False
        radDaffodil.Checked = False
        radTulip.Checked = False
        radLily.Checked = False
        txtName.Clear()
        lblRoses.Visible = False
        lblDaises.Visible = False
        lblDaffodils.Visible = False
        lblLilies.Visible = False
        lblSunflowers.Visible = False
        lblTulips.Visible = False
        picRose.Visible = False
        picDaisy.Visible = False
        picDaffodil.Visible = False
        picLily.Visible = False
        picSunflower.Visible = False
        picTulip.Visible = False
        btnReveal.Visible = True

    End Sub
End Class