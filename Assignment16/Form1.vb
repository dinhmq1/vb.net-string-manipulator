Public Class Form1
    Dim blnOK As Boolean = False

    'Begin subroutine for counting vowels
    Private Sub btnCountVowels_Click(sender As Object, e As EventArgs) Handles btnCountVowels.Click

        Dim strCountVowel As String = 0
        Dim strCountWords As String = 0
        Dim intVowelCount As Integer

        ValidateData(strCountVowel, strCountWords)  'begin function to validate sentence textbox

        If blnOK = True Then
            CalcNumberOfVowels(intVowelCount, strCountVowel)
        End If


    End Sub

    'Begin subroutine for counting number of words
    Private Sub btnCountWords_Click(sender As Object, e As EventArgs) Handles btnCountWords.Click

        Dim strCountVowel As String = 0
        Dim strCountWords As String = 0
        Dim intWordCount As Integer = 1

        ValidateData(strCountVowel, strCountWords)

        If blnOK = True Then
            CalcStringLength(strCountWords, intWordCount)
        End If

    End Sub

    'Begin subroutine for reversing string
    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click

        Dim strMainWord As String = txtSentence.Text
        Dim strReverseWord As String = StrReverse(strMainWord)

        'strMainWord = txtSentence.Text

        If strMainWord.Length > 0 Then
            MessageBox.Show("Your sentence is reversed into: " & strReverseWord.ToString)
        Else
            MessageBox.Show("Please enter some words.")
        End If

    End Sub

    'Begin function for calculating number of vowels
    Private Function CalcNumberOfVowels(ByVal strCountVowel As String, ByVal intVowelCount As Integer)

        Dim strSentence As String
        Dim intVCount As Integer

        strSentence = txtSentence.Text

        'The split function is used to parse and seperate the source(txtSentence) string by seperating the parts that comes between the delimiter.
        intVCount = strSentence.Split("a").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of a")
        End If

        intVCount = strSentence.Split("e").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of e")
        End If

        intVCount = strSentence.Split("i").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of i")
        End If

        intVCount = strSentence.Split("o").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of o")
        End If

        intVCount = strSentence.Split("u").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of u")
        End If
        'looking for uppercase vowels
        intVCount = strSentence.Split("A").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of A")
        End If

        intVCount = strSentence.Split("E").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of E")
        End If

        intVCount = strSentence.Split("I").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of I")
        End If

        intVCount = strSentence.Split("O").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of O")
        End If

        intVCount = strSentence.Split("U").Length - 1
        If intVCount > 0 Then
            MessageBox.Show(intVCount.ToString & " count(s) of U")
        End If

        Return intVCount
    End Function

    'Begin function for calculating number of words
    Private Function CalcStringLength(ByVal strCountWords As String, ByVal intWordCount As Integer)

        Dim strSentenceLength As String
        Dim intWCount As Integer = 1

        strSentenceLength = txtSentence.Text

        If strSentenceLength.Length >= 0 Then
            intWCount = strSentenceLength.Length
            intWCount -= strSentenceLength.Split(" ").Length - 1
            MessageBox.Show("You entered " & intWCount.ToString & " word(s) not including spaces.")
        Else
            MessageBox.Show("Please enter a word.")
        End If

        Return intWCount
    End Function

    'Begin subroutine to validate that the sentence field is not empty
    Private Sub ValidateData(ByRef strCountVowel As String, ByRef strCountWords As String)

        If String.IsNullOrEmpty(txtSentence.Text) Then
            blnOK = False
            txtSentence.Focus()
            MessageBox.Show("Please enter some words.")
        Else
            blnOK = True
            Exit Sub
        End If

    End Sub

    'Begin subroutine for breaking apart csv record
    Private Sub btnBreakApart_Click(sender As Object, e As EventArgs) Handles btnBreakApart.Click


        Dim strBreakApartRecord As String
        Dim strRecord As String

        ValidateBreakApart(strBreakApartRecord)

        If blnOK = True Then

            CalcBreakApart(strBreakApartRecord, strRecord)

        End If

    End Sub

    'Begin function for breaking apart csv sentence and placing them in the field textbox
    Private Function CalcBreakApart(ByVal strBreakApartRecord As String, ByVal strRecord As String)

        Dim strBreakApartRecords As String = txtRecord.Text
        Dim strRecords As String() = strBreakApartRecords.Split(","c)

        txtField1.Text = strRecords(0).ToString()
        txtField1.Text = strRecords(0).Trim(" ")
        txtField2.Text = strRecords(1).ToString()
        txtField2.Text = strRecords(1).Trim(" ")
        txtField3.Text = strRecords(2).ToString()
        txtField3.Text = strRecords(2).Trim(" ")
        txtField4.Text = strRecords(3).ToString()
        txtField4.Text = strRecords(3).Trim(" ")
        txtField5.Text = strRecords(4).ToString()
        txtField5.Text = strRecords(4).Trim(" ")
        txtField6.Text = strRecords(5).ToString()
        txtField6.Text = strRecords(5).Trim(" ")

        txtRecord.Clear()
        Return strRecords
    End Function

    'Begin subroutine to validate text to put together
    Private Sub ValidatePutTogether(ByRef strFields As String)

        If String.IsNullOrEmpty(txtField1.Text) Then
            MessageBox.Show("Field 1 is empty")
            txtField1.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtField2.Text) Then
            MessageBox.Show("Field 2 is empty")
            txtField2.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtField3.Text) Then
            MessageBox.Show("Field 3 is empty")
            txtField3.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtField4.Text) Then
            MessageBox.Show("Field 4 is empty")
            txtField4.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtField5.Text) Then
            MessageBox.Show("Field 5 is empty")
            txtField5.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtField6.Text) Then
            MessageBox.Show("Field 6 is empty")
            txtField6.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

    End Sub

    'Begin subroutine for validating text to break apart
    Private Sub ValidateBreakApart(ByRef strBreakApartRecord As String)

        If String.IsNullOrEmpty(txtRecord.Text) Then
            MessageBox.Show("Please enter some records.")
            txtRecord.Focus()
            blnOK = False
        Else
            blnOK = True
            Exit Sub
        End If

    End Sub

    'Begin sub for putting together csv record
    Private Sub btnPutTogether_Click(sender As Object, e As EventArgs) Handles btnPutTogether.Click

        Dim strFields As String

        ValidatePutTogether(strFields)

        If blnOK = True Then
            txtRecord.Text = String.Concat(txtField1.Text & ", " & txtField2.Text & ", " & txtField3.Text & ", " & txtField4.Text & ", " & txtField5.Text & ", " & txtField6.Text)
        End If

        txtField1.Clear()
        txtField2.Clear()
        txtField3.Clear()
        txtField4.Clear()
        txtField5.Clear()
        txtField6.Clear()

    End Sub

    'Begin formatting phone numbers
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnFormatPhoneNumber.Click

        Dim strPhoneNumbers As String

        ValidatePhoneNumber(strPhoneNumbers)

        If blnOK = True Then

            Dim strPhoneNumber As String = txtPhoneNumber.Text
            Dim strFormatPhoneNumber As String = CLng(strPhoneNumber).ToString("(###)-###-####")

            FormatPhoneNumber(strPhoneNumber, strFormatPhoneNumber)

        End If

    End Sub

    'Begin function to format phone numbers
    Private Function FormatPhoneNumber(ByVal strPhoneNumber As String, ByVal strFormatPhoneNumber As String)

        Dim strPhoneNumbers As String = txtPhoneNumber.Text
        Dim strFormatPhoneNumbers As String = CLng(strPhoneNumber).ToString("(###)-###-####")

        If strPhoneNumbers.Length > 10 Then
            blnOK = False
            MessageBox.Show("Phone number is too long.")
            txtPhoneNumber.Clear()
            txtPhoneNumber.Focus()
        Else
            blnOK = True
            strPhoneNumbers = Replace(strPhoneNumber, "(", "")
            strPhoneNumbers = Replace(strPhoneNumber, ")", "")
            strPhoneNumbers = Replace(strPhoneNumber, "-", "")
            strPhoneNumbers = Replace(strPhoneNumber, ".", "")
            strPhoneNumbers = Replace(strPhoneNumber, Space(1), "")
            lblFormattedPhoneNumber.Text = strFormatPhoneNumbers.ToString

        End If
        Return strPhoneNumbers
    End Function

    'Begin sub to validate correct phone number input
    Private Sub ValidatePhoneNumber(ByRef strPhoneNumbers As String)

        If IsNumeric(txtPhoneNumber.Text) Then
            blnOK = True
        Else
            blnOK = False
            txtPhoneNumber.Clear()
            txtPhoneNumber.Focus()
            MessageBox.Show("Please enter numbers only.")
            Exit Sub
        End If

        If txtPhoneNumber.Text.Length = 10 Then
            blnOK = True
        Else
            blnOK = False
            txtPhoneNumber.Clear()
            txtPhoneNumber.Focus()
            MessageBox.Show("Please enter 10 numbers.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtField1.Clear()
        txtField2.Clear()
        txtField3.Clear()
        txtField4.Clear()
        txtField5.Clear()
        txtField6.Clear()
        txtSentence.Clear()
        txtRecord.Clear()
        txtPhoneNumber.Clear()
        lblFormattedPhoneNumber.Text = String.Empty

    End Sub
End Class
