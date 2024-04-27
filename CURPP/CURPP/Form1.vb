Public Class Form1
    Dim CApaterno, CAmaterno, CNombre, Caño, Cmes, Cdia, Genero, CEstado, Cons1Apat, Cons1Amat, Cons1Nom As String



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        CApaterno = Mid(TxtApaterno.Text, 1, 1) & ObtenerPrimeraVocalInterna(TxtApaterno.Text)
        CAmaterno = Mid(TxtAmaterno.Text, 1, 1)
        CNombre = Mid(TxtNombre.Text, 1, 1)
        Caño = Mid(TxtAño.Text, 3, 2)
        Cmes = ComboBoxMes.Text
        Cdia = ComboBoxDia.Text
        If RdioBtnHombre.Checked = True Then Genero = "H"
        If RdioBtnMujer.Checked = True Then Genero = "M"
        CEstado = Mid(ComboBoxEstado.Text, Len(ComboBoxEstado.Text) - 2, 2)
        Cons1Apat = ObtenerPrimerConsonanteInterna(TxtApaterno.Text)
        Cons1Amat = ObtenerPrimerConsonanteInterna(TxtAmaterno.Text)
        Cons1Nom = ObtenerPrimerConsonanteInterna(TxtNombre.Text)

        TxtCurp.Text = CApaterno & CAmaterno & CNombre & Caño & Cmes & Cdia & Genero & CEstado & Cons1Apat & Cons1Amat & Cons1Nom

    End Sub

    Public Function ObtenerPrimeraVocalInterna(cadena As String) As String
        Dim Letra As String = ""
        For i = 2 To Len(cadena)
            Letra = Mid(cadena, i, 1)
            If (Letra = "A" Or Letra = "E" Or Letra = "I" Or Letra = "O" Or Letra = "U") Then
                Exit For

            End If
        Next i
        Return Letra
    End Function

    Public Function ObtenerPrimerConsonanteInterna(Cadena As String) As String
        Dim Letra As String = ""
        For i = 2 To Len(Cadena)
            Letra = Mid(Cadena, i, 1)
            If Not (Letra = "A" Or Letra = "E" Or Letra = "I" Or Letra = "O" Or Letra = "U") Then
                Exit For
            End If
        Next i
        Return Letra
    End Function

    Private Sub TxtApaterno_LostFocus(sender As Object, e As EventArgs) Handles TxtApaterno.LostFocus
        TxtApaterno.Text = TxtApaterno.Text.ToUpper()
    End Sub

    Private Sub TxtAmaterno_LostFocus(sender As Object, e As EventArgs) Handles TxtAmaterno.LostFocus
        TxtAmaterno.Text = TxtAmaterno.Text.ToUpper()
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = TxtNombre.Text.ToUpper()
    End Sub


End Class
