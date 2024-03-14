Imports System.Threading

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Form1.Visible = False
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub IniciarCompiladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarCompiladorToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas iniciar el compilador?", vbQuestion + vbYesNo + vbDefaultButton1)

        If cambioVentana = vbYes Then

            MsgBox("Inicializando compilador, espere un momento...", vbInformation)
            Thread.Sleep(2000)
            Form5.Visible = True
            Me.Visible = False

        ElseIf cambioVentana = vbNo Then

            MsgBox("Manteniendose en la ventana principal.", vbExclamation, vbOKOnly)

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas salir del compilador?", vbQuestion + vbYesNo + vbDefaultButton1)

        If cambioVentana = vbYes Then

            MsgBox("Saliendo del compilador, guardando cambios", vbInformation)
            Thread.Sleep(3000)
            Me.Close()

        ElseIf cambioVentana = vbNo Then

            MsgBox("Manteniendose en la ventana principal.", vbExclamation, vbOKOnly)

        End If
    End Sub
End Class