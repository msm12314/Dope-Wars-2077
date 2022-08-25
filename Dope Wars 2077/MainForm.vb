Imports System.Windows

Public Class MainWin
    '
    ' Game Variables
    '

    Public SpicePriceRand As Integer
    Public TBloodPriceRand As Integer
    Public NeoPsybinPriceRand As Integer
    Public VooDooPriceRand As Integer
    Public GlitterPriceRand As Integer
    Public CyberStimPriceRand As Integer
    Public SloMoPriceRand As Integer
    Public SynthenylPriceRand As Integer

    Public DrugPriceRandom(7) As Integer
    Public DrugPriceRandom2(7) As Integer
    Public DrugPriceRandom3(7) As Integer
    Public DrugPriceRandom4(7) As Integer
    Public DrugPriceRandom5(7) As Integer

    Public Enum DrugNameID As UShort
        Spice
        TigerBlood
        NeoPsybin
        Glitter
        VooDoo
        SloMo
        CyberStim
        Synthenyl
    End Enum

    Public Enum GameCities As UShort
        Watson
        Heywood
        CityCenter
        SantoDom
        Westbrook
        Pacifica
        Badlands
        Docks
    End Enum

    Public PlayerCash As Long
    Public PlayerDebt As Long
    Public PlayerBank As Long
    Public PlayerDebtPlusInterest As Long
    Public PlayerLife As Integer
    Public PlayerDay As Integer
    Public PlayerLocation As GameCities
    Public PlayerBackpackSlotNames(8) As String
    Public PlayerBackpackSlotTotal(8) As Integer
    Public PlayerBackpackSlotPrice(8) As Integer
    Public PlayerBackpackTotal As Integer

    Public DrugPricesToday(8) As Integer
    Public DrugPricesPrev(8) As Integer
    Public DrugPricesPrev2(8) As Integer
    Public DrugPricesPrev3(8) As Integer
    Public DrugPricesBuyCost(8) As Integer

    Public GameMaxDay As Integer = 30

    Public Sub InitNewGame()
        SendEventText("> *************************")
        SendEventText("> You nearly got smoked on that last job.")
        SendEventText("> Thankfully, Ripper Doc patched you up. Bad news is you owe him.")
        SendEventText("> Better go sell some drugs Choom, and get out of debt!")
        SendEventText("> *************************")

        PlayerDay = 1
        PlayerCash = 2000
        PlayerBank = 0
        PlayerDebt = 4000
        PlayerDebtPlusInterest = PlayerDebt
        DebtCalc() ' adds interest on day 1

        PlayerLife = 100
        LifeBar1.Value = PlayerLife

        BackpackBar.Value = PlayerBackpackTotal

        PlayerLocation = GameCities.Watson
        PlayerCityCur.Text = "Watson"

        GeneratePricing()

        TotalCashLabel.Text = PlayerCash.ToString
        TotalBankLabel.Text = PlayerBank.ToString
        TotalDebtLabel.Text = PlayerDebtPlusInterest.ToString
        CurrentDay.Text = PlayerDay.ToString

        BackpackSlotListbox.Items.Clear()
        BackpackDrugPriceTotals.Items.Clear()

        UpdateGame()

    End Sub

    ' -------------------------------------------------
    ' Sends Text to the Console
    ' -------------------------------------------------

    Public Sub SendEventText(sender As String)
        EventConsole.AppendText(sender & vbCrLf)
    End Sub

    ' -------------------------------
    ' Generates Pricing for Drugs
    ' -------------------------------
    Public Sub GeneratePricing()
        Randomize()

        DrugPriceRandom(0) = Int((90 * Rnd()) + 5)
        DrugPriceRandom(1) = Int((250 * Rnd()) + 25)
        DrugPriceRandom(2) = Int((450 * Rnd()) + 50)
        DrugPriceRandom(3) = Int((1050 * Rnd()) + 125)
        DrugPriceRandom(4) = Int((2250 * Rnd()) + 250)
        DrugPriceRandom(5) = Int((4950 * Rnd()) + 500)
        DrugPriceRandom(6) = Int((6500 * Rnd()) + 1000)
        DrugPriceRandom(7) = Int((10000 * Rnd()) + 2000)

        DrugPriceRandom2(0) = Int((90 * Rnd()) + 5)
        DrugPriceRandom2(1) = Int((250 * Rnd()) + 25)
        DrugPriceRandom2(2) = Int((450 * Rnd()) + 50)
        DrugPriceRandom2(3) = Int((1050 * Rnd()) + 125)
        DrugPriceRandom2(4) = Int((2250 * Rnd()) + 250)
        DrugPriceRandom2(5) = Int((5500 * Rnd()) + 500)
        DrugPriceRandom2(6) = Int((7000 * Rnd()) + 1100)
        DrugPriceRandom2(7) = Int((9000 * Rnd()) + 1800)

        DrugPriceRandom3(0) = Int((80 * Rnd()) + 1)
        DrugPriceRandom3(1) = Int((150 * Rnd()) + 20)
        DrugPriceRandom3(2) = Int((550 * Rnd()) + 40)
        DrugPriceRandom3(3) = Int((1200 * Rnd()) + 100)
        DrugPriceRandom3(4) = Int((2000 * Rnd()) + 180)
        DrugPriceRandom3(5) = Int((4500 * Rnd()) + 500)
        DrugPriceRandom3(6) = Int((6600 * Rnd()) + 1200)
        DrugPriceRandom3(7) = Int((11000 * Rnd()) + 1800)

        For i As Integer = 0 To 7 Step 1
            DrugPriceRandom4(i) = (DrugPriceRandom(i) + DrugPriceRandom2(i) + DrugPriceRandom3(i)) / 3
        Next

        DrugPriceListBox.Items.Clear()
        For j As Integer = 0 To 7 Step 1
            DrugPricesPrev(j) = DrugPricesToday(j)
            DrugPricesToday(j) = DrugPriceRandom4(j)
            DrugPriceListBox.Items.Insert(j, DrugPricesToday(j).ToString)
        Next

        CheckPriceDiffToday()

        SendEventText("> Drug Prices updated.")
    End Sub

    Public Sub GeneratePriceDrop(number As Integer)
        DrugPricesToday(number) *= 0.5

        DrugPriceListBox.Items.Clear()
        For i As Integer = 0 To 7 Step 1
            DrugPriceListBox.Items.Insert(i, DrugPricesToday(i).ToString)
        Next
        CheckPriceDiffToday()
        Select Case number
            Case 0
                SendEventText("> The price of Spice has dropped!")
                Exit Select
            Case 1
                SendEventText("> The Price of Tiger's Blood has dropped!")
                Exit Select
            Case 2
                SendEventText("> The price of Neo-Psybin has dropped!")
                Exit Select
            Case 3
                SendEventText("> The price of VooDoo has dropped!")
                Exit Select
            Case 4
                SendEventText("> The price of Glitter has dropped!")
                Exit Select
            Case 5
                SendEventText("> The price of Cyber-Stim's has dropped!")
                Exit Select
            Case 6
                SendEventText("> The price of Slo-Mo has dropped!")
                Exit Select
            Case 7
                SendEventText("> The price of Synthenyl has dropped!")
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Public Sub GeneratePriceRaise(number As Integer)
        DrugPricesToday(number) *= 1.9

        DrugPriceListBox.Items.Clear()
        For i As Integer = 0 To 7 Step 1
            DrugPriceListBox.Items.Insert(i, DrugPricesToday(i).ToString)
        Next
        CheckPriceDiffToday()
        Select Case number
            Case 0
                SendEventText("> The price of Spice has increased!")
                Exit Select
            Case 1
                SendEventText("> The Price of Tiger's Blood has increased!")
                Exit Select
            Case 2
                SendEventText("> The price of Neo-Psybin has increased!")
                Exit Select
            Case 3
                SendEventText("> The price of VooDoo has increased!")
                Exit Select
            Case 4
                SendEventText("> The price of Glitter has increased!")
                Exit Select
            Case 5
                SendEventText("> The price of Cyber-Stim's has increased!")
                Exit Select
            Case 6
                SendEventText("> The price of Slo-Mo has increased!")
                Exit Select
            Case 7
                SendEventText("> The price of Synthenyl has increased!")
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Public Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("C:\dwaudio.wav",
        AudioPlayMode.BackgroundLoop)
    End Sub

    ' ---------------------------
    ' Window Load
    ' ---------------------------

    Private Sub MainWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitNewGame()
        'PlayLoopingBackgroundSoundFile()
    End Sub

    Public Function CheckForEndGame()
        If PlayerDay >= GameMaxDay Then
            ' run end game

            Dim result1 As DialogResult = MessageBox.Show("New Game or Quit?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result1 = False Then
                CloseGame()
                Return 0
            End If
            InitNewGame()
            Return 1
        End If
        Return 0
    End Function

    ' ----------------------------
    ' Today's Price Button
    ' ------------------
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim TextBuffer As String = PriceGroup.Text

        PriceGroup.Text = "Today's Prices"
        DrugPriceListBox.Items.Clear()

        For j As Integer = 0 To 7 Step 1
            DrugPriceListBox.Items.Insert(j, DrugPricesToday(j).ToString)
        Next
        CheckPriceDiffToday()

    End Sub

    ' -------------------------------------------
    ' Changes Price List to Previous Day's List
    ' -------------------------------------------

    Private Sub Button6_MouseClick(sender As Object, e As MouseEventArgs) Handles Button6.MouseClick

        If PlayerDay = 1 Then
            SendEventText("No previous days prices available yet. Advance one day.")
            Return
        End If

        Dim TextBuffer As String = PriceGroup.Text

        PriceGroup.Text = "Yesterday's Prices"
        DrugPriceListBox.Items.Clear()

        For j As Integer = 0 To 7 Step 1
            DrugPriceListBox.Items.Insert(j, DrugPricesPrev(j).ToString)
        Next
        CheckPriceDiffPrev()

    End Sub

    Public Sub CheckPriceDiffPrev()

        DrugPriceDiff.Items.Clear()
        For k As Integer = 0 To 7 Step 1
            If DrugPricesPrev(k) < DrugPricesToday(k) Then
                DrugPriceDiff.Items.Insert(k, "↓")
            End If
            If DrugPricesPrev(k) > DrugPricesToday(k) Then
                DrugPriceDiff.Items.Insert(k, "↑")
            End If
            If DrugPricesPrev(k) = DrugPricesToday(k) Then
                DrugPriceDiff.Items.Insert(k, "=")
            End If
        Next
    End Sub

    Public Sub CheckPriceDiffToday()

        DrugPriceDiff.Items.Clear()
        For k As Integer = 0 To 7 Step 1
            If DrugPricesToday(k) < DrugPricesPrev(k) Then
                DrugPriceDiff.Items.Insert(k, "↓")
            End If
            If DrugPricesToday(k) > DrugPricesPrev(k) Then
                DrugPriceDiff.Items.Insert(k, "↑")
            End If
            If DrugPricesToday(k) = DrugPricesPrev(k) Then
                DrugPriceDiff.Items.Insert(k, "=")
            End If
        Next
    End Sub

    ' ----------------
    ' Menu Item New Game
    '-----------------
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        InitNewGame()
    End Sub

    ' --------------------------
    ' Closes Game
    ' Menu Exit
    ' --------------------------
    Private Sub CloseGame()
        MainWin.ActiveForm.Close()
    End Sub

    Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitGameToolStripMenuItem.Click
        CloseGame()
    End Sub

    ' ---------------------------
    ' About Menu
    ' ---------------------------
    Private Sub AboutThisGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisGameToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    ' ----------------------------------------
    ' Get Listbox index for selection
    ' --------------------------------------
    Public Function GetSelectionResult()
        Return DrugNameListbox.SelectedIndex
    End Function

    ' ---------------------------------------
    ' Get backpack Listbox index for selection
    ' ---------------------------------------
    Public Function GetSelectionResult2()
        Return BackpackDrugListbox.SelectedIndex
    End Function

    ' -------------------------------------------
    ' update game
    ' -------------------------------------------
    Public Sub UpdateGame()
        Randomize()
        Dim SlotTotal As Integer
        BackpackSlotListbox.Items.Clear()
        BackpackDrugPriceTotals.Items.Clear()
        For l As Integer = 0 To 7 Step 1
            BackpackSlotListbox.Items.Insert(l, PlayerBackpackSlotTotal(l).ToString)
            BackpackDrugPriceTotals.Items.Insert(l, PlayerBackpackSlotPrice(l).ToString)

            SlotTotal += PlayerBackpackSlotTotal(l)
        Next

        TotalCashLabel.Text = PlayerCash.ToString
        TotalBankLabel.Text = PlayerBank.ToString
        TotalDebtLabel.Text = PlayerDebtPlusInterest.ToString
        CurrentDay.Text = PlayerDay.ToString
        BackpackBar.Value = SlotTotal
    End Sub

    ' -------------------------
    ' Debt Interest Calculation
    ' -------------------------
    Public Sub DebtCalc()
        PlayerDebtPlusInterest += PlayerDebt * 0.07
    End Sub

    ' ---------------------------------------------
    ' Buy
    ' ---------------------------------------------

    Private Sub Button8_MouseClick(sender As Object, e As MouseEventArgs) Handles Button8.MouseClick
        Dim DrugSelected = GetSelectionResult()

        If DrugSelected < 0 Or DrugSelected > 7 Then
            SendEventText("No Drug Selected from Drug List. Try again.")
            Return
        End If

        Dim SelectionPrice As Long
        Dim Message, Title, MyValue
        Message = "Enter how many?"
        Title = "Amount"
        MyValue = InputBox(Message, Title)

        SelectionPrice = DrugPricesToday(DrugSelected) * MyValue

        If MyValue + PlayerBackpackTotal > 100 Then
            SendEventText("Not enough space in your Backpack! Sell some drugs.")
            Return
        End If

        If PlayerCash < SelectionPrice Then
            SendEventText("Not enough Cash to purchase!")
            Return
        End If

        Dim MyValue2 As DialogResult = MessageBox.Show("It will cost " & SelectionPrice.ToString & " are you sure?", "Purchase", MessageBoxButtons.YesNo)

        If MyValue2 Then
            PlayerCash -= SelectionPrice
            PlayerBackpackSlotPrice(DrugSelected) = PlayerBackpackSlotPrice(DrugSelected) + SelectionPrice
            PlayerBackpackSlotTotal(DrugSelected) = PlayerBackpackSlotTotal(DrugSelected) + MyValue
        End If

        UpdateGame()
    End Sub

    ' ----------------------------------------
    ' Sell
    ' -----------------------------------------
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim DrugSelected = GetSelectionResult2()

        If DrugSelected < 0 Or DrugSelected > 7 Then
            SendEventText("No Drug Selected from Backpack Drug List. Try again.")
            Return
        End If

        Dim SelectionPrice As Long
        Dim Message, Title, MyValue
        Message = "Enter how many?"
        Title = "Amount"
        MyValue = InputBox(Message, Title)

        If PlayerBackpackSlotTotal(DrugSelected) - MyValue < 0 Then
            SendEventText("Can't sell more than you have! Try again.")
            Return
        End If

        SelectionPrice = DrugPricesToday(DrugSelected) * MyValue

        Dim MyValue2 As DialogResult = MessageBox.Show("You will gain $" & SelectionPrice.ToString & " are you sure?", "Sell", MessageBoxButtons.YesNo)

        If MyValue2 Then
            PlayerCash += SelectionPrice
            PlayerBackpackSlotPrice(DrugSelected) = PlayerBackpackSlotPrice(DrugSelected) - SelectionPrice
            PlayerBackpackSlotTotal(DrugSelected) = PlayerBackpackSlotTotal(DrugSelected) - MyValue

            If PlayerBackpackSlotPrice(DrugSelected) < 0 Then
                PlayerBackpackSlotPrice(DrugSelected) = 0
            End If
        End If

        UpdateGame()
    End Sub

    ' --------------------
    ' Bank Deposit
    ' --------------------
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MessageText, Title
        Dim MyValue As String
        MessageText = "How much cash to deposit?"
        Title = "Bank Deposit"
        MyValue = InputBox(MessageText, Title)
        If MyValue = "" Then
            Exit Sub
        End If
        If PlayerCash < Int(MyValue) Then
            SendEventText("> Not enough cash on hand. Enter exact amount.")
            Exit Sub
        End If
        If PlayerCash >= Int(MyValue) Then
            PlayerBank += Int(MyValue)
            PlayerCash -= Int(MyValue)
            UpdateGame()
        End If
    End Sub

    ' ------------------------
    ' ATM - Withdraw from Bank
    ' --------------------------

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        Dim MessageText, Title
        Dim MyValue As String
        MessageText = "How much cash to withdraw?"
        Title = "ATM Withdraw"
        MyValue = InputBox(MessageText, Title)
        If MyValue = "" Then
            Exit Sub
        End If
        If PlayerBank < Int(MyValue) Then
            SendEventText("> Not enough cash in the bank. Enter exact amount.")
            Exit Sub
        End If
        If PlayerBank >= Int(MyValue) Then
            PlayerCash += Int(MyValue)
            PlayerBank -= Int(MyValue)
            UpdateGame()
        End If
    End Sub
    ' --------------------------
    ' Pay Debt
    ' --------------------------

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MessageText, Title
        Dim MyValue As String

        MessageText = "How much cash to pay on debt??"
        Title = "Loan Shark"
        MyValue = InputBox(MessageText, Title)

        If MyValue = "" Then
            Exit Sub
        End If

        If PlayerCash < Int(MyValue) Then
            SendEventText("> Not enough cash. Enter exact amount.")
            Exit Sub
        End If

        If PlayerCash >= Int(MyValue) Then
            PlayerCash -= Int(MyValue)
            PlayerDebt -= Int(MyValue)
            UpdateGame()
        End If
    End Sub

    ' ---------------------------
    ' Travel to Watson
    ' --------------------------
    Private Sub Button11_MouseClick(sender As Object, e As MouseEventArgs) Handles Button11.MouseClick
        Dim var As Integer
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Watson Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Watson
        PlayerCityCur.Text = "Watson"

        GeneratePricing()
        Randomize()
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.TigerBlood)
                Exit Select
            Case 1 To 3
                GeneratePriceRaise(DrugNameID.TigerBlood)
                Exit Select
            Case Else
                Exit Select
        End Select

        DebtCalc()
        SendEventText("> Traveled to Watson.")
        UpdateGame()

    End Sub

    ' -------------------
    ' Travel to Heywood 
    ' -------------------

    Private Sub Button12_MouseClick(sender As Object, e As MouseEventArgs) Handles Button12.MouseClick
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Heywood Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Heywood
        PlayerCityCur.Text = "Heywood"

        GeneratePricing()
        Randomize()
        Dim var As Integer
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.Glitter)
                Exit Select
            Case 1 To 3
                GeneratePriceRaise(DrugNameID.Glitter)
                Exit Select
            Case Else
                Exit Select
        End Select
        DebtCalc()
        SendEventText("> Traveled to Heywood")
        UpdateGame()

    End Sub

    ' -------------------------
    ' Travel to City Center 
    ' -------------------------

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.CityCenter Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.CityCenter
        PlayerCityCur.Text = "City Center"

        GeneratePricing()
        Randomize()
        Dim var As Integer
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.Synthenyl)
                Exit Select
            Case 1 To 3
                GeneratePriceRaise(DrugNameID.Synthenyl)
                Exit Select
            Case Else
                Exit Select
        End Select
        DebtCalc()
        SendEventText("> Traveled to City Center")
        UpdateGame()

    End Sub

    ' -------------------------
    ' Travel to Santo Dom
    ' -------------------------
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.SantoDom Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.SantoDom
        PlayerCityCur.Text = "Santo Domingo"

        GeneratePricing()
        Randomize()
        Dim var As Integer
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.Spice)
                Exit Select
            Case 1 To 10
                GeneratePriceRaise(DrugNameID.Spice)
                Exit Select
            Case Else
                Exit Select
        End Select
        DebtCalc()
        SendEventText("> Traveled to Santo Domingo")
        UpdateGame()
    End Sub
    ' -------------------------
    ' Travel to Westbrook
    ' -------------------------
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Westbrook Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Westbrook
        PlayerCityCur.Text = "Westbrook"

        GeneratePricing()
        Randomize()
        Dim var As Integer
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.CyberStim)
                Exit Select
            Case 1 To 10
                GeneratePriceRaise(DrugNameID.CyberStim)
                Exit Select
            Case Else
                Exit Select
        End Select
        DebtCalc()
        SendEventText("> Traveled to Westbrook")
        UpdateGame()
    End Sub
    ' -------------------------
    ' Travel to Pacifica
    ' -------------------------
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim var As Integer
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Pacifica Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Pacifica
        PlayerCityCur.Text = "Pacifica"

        GeneratePricing()
        Randomize()
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.VooDoo)
                Exit Select
            Case 1 To 10
                GeneratePriceRaise(DrugNameID.VooDoo)
                Exit Select
            Case Else
                Exit Select
        End Select

        DebtCalc()
        SendEventText("> Traveled to Pacifica")
        UpdateGame()
    End Sub
    ' -------------------------
    ' Travel to Badlands
    ' -------------------------
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim var As Integer
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Badlands Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Badlands
        PlayerCityCur.Text = "City Center"

        GeneratePricing()
        Randomize()
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.NeoPsybin)
                Exit Select
            Case 1 To 10
                GeneratePriceRaise(DrugNameID.NeoPsybin)
                Exit Select
            Case Else
                Exit Select
        End Select

        DebtCalc()
        SendEventText("> Traveled to Badlands")
        UpdateGame()
    End Sub
    ' -------------------------
    ' Travel to Docks
    ' -------------------------
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim var As Integer
        Dim var2 As Integer
        var2 = CheckForEndGame()
        If var2 = 1 Then
            Exit Sub
        End If
        If PlayerLocation = GameCities.Docks Then
            SendEventText("> Already here, choom.")
            Return
        End If

        PlayerDay += 1
        CurrentDay.Text = PlayerDay.ToString
        PlayerLocation = GameCities.Docks
        PlayerCityCur.Text = "The Docks"

        GeneratePricing()
        var = Int((100 * Rnd()) + 1)
        Select Case var
            Case 91 To 100
                GeneratePriceDrop(DrugNameID.SloMo)
                Exit Select
            Case 1 To 10
                GeneratePriceRaise(DrugNameID.SloMo)
                Exit Select
            Case Else
                Exit Select
        End Select

        DebtCalc()
        SendEventText("> Traveled to the Docks")
        UpdateGame()
    End Sub

    Private Sub HighScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoresToolStripMenuItem.Click
        My.Computer.Audio.Stop()
    End Sub

    Public Sub StoreButton_Click(sender As Object, e As EventArgs) Handles StoreButton.Click
        Dim OBJ As New ShopForm
        OBJ.varCash = PlayerCash
        OBJ.Show()
    End Sub


End Class
