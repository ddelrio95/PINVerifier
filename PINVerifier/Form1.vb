Public Class Form1

    Dim intMin() As Integer
    Dim intMax() As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intMin = New Integer() {7, 5, 0, 0, 6, 3, 4}
        intMax = New Integer() {9, 7, 4, 9, 9, 6, 8}
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtBox1.Text = ""
        TxtBox1.Focus()
    End Sub

    

    Private Sub TxtBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim violatednumber As String = ""
        Dim textboxaray() As Char = TxtBox1.Text.ToCharArray

        If ((TxtBox1.Text = "") And (textboxaray.Length < 6)) Then
            MessageBox.Show("please enter 7  digits ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If (textboxaray.Length < 6) Then

                MessageBox.Show("please enter 7  digits you not enter 7 digits  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If (Val(textboxaray(0)) >= intMin(0)) And (Val(textboxaray(0)) <= intMax(0)) Then
                Else


                    violatednumber += "1" + " ,"
                End If

                If (Val(textboxaray(1)) >= intMin(1)) And (Val(textboxaray(1)) <= intMax(1)) Then

                Else

                    violatednumber += "2" + " ,"
                End If

                If (Val(textboxaray(2)) >= intMin(2)) And (Val(textboxaray(2)) <= intMax(2)) Then

                Else

                    violatednumber += "3" + " ,"
                End If

                If (Val(textboxaray(3)) >= intMin(3)) And (Val(textboxaray(3)) <= intMax(3)) Then

                Else
                    violatednumber += "4" + " ,"
                End If

                If (Val(textboxaray(4)) >= intMin(4)) And (Val(textboxaray(4)) <= intMax(4)) Then

                Else

                    violatednumber += "5" + " ,"
                End If
                If (Val(textboxaray(5)) >= intMin(5)) And (Val(textboxaray(5)) <= intMax(5)) Then

                Else


                    violatednumber += "6" + " ,"
                End If

                If (Val(textboxaray(6)) >= intMin(6)) And (Val(textboxaray(6)) <= intMax(6)) Then

                Else

                    violatednumber += "7"
                End If


                If (violatednumber.Length > 0) Then

                    MessageBox.Show("that digit  " + violatednumber + " violate the rules", "violated number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("All entries are valid", "Pin Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub
End Class
