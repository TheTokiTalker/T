<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblMembershipType = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.LblEveningCalls = New System.Windows.Forms.Label()
        Me.lblCallLength = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkEveningCalls = New System.Windows.Forms.CheckBox()
        Me.rdoNoPlan = New System.Windows.Forms.RadioButton()
        Me.rdoBronze = New System.Windows.Forms.RadioButton()
        Me.rdoSilver = New System.Windows.Forms.RadioButton()
        Me.rdoGold = New System.Windows.Forms.RadioButton()
        Me.CmbCountry = New System.Windows.Forms.ComboBox()
        Me.TxtCallLength = New System.Windows.Forms.TextBox()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAmountPayable = New System.Windows.Forms.TextBox()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblAmountPayable = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblMembershipType
        '
        Me.lblMembershipType.AutoSize = True
        Me.lblMembershipType.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipType.Location = New System.Drawing.Point(22, 236)
        Me.lblMembershipType.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMembershipType.Name = "lblMembershipType"
        Me.lblMembershipType.Size = New System.Drawing.Size(271, 34)
        Me.lblMembershipType.TabIndex = 3
        Me.lblMembershipType.Text = "Membership Type"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(23, 151)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(115, 29)
        Me.lblCountry.TabIndex = 5
        Me.lblCountry.Text = "Country"
        '
        'LblEveningCalls
        '
        Me.LblEveningCalls.AutoSize = True
        Me.LblEveningCalls.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEveningCalls.Location = New System.Drawing.Point(141, 419)
        Me.LblEveningCalls.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblEveningCalls.Name = "LblEveningCalls"
        Me.LblEveningCalls.Size = New System.Drawing.Size(208, 34)
        Me.LblEveningCalls.TabIndex = 4
        Me.LblEveningCalls.Text = "Evening Calls"
        '
        'lblCallLength
        '
        Me.lblCallLength.AutoSize = True
        Me.lblCallLength.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallLength.Location = New System.Drawing.Point(23, 55)
        Me.lblCallLength.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCallLength.Name = "lblCallLength"
        Me.lblCallLength.Size = New System.Drawing.Size(156, 29)
        Me.lblCallLength.TabIndex = 2
        Me.lblCallLength.Text = "Call Length"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(58, 125)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(208, 29)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Your Full Name"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(528, 29)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(729, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "International Call Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkEveningCalls)
        Me.GroupBox1.Controls.Add(Me.rdoNoPlan)
        Me.GroupBox1.Controls.Add(Me.rdoBronze)
        Me.GroupBox1.Controls.Add(Me.rdoSilver)
        Me.GroupBox1.Controls.Add(Me.rdoGold)
        Me.GroupBox1.Controls.Add(Me.CmbCountry)
        Me.GroupBox1.Controls.Add(Me.TxtCallLength)
        Me.GroupBox1.Controls.Add(Me.lblCallLength)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Controls.Add(Me.LblEveningCalls)
        Me.GroupBox1.Controls.Add(Me.lblMembershipType)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 178)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 541)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'ChkEveningCalls
        '
        Me.ChkEveningCalls.AutoSize = True
        Me.ChkEveningCalls.Location = New System.Drawing.Point(54, 424)
        Me.ChkEveningCalls.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkEveningCalls.Name = "ChkEveningCalls"
        Me.ChkEveningCalls.Size = New System.Drawing.Size(28, 27)
        Me.ChkEveningCalls.TabIndex = 12
        Me.ChkEveningCalls.UseVisualStyleBackColor = True
        '
        'rdoNoPlan
        '
        Me.rdoNoPlan.AutoSize = True
        Me.rdoNoPlan.Location = New System.Drawing.Point(578, 318)
        Me.rdoNoPlan.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNoPlan.Name = "rdoNoPlan"
        Me.rdoNoPlan.Size = New System.Drawing.Size(125, 39)
        Me.rdoNoPlan.TabIndex = 11
        Me.rdoNoPlan.TabStop = True
        Me.rdoNoPlan.Text = "None"
        Me.rdoNoPlan.UseVisualStyleBackColor = True
        '
        'rdoBronze
        '
        Me.rdoBronze.AutoSize = True
        Me.rdoBronze.Location = New System.Drawing.Point(391, 318)
        Me.rdoBronze.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBronze.Name = "rdoBronze"
        Me.rdoBronze.Size = New System.Drawing.Size(152, 39)
        Me.rdoBronze.TabIndex = 10
        Me.rdoBronze.TabStop = True
        Me.rdoBronze.Text = "Bronze"
        Me.rdoBronze.UseVisualStyleBackColor = True
        '
        'rdoSilver
        '
        Me.rdoSilver.AutoSize = True
        Me.rdoSilver.Location = New System.Drawing.Point(216, 318)
        Me.rdoSilver.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSilver.Name = "rdoSilver"
        Me.rdoSilver.Size = New System.Drawing.Size(136, 39)
        Me.rdoSilver.TabIndex = 9
        Me.rdoSilver.TabStop = True
        Me.rdoSilver.Text = "Silver"
        Me.rdoSilver.UseVisualStyleBackColor = True
        '
        'rdoGold
        '
        Me.rdoGold.AutoSize = True
        Me.rdoGold.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoGold.Location = New System.Drawing.Point(54, 318)
        Me.rdoGold.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGold.Name = "rdoGold"
        Me.rdoGold.Size = New System.Drawing.Size(95, 30)
        Me.rdoGold.TabIndex = 8
        Me.rdoGold.TabStop = True
        Me.rdoGold.Text = "Gold"
        Me.rdoGold.UseVisualStyleBackColor = True
        '
        'CmbCountry
        '
        Me.CmbCountry.FormattingEnabled = True
        Me.CmbCountry.Location = New System.Drawing.Point(266, 144)
        Me.CmbCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbCountry.Name = "CmbCountry"
        Me.CmbCountry.Size = New System.Drawing.Size(556, 43)
        Me.CmbCountry.TabIndex = 7
        '
        'TxtCallLength
        '
        Me.TxtCallLength.Location = New System.Drawing.Point(266, 55)
        Me.TxtCallLength.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCallLength.Name = "TxtCallLength"
        Me.TxtCallLength.Size = New System.Drawing.Size(285, 43)
        Me.TxtCallLength.TabIndex = 6
        '
        'TxtFullName
        '
        Me.TxtFullName.Location = New System.Drawing.Point(364, 125)
        Me.TxtFullName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(600, 43)
        Me.TxtFullName.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(615, 750)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(462, 105)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(65, 750)
        Me.BtnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(465, 105)
        Me.BtnCalculate.TabIndex = 10
        Me.BtnCalculate.Text = "Calculate "
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(615, 926)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(462, 110)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(65, 926)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(465, 110)
        Me.BtnReset.TabIndex = 12
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAmountPayable)
        Me.GroupBox2.Controls.Add(Me.txtGST)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.lblAmountPayable)
        Me.GroupBox2.Controls.Add(Me.lblGST)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(1177, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 813)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'txtAmountPayable
        '
        Me.txtAmountPayable.Location = New System.Drawing.Point(30, 572)
        Me.txtAmountPayable.Name = "txtAmountPayable"
        Me.txtAmountPayable.Size = New System.Drawing.Size(312, 43)
        Me.txtAmountPayable.TabIndex = 5
        '
        'txtGST
        '
        Me.txtGST.Location = New System.Drawing.Point(29, 389)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(299, 43)
        Me.txtGST.TabIndex = 4
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(30, 172)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(298, 43)
        Me.txtSubTotal.TabIndex = 3
        '
        'lblAmountPayable
        '
        Me.lblAmountPayable.AutoSize = True
        Me.lblAmountPayable.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPayable.Location = New System.Drawing.Point(23, 501)
        Me.lblAmountPayable.Name = "lblAmountPayable"
        Me.lblAmountPayable.Size = New System.Drawing.Size(291, 40)
        Me.lblAmountPayable.TabIndex = 2
        Me.lblAmountPayable.Text = "Amount Payable"
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.Location = New System.Drawing.Point(22, 318)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(113, 40)
        Me.lblGST.TabIndex = 1
        Me.lblGST.Text = "G.S.T"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(22, 102)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(179, 40)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "Sub Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1632, 1053)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblMembershipType As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents LblEveningCalls As Label
    Friend WithEvents lblCallLength As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbCountry As ComboBox
    Friend WithEvents TxtCallLength As TextBox
    Friend WithEvents TxtFullName As TextBox
    Friend WithEvents rdoGold As RadioButton
    Friend WithEvents rdoNoPlan As RadioButton
    Friend WithEvents rdoBronze As RadioButton
    Friend WithEvents rdoSilver As RadioButton
    Friend WithEvents ChkEveningCalls As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAmountPayable As Label
    Friend WithEvents lblGST As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents txtAmountPayable As TextBox
    Friend WithEvents txtGST As TextBox
    Friend WithEvents txtSubTotal As TextBox
End Class
