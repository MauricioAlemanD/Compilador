Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Select()


    End Sub


    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseHover
        Dim rutaNuevoInput As String = "C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\agregarW.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnNuevoInput.Image = nuevaImagen

    End Sub

    Private Sub btnNuevoInput_Click(sender As Object, e As EventArgs) Handles btnNuevoInput.Click
    End Sub

    Private Sub btnNuevoInput_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseLeave
        Dim rutaNuevoInput As String = "C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\agregar.png"
        Dim nuevaImagen As Image = Image.FromFile(rutaNuevoInput)
        btnNuevoInput.Image = nuevaImagen
    End Sub

    Private Sub RegresarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas regresar a la ventana de inicio?", vbQuestion + vbYesNo + vbDefaultButton1)

        If cambioVentana = vbYes Then

            MsgBox("Regresando hacia el inicio, espere un momento...", vbInformation)
            Thread.Sleep(1000)
            Form2.Visible = True
            Me.Close()

        ElseIf cambioVentana = vbNo Then

            MsgBox("Manteniendose en la ventana de compilación.", vbExclamation, vbOKOnly)

        End If
    End Sub
End Class