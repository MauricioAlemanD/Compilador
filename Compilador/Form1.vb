Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TransparencyKey = Color.Crimson
        Me.BackColor = Color.Crimson
        ActualizarPorcentaje()
        Me.Opacity = 0
        Form2.TopLevel = True

    End Sub

    Public Sub ActualizarPorcentaje()
        Dim estadosPrograma As String() = {
        "Iniciando aplicación...",
        "Cargando configuración...",
        "Verificando actualizaciones...",
        "Conectando al servidor...",
        "Descargando archivos...",
        "Procesando datos...",
        "Generando informe...",
        "Esperando respuesta del usuario...",
        "Guardando cambios...",
        "Cerrando sesión...",
        "Optimizando recursos...",
        "Generando gráficos...",
        "Calculando estadísticas...",
        "Validando datos...",
        "Cargando módulos...",
        "Sincronizando archivos...",
        "Compilando código...",
        "Analizando resultados...",
        "Esperando respuesta del servidor...",
        "Limpiando caché..."
           }

        Dim random As New Random()
        Dim porcentajeActual As Integer = 0
        While porcentajeActual < 100
            porcentajeActual += random.Next(1, 11)
            If porcentajeActual > 100 Then
                porcentajeActual = 100
            End If
            prbProgreso.Value = porcentajeActual
            lblPorcentaje.Text = porcentajeActual.ToString() + "%"
            lblEstadoDeCarga.Text = estadosPrograma(random.Next(1, 20))
            Application.DoEvents()
            Threading.Thread.Sleep(random.Next(100, 500))
        End While

        If porcentajeActual = 100 Then
            Thread.Sleep(1000)
            Me.Hide()
            Form2.Visible = True
        End If


    End Sub
End Class
