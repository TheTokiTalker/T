Public Class Form1
    ' Declare variables
    Dim lengthOfCall As Decimal
    Dim costPerMinute As Decimal
    Dim flagfall As Decimal
    Dim subTotal As Decimal
    Dim gst As Decimal
    Dim total As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the dropdown box with country names
        CmbCountry.Items.Add("Brazil")
        CmbCountry.Items.Add("Canada")
        CmbCountry.Items.Add("China")
        CmbCountry.Items.Add("India")
        CmbCountry.Items.Add("Japan")
        CmbCountry.Items.Add("Malaysia")
        CmbCountry.Items.Add("Mexico")
        CmbCountry.Items.Add("New Zealand")
        CmbCountry.Items.Add("Oman")
        CmbCountry.Items.Add("Russia")
        CmbCountry.Items.Add("Singapore")
        CmbCountry.Items.Add("UK")
        CmbCountry.Items.Add("USA")

        ' Set the flagfall values for the radio buttons
        rdoGold.Tag = 0.25D
        rdoSilver.Tag = 0.75D
        rdoBronze.Tag = 1.5D
        rdoNoPlan.Tag = 2D
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        ' Check for valid input
        If String.IsNullOrWhiteSpace(TxtCallLength.Text) Or String.IsNullOrWhiteSpace(TxtFullName.Text) Then
            MsgBox("Please enter valid call length and full name.")
            Return
        End If

        lengthOfCall = Val(TxtCallLength.Text)
        If lengthOfCall <= 0 Or lengthOfCall > 500 Then
            MsgBox("Please enter a valid call length between 0 and 500.")
            Return
        End If

        ' Determine the cost per minute based on the selected country
        Dim country As String = CmbCountry.SelectedItem.ToString()
        If country = "Brazil" Then
            costPerMinute = 0.34D
        ElseIf country = "Canada" Then
            costPerMinute = 0.37D
        ElseIf country = "China" Then
            costPerMinute = 0.18D
        ElseIf country = "India" Then
            costPerMinute = 0.27D
        ElseIf country = "Japan" Then
            costPerMinute = 0.34D
        ElseIf country = "Malaysia" Then
            costPerMinute = 0.42D
        ElseIf country = "Mexico" Then
            costPerMinute = 0.22D
        ElseIf country = "New Zealand" Then
            costPerMinute = 0.22D
        ElseIf country = "Oman" Then
            costPerMinute = 0.5D
        ElseIf country = "Russia" Then
            costPerMinute = 0.4D
        ElseIf country = "Singapore" Then
            costPerMinute = 0.35D
        ElseIf country = "UK" Then
            costPerMinute = 0.37D
        ElseIf country = "USA" Then
            costPerMinute = 0.42D
        Else
            costPerMinute = 1.1D ' Other countries
        End If

        ' Get the flagfall from the selected membership type
        If rdoGold.Checked Then
            flagfall = rdoGold.Tag
        ElseIf rdoSilver.Checked Then
            flagfall = rdoSilver.Tag
        ElseIf rdoBronze.Checked Then
            flagfall = rdoBronze.Tag
        Else
            flagfall = rdoNoPlan.Tag
        End If

        ' Calculate the subtotal
        subTotal = (lengthOfCall * costPerMinute) + flagfall

        ' Apply discount if it's an evening call
        If ChkEveningCalls.Checked Then
            subTotal *= 0.8D ' Apply 20% discount
        End If

        ' Calculate GST and total amount payable
        gst = subTotal * 0.1D
        total = subTotal + gst

        ' Display the results
        txtSubTotal.Text = FormatCurrency(subTotal)
        txtGST.Text = FormatCurrency(gst)
        txtAmountPayable.Text = FormatCurrency(total)
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ' Reset all fields
        TxtFullName.Clear()
        TxtCallLength.Clear()
        CmbCountry.SelectedIndex = -1
        rdoNoPlan.Checked = True
        ChkEveningCalls.Checked = False
        txtSubTotal.Clear()
        txtGST.Clear()
        txtAmountPayable.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' Close the application
        Me.Close()
    End Sub
End Class