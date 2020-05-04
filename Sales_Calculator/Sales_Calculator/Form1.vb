''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' This program Is used To calculate the sales, First user need To                '
' load sales prices into the application from saleList.txt file then             '
' user is allow to enter the sale price from saleList.txt which should           '
' be multiple of 10 (start from 10 to 100) and tax price will be calculated as   '
' if sub total is less than 50 then tax percentage is 10 and if sub total is     '
' greater than 50 and less than equal to 100 then tax percentage is 15 and if the'
' sub total Is greater than 100 and less than equal to 200 then txt percentage   '
' will be 20 And If Sub total Is greater Then 200 then tax percentage will 25    '
' percentage of sub total.                                                       '
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System.IO

Public Class form1
    ' This array variable is used to load the Price list from salesList.txt file
    Dim Price_List(9) As Integer

    ' This variable is used to store the subtotal of purchase.
    Dim subTotal As Integer = 0

    ' On Button click load the item prices from saleList.txt.
    Private Sub btn_LoadFile_Click(sender As Object,
                        e As EventArgs) Handles btn_LoadFile.Click

        ' Getting the path of current directory. 
        Dim path As String = Directory.GetCurrentDirectory()
        ' Set the path for saleList.txt. 
        Dim strFileName() As String = File.ReadAllLines(path + "\salesList.txt")

        ' Set the index value to 0.
        Dim index As Integer = 0

        ' Read each line from saleList.txt file.
        For Each currentLine In strFileName
            ' store the prices from salesList.txt file to Price_List array.
            Price_List(index) = Convert.ToInt32(currentLine)

            ' Increase the index value by 1 to get the 
            ' Next value from saleList.txt file.
            index = index + 1
        Next

        ' Display message to user.
        MessageBox.Show("Price List is loaded")
    End Sub

    ' In sub we are calculating values.
    Private Sub Btn_Purchase_Click(sender As Object,
                    e As EventArgs) Handles Btn_Purchase.Click

        ' check if puchase text box is empty
        If (txt_Purchase.Text = "") Then ' Then
            ' Display the error message to user.
            MessageBox.Show("Please enter puchase value")
        End If

        ' This variable is used to store the purchased value enter by user. 
        Dim value As Integer = Convert.ToInt32(txt_Purchase.Text)

        ' This variable is used to check if user enters the correct 
        ' purchase value.
        Dim found As Boolean = False

        ' Check the puchase value into Price_List
        For Each element In Price_List
            ' Check if user enters value is equal to current value in
            ' Price List.
            If (Convert.ToInt32(element) = value) Then
                found = True ' If yes then set the found to true
                Exit For
            End If
        Next

        ' Check if the value exists in Price List.
        If (found) Then ' If yes then.
            ' store the value into list box.
            Lst_Track.Items.Add(value)

            ' Calculate the sub total.
            subTotal = subTotal + value

            ' Set the subTotal text value.
            txt_Sub.Text = subTotal.ToString()

            ' Get the tax Percentage.
            Dim taxPercentage As Integer = calculateTax()

            ' Calculate the tax price.
            Dim taxPrice As Double = Convert.ToDouble(
                (taxPercentage * subTotal) / 100)

            ' Set the txt_Tax text value.
            txt_Tax.Text = taxPrice.ToString()

            ' Get the Sale Total Price.
            Dim saleTotal As Double = calculateSaleTotal(taxPrice)

            ' Set the Sale Total price to text box.
            Txt_Sale_Total.Text = saleTotal.ToString()
        Else
            ' Display the error message to user.
            MessageBox.Show("Invalid purchase value Enter " +
                    "multiple of 10 (start from 10 to 100)")
        End If
    End Sub

    ' This Function is used to calculate and return the sale total value.
    Public Function calculateSaleTotal(
                               ByVal taxPrice As Double) As Double

        ' Calculate the sale total value.
        Dim saleTotal As Double = taxPrice + subTotal

        ' return the sale total.
        Return saleTotal
    End Function

    ' This method is used to calculate the tax.
    Public Function calculateTax() As Integer

        ' This variable is used to store the tax percentage.
        Dim taxPercentage As Integer = 0

        ' Check if sub total is greater than 0 and less than equal to 50.
        If (subTotal <= 50 And subTotal > 0) Then ' If yes then
            taxPercentage = 10 ' Set the tax percentage to 10.

            ' Check if sub total is greater than 50 and less than equal to 100.
        ElseIf (subTotal > 50 And subTotal <= 100) Then
            taxPercentage = 15 ' Set the tax percentage to 15.
            ' Check if sub total is greater than 100 and less than equal to 200.
        ElseIf (subTotal > 100 And subTotal <= 200) Then
            taxPercentage = 20 ' Set the tax Percentage to 20.
        Else ' If subtotal is greated than 200 than.
            taxPercentage = 25 ' Set the tax percentage to 25
        End If
        Return taxPercentage ' return the tax percentage.
        Return taxPercentage ' return the tax percentage.
        Return taxPercentage ' return the tax percentage.
        Return taxPercentage ' return the tax percentage.
        Return taxPercentage ' return the tax percentage.
    End Function

    ' This method is used to reset the values.
    Private Sub btn_Reset_Click(sender As Object,
                    e As EventArgs) Handles btn_Reset.Click

        ' Clear the List box value.
        Lst_Track.Items.Clear()
        subTotal = 0 ' Set sub total to 0.
        txt_Purchase.Text = "" ' clear the purchase text box.
        Txt_Sale_Total.Text = "" ' Clear the sale total text box.
        txt_Sub.Text = "" ' Clear the sub total text box.
        txt_Tax.Text = "" ' Clear the tax text box value.
    End Sub
End Class
