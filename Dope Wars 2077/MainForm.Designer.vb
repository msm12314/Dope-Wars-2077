<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWin))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Withdraw = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TransactionsGroup = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BackpackDrugPriceTotals = New System.Windows.Forms.ListBox()
        Me.BackpackSlotListbox = New System.Windows.Forms.ListBox()
        Me.BackpackDrugListbox = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DrugNameListbox = New System.Windows.Forms.ListBox()
        Me.PriceGroup = New System.Windows.Forms.GroupBox()
        Me.DrugPriceDiff = New System.Windows.Forms.ListBox()
        Me.DrugPriceListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.EventConsole = New System.Windows.Forms.RichTextBox()
        Me.BackpackBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.CurrentDay = New System.Windows.Forms.Label()
        Me.CashLabel = New System.Windows.Forms.Label()
        Me.TotalCashLabel = New System.Windows.Forms.Label()
        Me.BankLabel = New System.Windows.Forms.Label()
        Me.TotalDebtLabel = New System.Windows.Forms.Label()
        Me.TotalBankLabel = New System.Windows.Forms.Label()
        Me.DebtLabel = New System.Windows.Forms.Label()
        Me.PlayerCityCur = New System.Windows.Forms.Label()
        Me.LifeBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackpackLabel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TransactionsGroup.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.PriceGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(3, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 20)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Debt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Withdraw
        '
        Me.Withdraw.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Withdraw.Location = New System.Drawing.Point(3, 131)
        Me.Withdraw.Name = "Withdraw"
        Me.Withdraw.Size = New System.Drawing.Size(60, 20)
        Me.Withdraw.TabIndex = 2
        Me.Withdraw.Text = "ATM"
        Me.Withdraw.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(3, 105)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 20)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Bank"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(3, 53)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 20)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Today $"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(3, 79)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 20)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Prev $"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Location = New System.Drawing.Point(3, 27)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 20)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "<< Sell"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 20)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Buy >>"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StoreButton)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Withdraw)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(295, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 210)
        Me.Panel1.TabIndex = 8
        '
        'TransactionsGroup
        '
        Me.TransactionsGroup.BackColor = System.Drawing.Color.Black
        Me.TransactionsGroup.Controls.Add(Me.GroupBox6)
        Me.TransactionsGroup.Controls.Add(Me.Panel1)
        Me.TransactionsGroup.Controls.Add(Me.GroupBox5)
        Me.TransactionsGroup.Controls.Add(Me.PriceGroup)
        Me.TransactionsGroup.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionsGroup.ForeColor = System.Drawing.Color.Lime
        Me.TransactionsGroup.Location = New System.Drawing.Point(6, 402)
        Me.TransactionsGroup.Name = "TransactionsGroup"
        Me.TransactionsGroup.Size = New System.Drawing.Size(680, 232)
        Me.TransactionsGroup.TabIndex = 10
        Me.TransactionsGroup.TabStop = False
        Me.TransactionsGroup.Text = "Transactions"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BackpackDrugPriceTotals)
        Me.GroupBox6.Controls.Add(Me.BackpackSlotListbox)
        Me.GroupBox6.Controls.Add(Me.BackpackDrugListbox)
        Me.GroupBox6.Font = New System.Drawing.Font("Unispace", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox6.Location = New System.Drawing.Point(367, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(307, 180)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Backpack Inventory"
        '
        'BackpackDrugPriceTotals
        '
        Me.BackpackDrugPriceTotals.BackColor = System.Drawing.Color.Black
        Me.BackpackDrugPriceTotals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BackpackDrugPriceTotals.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackpackDrugPriceTotals.ForeColor = System.Drawing.Color.Lime
        Me.BackpackDrugPriceTotals.FormattingEnabled = True
        Me.BackpackDrugPriceTotals.ItemHeight = 19
        Me.BackpackDrugPriceTotals.Items.AddRange(New Object() {"0", "0", "0", "0", "0", "0", "0", "0"})
        Me.BackpackDrugPriceTotals.Location = New System.Drawing.Point(159, 22)
        Me.BackpackDrugPriceTotals.Name = "BackpackDrugPriceTotals"
        Me.BackpackDrugPriceTotals.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BackpackDrugPriceTotals.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.BackpackDrugPriceTotals.Size = New System.Drawing.Size(142, 152)
        Me.BackpackDrugPriceTotals.TabIndex = 4
        '
        'BackpackSlotListbox
        '
        Me.BackpackSlotListbox.BackColor = System.Drawing.Color.Black
        Me.BackpackSlotListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BackpackSlotListbox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackpackSlotListbox.ForeColor = System.Drawing.Color.Lime
        Me.BackpackSlotListbox.FormattingEnabled = True
        Me.BackpackSlotListbox.ItemHeight = 19
        Me.BackpackSlotListbox.Items.AddRange(New Object() {"0", "0", "0", "0", "0", "0", "0", "0"})
        Me.BackpackSlotListbox.Location = New System.Drawing.Point(120, 21)
        Me.BackpackSlotListbox.Name = "BackpackSlotListbox"
        Me.BackpackSlotListbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BackpackSlotListbox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.BackpackSlotListbox.Size = New System.Drawing.Size(30, 152)
        Me.BackpackSlotListbox.TabIndex = 4
        '
        'BackpackDrugListbox
        '
        Me.BackpackDrugListbox.BackColor = System.Drawing.Color.Black
        Me.BackpackDrugListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BackpackDrugListbox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackpackDrugListbox.ForeColor = System.Drawing.Color.Lime
        Me.BackpackDrugListbox.FormattingEnabled = True
        Me.BackpackDrugListbox.ItemHeight = 19
        Me.BackpackDrugListbox.Items.AddRange(New Object() {"Spice", "Tiger Blood", "Neo-Psybin", "Voodoo", "Glitter", "Cyber Stim", "Slo-Mo", "Synthenyl"})
        Me.BackpackDrugListbox.Location = New System.Drawing.Point(6, 21)
        Me.BackpackDrugListbox.Name = "BackpackDrugListbox"
        Me.BackpackDrugListbox.Size = New System.Drawing.Size(108, 152)
        Me.BackpackDrugListbox.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DrugNameListbox)
        Me.GroupBox5.Font = New System.Drawing.Font("Unispace", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox5.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(116, 180)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Drug List"
        '
        'DrugNameListbox
        '
        Me.DrugNameListbox.BackColor = System.Drawing.Color.Black
        Me.DrugNameListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrugNameListbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DrugNameListbox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DrugNameListbox.ForeColor = System.Drawing.Color.Lime
        Me.DrugNameListbox.FormattingEnabled = True
        Me.DrugNameListbox.ItemHeight = 19
        Me.DrugNameListbox.Items.AddRange(New Object() {"Spice", "Tiger Blood", "Neo-Psybin", "Voodoo", "Glitter", "Cyber Stim", "Slo-Mo", "Synthenyl"})
        Me.DrugNameListbox.Location = New System.Drawing.Point(6, 22)
        Me.DrugNameListbox.Name = "DrugNameListbox"
        Me.DrugNameListbox.Size = New System.Drawing.Size(108, 152)
        Me.DrugNameListbox.TabIndex = 1
        '
        'PriceGroup
        '
        Me.PriceGroup.Controls.Add(Me.DrugPriceDiff)
        Me.PriceGroup.Controls.Add(Me.DrugPriceListBox)
        Me.PriceGroup.Font = New System.Drawing.Font("Unispace", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.PriceGroup.ForeColor = System.Drawing.Color.Lime
        Me.PriceGroup.Location = New System.Drawing.Point(128, 22)
        Me.PriceGroup.Name = "PriceGroup"
        Me.PriceGroup.Size = New System.Drawing.Size(161, 180)
        Me.PriceGroup.TabIndex = 3
        Me.PriceGroup.TabStop = False
        Me.PriceGroup.Text = "Today's Prices"
        '
        'DrugPriceDiff
        '
        Me.DrugPriceDiff.BackColor = System.Drawing.Color.Black
        Me.DrugPriceDiff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrugPriceDiff.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DrugPriceDiff.ForeColor = System.Drawing.Color.Lime
        Me.DrugPriceDiff.FormattingEnabled = True
        Me.DrugPriceDiff.ItemHeight = 19
        Me.DrugPriceDiff.Items.AddRange(New Object() {"<>", "<>", "<>", "<>", "<>", "<>", "<>", "<>"})
        Me.DrugPriceDiff.Location = New System.Drawing.Point(131, 22)
        Me.DrugPriceDiff.Name = "DrugPriceDiff"
        Me.DrugPriceDiff.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.DrugPriceDiff.Size = New System.Drawing.Size(24, 152)
        Me.DrugPriceDiff.TabIndex = 3
        '
        'DrugPriceListBox
        '
        Me.DrugPriceListBox.BackColor = System.Drawing.Color.Black
        Me.DrugPriceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrugPriceListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DrugPriceListBox.ForeColor = System.Drawing.Color.Lime
        Me.DrugPriceListBox.FormattingEnabled = True
        Me.DrugPriceListBox.ItemHeight = 19
        Me.DrugPriceListBox.Items.AddRange(New Object() {"0", "0", "0", "0", "0", "0", "0", "0"})
        Me.DrugPriceListBox.Location = New System.Drawing.Point(6, 22)
        Me.DrugPriceListBox.Name = "DrugPriceListBox"
        Me.DrugPriceListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DrugPriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.DrugPriceListBox.Size = New System.Drawing.Size(112, 152)
        Me.DrugPriceListBox.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.Button18)
        Me.GroupBox2.Controls.Add(Me.Button17)
        Me.GroupBox2.Controls.Add(Me.Button16)
        Me.GroupBox2.Controls.Add(Me.Button15)
        Me.GroupBox2.Controls.Add(Me.Button14)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(469, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 207)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Locations"
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Location = New System.Drawing.Point(111, 157)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(100, 40)
        Me.Button18.TabIndex = 7
        Me.Button18.Text = "Docks"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Location = New System.Drawing.Point(6, 157)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(100, 40)
        Me.Button17.TabIndex = 6
        Me.Button17.Text = "Badlands"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(112, 111)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(100, 40)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = "Pacifica"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(6, 111)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(100, 40)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Westbrook"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(111, 65)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(100, 40)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "Santo Dom."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(6, 65)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(100, 40)
        Me.Button13.TabIndex = 2
        Me.Button13.Text = "City Center"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(111, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 40)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "Heywood"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button11.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(6, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 40)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "Watson"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'EventConsole
        '
        Me.EventConsole.BackColor = System.Drawing.Color.Black
        Me.EventConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EventConsole.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EventConsole.ForeColor = System.Drawing.Color.Lime
        Me.EventConsole.HideSelection = False
        Me.EventConsole.Location = New System.Drawing.Point(6, 22)
        Me.EventConsole.Name = "EventConsole"
        Me.EventConsole.ReadOnly = True
        Me.EventConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.EventConsole.Size = New System.Drawing.Size(668, 128)
        Me.EventConsole.TabIndex = 12
        Me.EventConsole.Text = ""
        '
        'BackpackBar
        '
        Me.BackpackBar.BackColor = System.Drawing.Color.Black
        Me.BackpackBar.Location = New System.Drawing.Point(107, 173)
        Me.BackpackBar.Name = "BackpackBar"
        Me.BackpackBar.Size = New System.Drawing.Size(344, 24)
        Me.BackpackBar.Step = 1
        Me.BackpackBar.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.PlayerCityCur)
        Me.GroupBox3.Controls.Add(Me.LifeBar1)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.BackpackLabel)
        Me.GroupBox3.Controls.Add(Me.BackpackBar)
        Me.GroupBox3.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 207)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.DayLabel)
        Me.GroupBox1.Controls.Add(Me.CurrentDay)
        Me.GroupBox1.Controls.Add(Me.CashLabel)
        Me.GroupBox1.Controls.Add(Me.TotalCashLabel)
        Me.GroupBox1.Controls.Add(Me.BankLabel)
        Me.GroupBox1.Controls.Add(Me.TotalDebtLabel)
        Me.GroupBox1.Controls.Add(Me.TotalBankLabel)
        Me.GroupBox1.Controls.Add(Me.DebtLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(134, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 152)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Finances"
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DayLabel.ForeColor = System.Drawing.Color.Lime
        Me.DayLabel.Location = New System.Drawing.Point(6, 28)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(77, 25)
        Me.DayLabel.TabIndex = 16
        Me.DayLabel.Text = "Day :"
        '
        'CurrentDay
        '
        Me.CurrentDay.AutoSize = True
        Me.CurrentDay.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CurrentDay.ForeColor = System.Drawing.Color.Lime
        Me.CurrentDay.Location = New System.Drawing.Point(113, 28)
        Me.CurrentDay.Name = "CurrentDay"
        Me.CurrentDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CurrentDay.Size = New System.Drawing.Size(25, 25)
        Me.CurrentDay.TabIndex = 17
        Me.CurrentDay.Text = "0"
        '
        'CashLabel
        '
        Me.CashLabel.AutoSize = True
        Me.CashLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CashLabel.Location = New System.Drawing.Point(6, 52)
        Me.CashLabel.Name = "CashLabel"
        Me.CashLabel.Size = New System.Drawing.Size(103, 25)
        Me.CashLabel.TabIndex = 18
        Me.CashLabel.Text = "Cash: $"
        '
        'TotalCashLabel
        '
        Me.TotalCashLabel.AutoSize = True
        Me.TotalCashLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalCashLabel.Location = New System.Drawing.Point(113, 52)
        Me.TotalCashLabel.Name = "TotalCashLabel"
        Me.TotalCashLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TotalCashLabel.Size = New System.Drawing.Size(25, 25)
        Me.TotalCashLabel.TabIndex = 19
        Me.TotalCashLabel.Text = "0"
        Me.TotalCashLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'BankLabel
        '
        Me.BankLabel.AutoSize = True
        Me.BankLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BankLabel.Location = New System.Drawing.Point(6, 76)
        Me.BankLabel.Name = "BankLabel"
        Me.BankLabel.Size = New System.Drawing.Size(103, 25)
        Me.BankLabel.TabIndex = 20
        Me.BankLabel.Text = "Bank: $"
        '
        'TotalDebtLabel
        '
        Me.TotalDebtLabel.AutoSize = True
        Me.TotalDebtLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalDebtLabel.Location = New System.Drawing.Point(113, 100)
        Me.TotalDebtLabel.Name = "TotalDebtLabel"
        Me.TotalDebtLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TotalDebtLabel.Size = New System.Drawing.Size(25, 25)
        Me.TotalDebtLabel.TabIndex = 23
        Me.TotalDebtLabel.Text = "0"
        Me.TotalDebtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TotalBankLabel
        '
        Me.TotalBankLabel.AutoSize = True
        Me.TotalBankLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalBankLabel.Location = New System.Drawing.Point(113, 76)
        Me.TotalBankLabel.Name = "TotalBankLabel"
        Me.TotalBankLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TotalBankLabel.Size = New System.Drawing.Size(25, 25)
        Me.TotalBankLabel.TabIndex = 21
        Me.TotalBankLabel.Text = "0"
        Me.TotalBankLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DebtLabel
        '
        Me.DebtLabel.AutoSize = True
        Me.DebtLabel.Font = New System.Drawing.Font("Unispace", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DebtLabel.Location = New System.Drawing.Point(6, 100)
        Me.DebtLabel.Name = "DebtLabel"
        Me.DebtLabel.Size = New System.Drawing.Size(103, 25)
        Me.DebtLabel.TabIndex = 22
        Me.DebtLabel.Text = "Debt: $"
        '
        'PlayerCityCur
        '
        Me.PlayerCityCur.AutoSize = True
        Me.PlayerCityCur.Font = New System.Drawing.Font("Unispace", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayerCityCur.Location = New System.Drawing.Point(12, 145)
        Me.PlayerCityCur.Name = "PlayerCityCur"
        Me.PlayerCityCur.Size = New System.Drawing.Size(35, 14)
        Me.PlayerCityCur.TabIndex = 28
        Me.PlayerCityCur.Text = "City"
        '
        'LifeBar1
        '
        Me.LifeBar1.Location = New System.Drawing.Point(12, 124)
        Me.LifeBar1.Name = "LifeBar1"
        Me.LifeBar1.Size = New System.Drawing.Size(108, 18)
        Me.LifeBar1.Step = 1
        Me.LifeBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LifeBar1.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 96)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BackpackLabel
        '
        Me.BackpackLabel.AutoSize = True
        Me.BackpackLabel.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackpackLabel.Location = New System.Drawing.Point(6, 173)
        Me.BackpackLabel.Name = "BackpackLabel"
        Me.BackpackLabel.Size = New System.Drawing.Size(99, 19)
        Me.BackpackLabel.TabIndex = 25
        Me.BackpackLabel.Text = "Backpack:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EventConsole)
        Me.GroupBox4.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox4.Location = New System.Drawing.Point(6, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 156)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Event Console"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StopAudioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "F&ile"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitGameToolStripMenuItem.Text = "Exit Game"
        '
        'StopAudioToolStripMenuItem
        '
        Me.StopAudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighScoresToolStripMenuItem, Me.AboutThisGameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.StopAudioToolStripMenuItem.Name = "StopAudioToolStripMenuItem"
        Me.StopAudioToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.StopAudioToolStripMenuItem.Text = "Misc"
        '
        'HighScoresToolStripMenuItem
        '
        Me.HighScoresToolStripMenuItem.Name = "HighScoresToolStripMenuItem"
        Me.HighScoresToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.HighScoresToolStripMenuItem.Text = "Stop Audio"
        '
        'AboutThisGameToolStripMenuItem
        '
        Me.AboutThisGameToolStripMenuItem.Name = "AboutThisGameToolStripMenuItem"
        Me.AboutThisGameToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AboutThisGameToolStripMenuItem.Text = "About this Game"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StoreButton
        '
        Me.StoreButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StoreButton.Location = New System.Drawing.Point(3, 183)
        Me.StoreButton.Name = "StoreButton"
        Me.StoreButton.Size = New System.Drawing.Size(60, 20)
        Me.StoreButton.TabIndex = 8
        Me.StoreButton.Text = "Shop"
        Me.StoreButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.StoreButton.UseVisualStyleBackColor = True
        '
        'MainWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(693, 638)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TransactionsGroup)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.Name = "MainWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dope Wars 2077"
        Me.Panel1.ResumeLayout(False)
        Me.TransactionsGroup.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.PriceGroup.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Withdraw As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TransactionsGroup As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EventConsole As RichTextBox
    Friend WithEvents BackpackBar As ProgressBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DayLabel As Label
    Friend WithEvents CurrentDay As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TotalCashLabel As Label
    Friend WithEvents CashLabel As Label
    Friend WithEvents BankLabel As Label
    Friend WithEvents TotalBankLabel As Label
    Friend WithEvents TotalDebtLabel As Label
    Friend WithEvents DebtLabel As Label
    Friend WithEvents BackpackLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopAudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighScoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrugNameListbox As ListBox
    Friend WithEvents PriceGroup As GroupBox
    Friend WithEvents DrugPriceDiff As ListBox
    Friend WithEvents DrugPriceListBox As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BackpackDrugPriceTotals As ListBox
    Friend WithEvents BackpackSlotListbox As ListBox
    Friend WithEvents BackpackDrugListbox As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LifeBar1 As ProgressBar
    Friend WithEvents PlayerCityCur As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StoreButton As Button
End Class
