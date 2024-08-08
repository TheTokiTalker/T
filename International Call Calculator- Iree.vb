Public Class Form1
    Private dictCountryRates As New Dictionary(Of String, Decimal)()
    Private dictMembershipDiscounts As New Dictionary(Of String, Decimal)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountryRates()
        LoadMembershipDiscounts()
        PopulateCountryComboBox()
    End Sub

    Private Sub LoadCountryRates()
        Dim countryRatesData As String = "Brazil,0.75|Canada,1.00|China,0.65|India,0.60|Japan,0.70|Malaysia,0.80|Mexico,0.90|New Zealand,0.85|Oman,0.95|Russia,0.85|Singapore,0.75|UK,1.10|USA,0.55"
        Dim arrRates As String() = countryRatesData.Split("|"c)
        For Each rate As String In arrRates
            Dim parts As String() = rate.Split(","c)
            dictCountryRates(parts(0)) = Decimal.Parse(parts(1), Globalization.CultureInfo.InvariantCulture)
        Next
    End Sub

    Private Sub LoadMembershipDiscounts()
        dictMembershipDiscounts("Gold") = 0.25D
        dictMembershipDiscounts("Silver") = 0.75D
        dictMembershipDiscounts("Bronze") = 1.5D
        dictMembershipDiscounts("No Plan") = 2D
    End Sub

    Private Sub PopulateCountryComboBox()
        CmbCountry.Items.Clear()
        For Each strCountry As String In dictCountryRates.Keys
            CmbCountry.Items.Add(strCountry)
        Next
    End Sub

    Private Function GetFlagfall() As Decimal
        If rdoGold.Checked Then Return dictMembershipDiscounts("Gold")
        If rdoSilver.Checked Then Return dictMembershipDiscounts("Silver")
        If rdoBronze.Checked Then Return dictMembershipDiscounts("Bronze")
        Return dictMembershipDiscounts("No Plan")
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Try
            Dim decCallLength As Decimal = Decimal.Parse(TxtCallLength.Text)
            If decCallLength < 0 Or decCallLength > 500 Then
                MessageBox.Show("Please enter a valid call length between 0 and 500 minutes.")
                Return
            End If
            Dim decRate As Decimal = dictCountryRates(CmbCountry.SelectedItem.ToString())
            Dim decFlagfall As Decimal = GetFlagfall()
            Dim decSubTotal As Decimal = (decCallLength * decRate) + decFlagfall
            If ChkEveningCalls.Checked Then decSubTotal *= 0.8D
            Dim decGST As Decimal = decSubTotal * 0.1D
            Dim decAmountPayable As Decimal = decSubTotal + decGST

            txtSubTotal.Text = decSubTotal.ToString("C")
            txtGST.Text = decGST.ToString("C")
            txtAmountPayable.Text = decAmountPayable.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Please enter valid input values.")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim savePath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "call_details.txt")
        Dim data As String = String.Format("Full Name: {0}{1}Call Length: {2}{1}Country: {3}{1}Membership Type: {4}{1}Evening Call: {5}{1}Sub Total: {6}{1}GST: {7}{1}Amount Payable: {8}{1}{1}",
           TxtFullName.Text, Environment.NewLine, TxtCallLength.Text, CmbCountry.SelectedItem.ToString(),
            If(rdoGold.Checked, "Gold", If(rdoSilver.Checked, "Silver", If(rdoBronze.Checked, "Bronze", "No Plan"))),
            If(ChkEveningCalls.Checked, "Yes", "No"), txtSubTotal.Text, txtGST.Text, txtAmountPayable.Text)
        IO.File.AppendAllText(savePath, data)
        MessageBox.Show("Call details saved successfully.")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
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
        Me.Close()
    End Sub
End Class
