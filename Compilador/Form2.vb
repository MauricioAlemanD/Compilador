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

    Private Sub btnNuevoInput_MouseHover(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseHover
        Dim rutaNuevoInput As String = "C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\usuarioW.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnNuevoInput.Image = nuevaImagen
    End Sub

    Private Sub btnNuevoInput_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseLeave
        Dim rutaNuevoInput As String = "C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\usuario.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnNuevoInput.Image = nuevaImagen
    End Sub

    Private Sub PictureBox14_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        Dim rutaNuevoInput As String = "C:\maun\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\salida-de-emergenciaW.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnSalir.Image = nuevaImagen
    End Sub

    Private Sub PictureBox14_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        Dim rutaNuevoInput As String = "C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\salida-de-emergencia.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnSalir.Image = nuevaImagen
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub
End Class