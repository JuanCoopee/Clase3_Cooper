Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim metros, M, V, N, M1, V1, N1, MR, VR, NR, op, rollos As Double
        Dim err As Integer
        Dim dia, dia2, res3 As Double
        Dim hr, hr2, res2 As Double
        Dim npxm As Double
        Dim dhilo As Double
        Dim tiem, tiem2, res1 As Double
        Dim k As Double



        metros = TextBox1.Text
        err = TextBox2.Text

        npxm = 300
        dhilo = 0.00015
        k = 1.2

        If err < 10 Then
            MsgBox("El margen de error es muy pequeño")
        ElseIf err >= 10 And err < 20 Then
            tiem = metros / (npxm * dhilo * k)
            hr = tiem / 60
            dia = hr / 24

            Label3.Text = "El tiempo en minutos es: " & tiem
            Label4.Text = "El tiempo horas es: " & hr
            Label5.Text = "El tiempo dia por los 3 turnos es: " & dia
            op = metros / 24
            M1 = metros * 0.9
            V1 = 0
            N1 = 0

            Label6.Text = "En el turno matutino se hace " & M1 & " metros con el porcentaje de error del 10% "
            Label7.Text = "En el turno vespertino se hace " & V1 & " metros"
            Label8.Text = "En el turno nocturno se hace " & N1 & " metros"
            rollos = metros / 30
            Label9.Text = "El numero de rollos son " & rollos

        ElseIf err >= 20 And err < 30 Then
            tiem = metros / (npxm * dhilo * k)
            hr = tiem / 60
            dia = hr / 24

            Label3.Text = "El tiempo en minutos es: " & tiem
            Label4.Text = "El tiempo horas es: " & hr
            Label5.Text = "El tiempo dia por los 3 turnos es: " & dia

            op = metros / 17
            N1 = op * 8
            V1 = op * 9


            Label6.Text = "En el turno matutino se hace " & N1 & " metros con el porcentaje de error del 10% "
            Label7.Text = "En el turno vespertino se hace " & V1 & " metros"
            Label8.Text = "En el turno nocturno se hace " & 0 & " metros"

            rollos = metros / 30
            Label9.Text = "El numero de rollos son " & rollos

        ElseIf err >= 30 And err < 40 Then
            tiem = metros / (npxm * dhilo * k)
            hr = tiem / 60
            dia = hr / 24

            Label3.Text = "El tiempo en minutos es: " & tiem
            Label4.Text = "El tiempo horas es: " & hr
            Label5.Text = "El tiempo dia por los 3 turnos es: " & dia

            op = metros / 24
            M1 = op * 8
            V1 = op * 9
            N1 = op * 7

            Label6.Text = "En el turno matutino se hace " & M1 & " metros con el porcentaje de error del 10% "
            Label7.Text = "En el turno vespertino se hace " & V1 & " metros"
            Label8.Text = "En el turno nocturno se hace " & N1 & " metros"

            rollos = metros / 30
            Label9.Text = "El numero de rollos son " & rollos

        End If
    End Sub
End Class
