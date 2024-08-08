Imports System.IO
Imports System.Globalization

<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Form1
    Private dictCountryRates As Dictionary(Of String, Decimal)
    Private dictMembershipDiscounts As Dictionary(Of String, Decimal)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountryRates("C:\Users\ireem\Downloads\countries.csv")
        LoadMembershipDiscounts("C:\Users\ireem\Downloads\Passport\flagfall.csv")
        PopulateCountryComboBox()
    End Sub

    Private Sub LoadCountryRates(filePath As String)
        dictCountryRates = New Dictionary(Of String, Decimal)()
        Using reader As New StreamReader(filePath)
            Dim strLine As String
            reader.ReadLine() ' Skip header line
            While True
                strLine = reader.ReadLine()
                If strLine Is Nothing Then Exit While

                Dim arrParts As String() = strLine.Split(","c)
                Dim strCountry As String = arrParts(0)
                Dim decRate As Decimal = Decimal.Parse(arrParts(1), CultureInfo.InvariantCulture)
                dictCountryRates(strCountry) = decRate
            End While
        End Using
    End Sub

    Private Sub LoadMembershipDiscounts(filePath As String)
        dictMembershipDiscounts = New Dictionary(Of String, Decimal)()
        Using reader As New StreamReader(filePath)
            Dim strLine As String
            reader.ReadLine() ' Skip header line
            While True
                strLine = reader.ReadLine()
                If strLine Is Nothing Then Exit While

                Dim arrParts As String() = strLine.Split(","c)
                Dim strMembership As String = arrParts(0)
                Dim decDiscount As Decimal = Decimal.Parse(arrParts(1), CultureInfo.InvariantCulture)
                dictMembershipDiscounts(strMembership) = decDiscount
            End While
        End Using
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
            Dim strCountry As String = CmbCountry.SelectedItem.ToString()
            Dim blnIsEveningCall As Boolean = ChkEveningCalls.Checked

            If decCallLength < 0 Or decCallLength > 500 Then
                MessageBox.Show("Please enter a valid call length between 0 and 500 minutes.")
                Return
            End If

            Dim decRate As Decimal = dictCountryRates(strCountry)
            Dim decFlagfall As Decimal = GetFlagfall()
            Dim decSubTotal As Decimal = (decCallLength * decRate) + decFlagfall

            If blnIsEveningCall Then
                decSubTotal *= 0.8D ' Apply 20% discount for evening calls
            End If

            Dim decGST As Decimal = decSubTotal * 0.1D ' GST is 10%
            Dim decAmountPayable As Decimal = decSubTotal + decGST

            txtSubTotal.Text = decSubTotal.ToString("C")
            txtGST.Text = decGST.ToString("C")
            txtAmountPayable.Text = decAmountPayable.ToString("C")

        Catch ex As Exception
            MessageBox.Show("Please enter valid input values.")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Specify the path to save the file
        Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "call_details.txt")

        Using writer As New StreamWriter(savePath, True)
            writer.WriteLine("Full Name: " & TxtFullName.Text)
            writer.WriteLine("Call Length: " & TxtCallLength.Text)
            writer.WriteLine("Country: " & CmbCountry.SelectedItem.ToString())
            writer.WriteLine("Membership Type: " & If(rdoGold.Checked, "Gold", If(rdoSilver.Checked, "Silver", If(rdoBronze.Checked, "Bronze", "No Plan"))))
            writer.WriteLine("Evening Call: " & If(ChkEveningCalls.Checked, "Yes", "No"))
            writer.WriteLine("Sub Total: " & txtSubTotal.Text)
            writer.WriteLine("GST: " & txtGST.Text)
            writer.WriteLine("Amount Payable: " & txtAmountPayable.Text)
            writer.WriteLine()
        End Using
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

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function
End Class
