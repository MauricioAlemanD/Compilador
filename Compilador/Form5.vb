Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Select()


    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Dim cambioVentana As String

        cambioVentana = MsgBox("¿Deseas regresar a la ventna de inicio?", vbQuestion + vbYesNo + vbDefaultButton1)

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