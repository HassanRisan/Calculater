Imports System.Globalization
Imports Caculator.Caculator
Imports WinFormsApp1.Caculator

Public Class Caculator

    Dim DobFirstValue As Double = 0
    Dim DobSecondValue As Double = 0
    Dim DobResult As Double = 0
    Dim StrOperationType As String = ""
    Dim IsThereAWrong? As Boolean = False
    Dim BolSecondDisplay? As Boolean = False

    Private Sub NumbersClick(sender As Object, e As EventArgs) Handles btn2.Click, btn3.Click, btn1.Click, btn5.Click, btn6.Click, btn4.Click, btn8.Click, btn9.Click, btn7.Click, btn0.Click, btnDecimal.Click

        If (IsThereAWrong = True) Then RestTheProgram()

        Dim Btn As Button = sender

        If (lblDisplay.Text = "0") Then
            lblDisplay.Text = ""
            lblDisplay.Text = Btn.Text

        ElseIf (Btn.Text = ".") Then
            If (Not lblDisplay.Text.Contains(".")) Then
                lblDisplay.Text += Btn.Text
            End If
        Else
            lblDisplay.Text += Btn.Text
        End If
    End Sub

    Private Sub OperatorClick(sender As Object, e As EventArgs) Handles btnDivide.Click, btnMultiply.Click, btnSubtract.Click, btnAdd.Click, btnPower.Click



        If (StrOperationType = "") Then

            Dim BtnOperationType As Button = sender
            DobFirstValue = Convert.ToDouble(lblDisplay.Text)
            StrOperationType = BtnOperationType.Text
            lblDisplay.Text = "0"

        Else
            Dim StrCopyOperationType As String = StrOperationType
            BolSecondDisplay = True
            btnEquals_Click(sender, e)
            lblSecondDisplay.Text = lblDisplay.Text
            OperatorClick(sender, e)
            BolSecondDisplay = False

        End If



    End Sub

    Private Sub btnDEL_Click(sender As Object, e As EventArgs) Handles btnBEL.Click

        If (lblDisplay.Text.Length > 1) Then
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1)
        Else
            lblDisplay.Text = "0"
        End If
        If (IsThereAWrong = True) Then RestTheProgram()
    End Sub

    Private Function GetOperationTypeAsEnum(OperationType As String) As EnOperationType

        Select Case OperationType
            Case "+"
                Return EnOperationType.Add
            Case "-"
                Return EnOperationType.Subtract
            Case "x"
                Return EnOperationType.Multiply
            Case "/"
                Return EnOperationType.Divide
            Case "OneDivideX"
                Return EnOperationType.OneDivideX
            Case "^"
                Return EnOperationType.Power
        End Select

    End Function

    Private Function GetResult(OperationType As EnOperationType) As Double

        Select Case OperationType
            Case EnOperationType.Add
                Return DobFirstValue + DobSecondValue
            Case EnOperationType.Subtract
                Return DobFirstValue - DobSecondValue
            Case EnOperationType.Multiply
                Return DobFirstValue * DobSecondValue
            Case EnOperationType.Divide
                Return DobFirstValue / DobSecondValue
            Case EnOperationType.PlusMinus
                Return DobFirstValue * -1
            Case EnOperationType.SquareRoot
                Return Math.Sqrt(DobFirstValue)
            Case EnOperationType.Square
                Return Math.Pow(DobFirstValue, 2)
            Case EnOperationType.OneDivideX
                Return 1 / DobFirstValue
            Case EnOperationType.Power
                Return Math.Pow(DobFirstValue, DobSecondValue)




        End Select

    End Function

    Enum EnOperationType
        Add
        Divide
        Multiply
        Subtract
        PlusMinus
        SquareRoot
        Square
        OneDivideX
        Power

    End Enum

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        If (BolSecondDisplay = False) Then
            lblSecondDisplay.Text = ""
        End If

        DobSecondValue = Convert.ToDouble(lblDisplay.Text)

        Dim OperationType As EnOperationType = GetOperationTypeAsEnum(StrOperationType)

        If ((OperationType = EnOperationType.Divide Or OperationType = EnOperationType.OneDivideX) And DobSecondValue = 0) Then
            lblDisplay.Text = "Cannot divide by zero"
            DisenabledButtons()
            IsThereAWrong = True
        Else
            DobResult = GetResult(OperationType)
            lblDisplay.Text = Convert.ToString(DobResult)
            StrOperationType = ""
            IsThereAWrong = False
        End If


    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click


        DobFirstValue = Convert.ToDouble(lblDisplay.Text)
        DobResult = GetResult(EnOperationType.PlusMinus)
        lblDisplay.Text = Convert.ToString(DobResult)
        StrOperationType = ""

    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        DobFirstValue = Convert.ToDouble(lblDisplay.Text)

        If (DobFirstValue < 0) Then
            lblDisplay.Text = "Invalid input"
            DisenabledButtons()
            IsThereAWrong = True
        Else
            DobResult = GetResult(EnOperationType.SquareRoot)
            lblDisplay.Text = Convert.ToString(DobResult)
            StrOperationType = ""
            IsThereAWrong = False
        End If
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        DobFirstValue = Convert.ToDouble(lblDisplay.Text)
        DobResult = GetResult(EnOperationType.Square)
        lblDisplay.Text = Convert.ToString(DobResult)
        StrOperationType = ""
    End Sub

    Private Sub btn1DivideX_Click(sender As Object, e As EventArgs) Handles btn1DivideX.Click
        DobFirstValue = Convert.ToDouble(lblDisplay.Text)
        StrOperationType = "OneDivideX"
        btnEquals_Click(sender, e)
    End Sub


    Private Function DisenabledButtons()

        btnAdd.Enabled = False
        btnDivide.Enabled = False
        btnMultiply.Enabled = False
        btnSubtract.Enabled = False
        btnSquare.Enabled = False
        btnSquareRoot.Enabled = False
        btnDecimal.Enabled = False
        btnEquals.Enabled = False
        btnPower.Enabled = False
        btnPM.Enabled = False
        btn1DivideX.Enabled = False

    End Function

    Private Function RestTheProgram()

        btnAdd.Enabled = True
        btnDivide.Enabled = True
        btnMultiply.Enabled = True
        btnSubtract.Enabled = True
        btnSquare.Enabled = True
        btnSquareRoot.Enabled = True
        btnDecimal.Enabled = True
        btnEquals.Enabled = True
        btnPower.Enabled = True
        btnPM.Enabled = True
        btn1DivideX.Enabled = True
        lblDisplay.Text = "0"

    End Function


    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        RestTheProgram()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        RestTheProgram()
    End Sub


End Class
