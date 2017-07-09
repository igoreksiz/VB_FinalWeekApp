' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
    
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs) Handles btnCalculate.Click

        Dim decCheckAmount As Decimal
        Dim intPartySize As Integer
        Dim intTipSelection As Integer
        Dim decTip As Decimal
        Dim decSplitAmount As Decimal

        'assign the user input
        decCheckAmount = Convert.ToDecimal(txtCheckTotal.Text)
        intPartySize = Convert.ToInt32(cboPartySize.SelectedIndex) + 2
        intTipSelection = cboTipAmount.SelectedIndex

        'assign the tip
        Select Case intTipSelection
            Case 0
                decTip = 0.1D
            Case 1
                decTip = 0.15D
            Case 2
                decTip = 0.2D
        End Select

        decSplitAmount = (decCheckAmount * (1 + decTip) / intPartySize)

        lblDisplay.Text = "Split amount " & decSplitAmount.ToString("C2") & " per person."
        lblDisplay.Visibility = True

    End Sub
End Class
