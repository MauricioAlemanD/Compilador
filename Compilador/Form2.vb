Imports System.Threading

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Form1.Visible = False
    End Sub


    Private Sub IniciarCompiladorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IniciarCompiladorToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas iniciar el compilador?", vbQuestion + vbYesNo + vbDefaultButton1)

        If cambioVentana = vbYes Then

            MsgBox("Inicializando compilador, espere un momento...", vbInformation)
            Thread.Sleep(2000)
            Form5.Visible = True
            Me.Visible = False


        ElseIf cambioVentana = vbNo Then

            MsgBox("Manteniéndose en la ventana principal.", vbExclamation, vbOKOnly)

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas salir del compilador?", vbQuestion + vbYesNo + vbDefaultButton1)

        If cambioVentana = vbYes Then

            MsgBox("Saliendo del compilador. Guardando cambios...", vbInformation)
            Thread.Sleep(3000)
            Form1.Close()

        ElseIf cambioVentana = vbNo Then

            MsgBox("Manteniéndose en la ventana principal.", vbExclamation, vbOKOnly)

        End If
    End Sub

    Private Sub dkrIzqueirdo_Paint(sender As Object, e As PaintEventArgs) Handles dkrIzqueirdo.Paint

    End Sub
End Class