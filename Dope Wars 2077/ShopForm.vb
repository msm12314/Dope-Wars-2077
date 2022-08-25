Public Class ShopForm
    Public Property varCash As Long
    Dim GunPriceList(2) As Long




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            GunCostLabel.Text = "$" & GunPriceList(0).ToString
        End If

        If ComboBox1.SelectedIndex = 1 Then
            GunCostLabel.Text = "$" & GunPriceList(1).ToString
        End If

        If ComboBox1.SelectedIndex = 2 Then
            GunCostLabel.Text = "$" & GunPriceList(2).ToString
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerCashLabel.Text = varCash.ToString
        ComboBox1.Items.Add("Pistol")
        ComboBox1.Items.Add("Shotgun")
        ComboBox1.Items.Add("Assault Rifle")
        GunPriceList(0) = 1500
        GunPriceList(1) = 5500
        GunPriceList(2) = 10000
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyVar As Integer
        MyVar = ComboBox1.SelectedIndex
        If varCash < GunPriceList(MyVar) Then
            MessageBox.Show("Not Enough Cash.")
            Exit Sub
        End If

        If varCash >= GunPriceList(MyVar) Then
            varCash -= GunPriceList(MyVar)
            ' TODO - Add gun to weapon "slot"

            MessageBox.Show("Gun Purchased.")
        End If
    End Sub
End Class