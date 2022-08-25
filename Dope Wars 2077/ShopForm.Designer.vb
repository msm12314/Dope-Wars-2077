<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlayerCashLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GunCostLabel = New System.Windows.Forms.Label()
        Me.ShopGrpBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ShopGrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayerCashLabel
        '
        Me.PlayerCashLabel.AutoSize = True
        Me.PlayerCashLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PlayerCashLabel.Location = New System.Drawing.Point(16, 30)
        Me.PlayerCashLabel.Name = "PlayerCashLabel"
        Me.PlayerCashLabel.Size = New System.Drawing.Size(117, 19)
        Me.PlayerCashLabel.TabIndex = 0
        Me.PlayerCashLabel.Text = "$ PlayerCash"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(31, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(57, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GunCostLabel
        '
        Me.GunCostLabel.AutoSize = True
        Me.GunCostLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GunCostLabel.Location = New System.Drawing.Point(26, 110)
        Me.GunCostLabel.Name = "GunCostLabel"
        Me.GunCostLabel.Size = New System.Drawing.Size(99, 19)
        Me.GunCostLabel.TabIndex = 4
        Me.GunCostLabel.Text = "$ Gun Cost"
        '
        'ShopGrpBox
        '
        Me.ShopGrpBox.Controls.Add(Me.ComboBox1)
        Me.ShopGrpBox.Controls.Add(Me.GunCostLabel)
        Me.ShopGrpBox.Controls.Add(Me.Button1)
        Me.ShopGrpBox.Controls.Add(Me.PlayerCashLabel)
        Me.ShopGrpBox.ForeColor = System.Drawing.Color.Lime
        Me.ShopGrpBox.Location = New System.Drawing.Point(26, 12)
        Me.ShopGrpBox.Name = "ShopGrpBox"
        Me.ShopGrpBox.Size = New System.Drawing.Size(166, 205)
        Me.ShopGrpBox.TabIndex = 5
        Me.ShopGrpBox.TabStop = False
        Me.ShopGrpBox.Text = "Gun Shop"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'ShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(215, 285)
        Me.Controls.Add(Me.ShopGrpBox)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ShopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ShopGrpBox.ResumeLayout(False)
        Me.ShopGrpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayerCashLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GunCostLabel As Label
    Friend WithEvents ShopGrpBox As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
