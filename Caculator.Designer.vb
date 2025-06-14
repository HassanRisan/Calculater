<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caculator
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Caculator))
        btn0 = New Button()
        btnEquals = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn1 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn4 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn7 = New Button()
        btnBEL = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        btnSubtract = New Button()
        btnAdd = New Button()
        btnPM = New Button()
        btnC = New Button()
        btnPower = New Button()
        btnCE = New Button()
        btn1DivideX = New Button()
        btnSquare = New Button()
        btnSquareRoot = New Button()
        lblDisplay = New Label()
        btnDecimal = New Button()
        lblSecondDisplay = New Label()
        SuspendLayout()
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn0.FlatStyle = FlatStyle.Popup
        btn0.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn0.ForeColor = Color.White
        btn0.Location = New Point(137, 594)
        btn0.Name = "btn0"
        btn0.Size = New Size(120, 80)
        btn0.TabIndex = 0
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnEquals
        ' 
        btnEquals.BackColor = Color.FromArgb(CByte(76), CByte(194), CByte(255))
        btnEquals.FlatStyle = FlatStyle.Popup
        btnEquals.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        btnEquals.ForeColor = Color.White
        btnEquals.Location = New Point(389, 592)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(120, 80)
        btnEquals.TabIndex = 1
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn2.FlatStyle = FlatStyle.Popup
        btn2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn2.ForeColor = Color.White
        btn2.Location = New Point(137, 508)
        btn2.Name = "btn2"
        btn2.Size = New Size(120, 80)
        btn2.TabIndex = 5
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn3.FlatStyle = FlatStyle.Popup
        btn3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn3.ForeColor = Color.White
        btn3.Location = New Point(263, 508)
        btn3.Name = "btn3"
        btn3.Size = New Size(120, 80)
        btn3.TabIndex = 4
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn1.FlatStyle = FlatStyle.Popup
        btn1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn1.ForeColor = Color.White
        btn1.Location = New Point(11, 508)
        btn1.Name = "btn1"
        btn1.Size = New Size(120, 80)
        btn1.TabIndex = 3
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn5.FlatStyle = FlatStyle.Popup
        btn5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn5.ForeColor = Color.White
        btn5.Location = New Point(137, 422)
        btn5.Name = "btn5"
        btn5.Size = New Size(120, 80)
        btn5.TabIndex = 8
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn6.FlatStyle = FlatStyle.Popup
        btn6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn6.ForeColor = Color.White
        btn6.Location = New Point(263, 422)
        btn6.Name = "btn6"
        btn6.Size = New Size(120, 80)
        btn6.TabIndex = 7
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn4.FlatStyle = FlatStyle.Popup
        btn4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn4.ForeColor = Color.White
        btn4.Location = New Point(11, 422)
        btn4.Name = "btn4"
        btn4.Size = New Size(120, 80)
        btn4.TabIndex = 6
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn8.FlatStyle = FlatStyle.Popup
        btn8.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn8.ForeColor = Color.White
        btn8.Location = New Point(137, 336)
        btn8.Name = "btn8"
        btn8.Size = New Size(120, 80)
        btn8.TabIndex = 11
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn9.FlatStyle = FlatStyle.Popup
        btn9.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn9.ForeColor = Color.White
        btn9.Location = New Point(263, 336)
        btn9.Name = "btn9"
        btn9.Size = New Size(120, 80)
        btn9.TabIndex = 10
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btn7.FlatStyle = FlatStyle.Popup
        btn7.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn7.ForeColor = Color.White
        btn7.Location = New Point(11, 336)
        btn7.Name = "btn7"
        btn7.Size = New Size(120, 80)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btnBEL
        ' 
        btnBEL.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnBEL.FlatStyle = FlatStyle.Popup
        btnBEL.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnBEL.ForeColor = Color.White
        btnBEL.Location = New Point(389, 164)
        btnBEL.Name = "btnBEL"
        btnBEL.Size = New Size(120, 80)
        btnBEL.TabIndex = 19
        btnBEL.Text = "DEL"
        btnBEL.UseVisualStyleBackColor = False
        ' 
        ' btnDivide
        ' 
        btnDivide.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnDivide.FlatStyle = FlatStyle.Popup
        btnDivide.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnDivide.ForeColor = Color.White
        btnDivide.Location = New Point(389, 420)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(120, 80)
        btnDivide.TabIndex = 18
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnMultiply.FlatStyle = FlatStyle.Popup
        btnMultiply.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        btnMultiply.ForeColor = Color.GhostWhite
        btnMultiply.Location = New Point(389, 334)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(120, 80)
        btnMultiply.TabIndex = 17
        btnMultiply.Text = "x"
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btnSubtract
        ' 
        btnSubtract.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnSubtract.FlatStyle = FlatStyle.Popup
        btnSubtract.Font = New Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubtract.ForeColor = Color.White
        btnSubtract.Location = New Point(389, 248)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(120, 80)
        btnSubtract.TabIndex = 16
        btnSubtract.Text = "-"
        btnSubtract.TextAlign = ContentAlignment.TopCenter
        btnSubtract.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(389, 506)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 80)
        btnAdd.TabIndex = 15
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnPM
        ' 
        btnPM.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btnPM.FlatStyle = FlatStyle.Popup
        btnPM.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnPM.ForeColor = Color.White
        btnPM.Location = New Point(11, 594)
        btnPM.Name = "btnPM"
        btnPM.Size = New Size(120, 80)
        btnPM.TabIndex = 22
        btnPM.Text = "+/-"
        btnPM.UseVisualStyleBackColor = False
        ' 
        ' btnC
        ' 
        btnC.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnC.FlatStyle = FlatStyle.Popup
        btnC.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnC.ForeColor = Color.White
        btnC.Location = New Point(263, 164)
        btnC.Name = "btnC"
        btnC.Size = New Size(120, 80)
        btnC.TabIndex = 24
        btnC.Text = "C"
        btnC.UseVisualStyleBackColor = False
        ' 
        ' btnPower
        ' 
        btnPower.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnPower.FlatStyle = FlatStyle.Popup
        btnPower.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnPower.ForeColor = Color.White
        btnPower.Location = New Point(11, 250)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(120, 80)
        btnPower.TabIndex = 25
        btnPower.Text = "^"
        btnPower.UseVisualStyleBackColor = False
        ' 
        ' btnCE
        ' 
        btnCE.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnCE.FlatStyle = FlatStyle.Popup
        btnCE.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnCE.ForeColor = Color.White
        btnCE.Location = New Point(137, 164)
        btnCE.Name = "btnCE"
        btnCE.Size = New Size(120, 80)
        btnCE.TabIndex = 26
        btnCE.Text = "CE"
        btnCE.UseVisualStyleBackColor = False
        ' 
        ' btn1DivideX
        ' 
        btn1DivideX.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btn1DivideX.FlatStyle = FlatStyle.Popup
        btn1DivideX.Font = New Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btn1DivideX.ForeColor = Color.White
        btn1DivideX.Location = New Point(11, 164)
        btn1DivideX.Name = "btn1DivideX"
        btn1DivideX.Size = New Size(120, 80)
        btn1DivideX.TabIndex = 27
        btn1DivideX.Text = "1/x"
        btn1DivideX.UseVisualStyleBackColor = False
        ' 
        ' btnSquare
        ' 
        btnSquare.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnSquare.FlatStyle = FlatStyle.Popup
        btnSquare.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSquare.ForeColor = Color.White
        btnSquare.Location = New Point(137, 250)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(120, 80)
        btnSquare.TabIndex = 28
        btnSquare.Text = "X^2"
        btnSquare.UseVisualStyleBackColor = False
        ' 
        ' btnSquareRoot
        ' 
        btnSquareRoot.BackColor = Color.FromArgb(CByte(49), CByte(50), CByte(55))
        btnSquareRoot.FlatStyle = FlatStyle.Popup
        btnSquareRoot.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnSquareRoot.ForeColor = Color.White
        btnSquareRoot.Location = New Point(263, 250)
        btnSquareRoot.Name = "btnSquareRoot"
        btnSquareRoot.Size = New Size(120, 80)
        btnSquareRoot.TabIndex = 29
        btnSquareRoot.Text = "√x"
        btnSquareRoot.UseVisualStyleBackColor = False
        ' 
        ' lblDisplay
        ' 
        lblDisplay.AutoSize = True
        lblDisplay.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblDisplay.ForeColor = SystemColors.Control
        lblDisplay.Location = New Point(11, 65)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(51, 55)
        lblDisplay.TabIndex = 23
        lblDisplay.Text = "0"
        ' 
        ' btnDecimal
        ' 
        btnDecimal.BackColor = Color.FromArgb(CByte(56), CByte(59), CByte(64))
        btnDecimal.FlatStyle = FlatStyle.Popup
        btnDecimal.Font = New Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point)
        btnDecimal.ForeColor = Color.White
        btnDecimal.Location = New Point(263, 594)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(120, 80)
        btnDecimal.TabIndex = 2
        btnDecimal.Text = "."
        btnDecimal.TextAlign = ContentAlignment.TopCenter
        btnDecimal.UseVisualStyleBackColor = False
        ' 
        ' lblSecondDisplay
        ' 
        lblSecondDisplay.AutoSize = True
        lblSecondDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblSecondDisplay.ForeColor = SystemColors.Control
        lblSecondDisplay.Location = New Point(12, 24)
        lblSecondDisplay.Name = "lblSecondDisplay"
        lblSecondDisplay.Size = New Size(0, 32)
        lblSecondDisplay.TabIndex = 30
        ' 
        ' Caculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(37))
        ClientSize = New Size(519, 683)
        Controls.Add(lblSecondDisplay)
        Controls.Add(btnSquareRoot)
        Controls.Add(btnSquare)
        Controls.Add(btn1DivideX)
        Controls.Add(btnCE)
        Controls.Add(btnPower)
        Controls.Add(btnC)
        Controls.Add(lblDisplay)
        Controls.Add(btnBEL)
        Controls.Add(btnDivide)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(btn8)
        Controls.Add(btn9)
        Controls.Add(btn5)
        Controls.Add(btn6)
        Controls.Add(btn2)
        Controls.Add(btn3)
        Controls.Add(btnDecimal)
        Controls.Add(btnEquals)
        Controls.Add(btn0)
        Controls.Add(btnPM)
        Controls.Add(btn7)
        Controls.Add(btn4)
        Controls.Add(btn1)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Caculator"
        Text = "  Caculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn0 As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnBEL As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPM As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btn1DivideX As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnDecimal As Button
    Friend WithEvents lblSecondDisplay As Label
End Class
