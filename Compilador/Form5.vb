Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5

    Dim expresion As String
    Dim tam As Integer
    Dim caracter As String
    Dim operandos As String
    Dim operadores As String
    Dim numeros As String
    Dim simbolos As String
    Dim parte1, parte2 As String
    Dim valor1, valor2 As Integer
    Dim la As Integer
    Dim y As Integer
    Dim almacena As String, cara
    Dim s As String
    Dim c As Char
    Dim w As Integer
    Dim parentesis As String
    Dim cadena As String
    Dim largo As Integer
    Dim simbolo(40) As String
    Dim cas As Integer

    Dim gErronOn As Boolean = False
    Dim stateProceso As Boolean = True

    'Recurso para boton nuevo input'
    Dim NIbtnNW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\agregarW.png")
    Dim NIbtnNN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\agregar.png")
    'Recurso para boton guardar'
    Dim NIbtnDW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\descargasW.png")
    Dim NIbtnDN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\descargas.png")
    'Recurso para boton analizar'
    Dim NIbtnAW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\investigarW.png")
    Dim NIbtnAN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\investigar.png")
    'Recurso para boton compilar'
    Dim NIbtnCW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\configuracionW.png")
    Dim NIbtnCN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\configuracion.png")
    'Recurso para boton limpiar'
    Dim NIbtnLW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\limpieza-de-datosW.png")
    Dim NIbtnLN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\limpieza-de-datos.png")
    'Recurso para boton salir'
    Dim NIbtnSW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\salida-de-emergenciaW.png")
    Dim NIbtnSN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\salida-de-emergencia.png")
    'Recurso para boton error'
    Dim NIbtnEW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\advertencia1W.png")
    Dim NIbtnEN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\advertencia1.png")
    Dim NIbtnER As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\advertencia.png")
    'Recurso para boton proceso'
    Dim NIbtnPW As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\planificacionW.png")
    Dim NIbtnPN As Image = Image.FromFile("C:\Users\m4ury\OneDrive\Documentos\GitHub\Compilador\Compilador\resc\planificacion.png")

    Private Sub Limpia()
        txtCaracteres.Clear()
        txtOperandos.Clear()
        txtOperadores.Clear()
        txtOperadores.Clear()

        expresion = Nothing
        tam = Nothing
        caracter = Nothing
        operandos = Nothing
        operadores = Nothing
        numeros = Nothing
        simbolos = Nothing
    End Sub

    Private Sub LimpiaInput()
        txtInput.Clear()
    End Sub

    Private Sub accionLimpiar()
        Dim bri As Integer
        bri = MsgBox("¿Deseas limpiar los campos?", vbQuestion + vbYesNo + vbDefaultButton1)
        If bri = vbYes Then

            Limpia()
            LimpiaInput()

        ElseIf bri = vbNo Then

            MsgBox("No se ha borrado nada", MsgBoxStyle.Information, "Ejacutando")

        End If

    End Sub

    Public Sub TipoOperacion()
        contador = 0
        imp = imp
        largo = Len(imp)
        For i = 1 To largo
            token = Mid(imp, i, 1)
            If token = "/" Or token = "+" Or token = "*" Or token = "-" Then
                contador = contador + 1
            End If
        Next
    End Sub

    Private Sub regresar()
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

    Private Sub analizar()
        Limpia()
        If txtInput.Text = " " Or txtInput.Text = "" Or txtInput.Text = Nothing Or txtInput.Text = "|| Comienza por escribir ... ||" Then
            'MessageBox.Show("Ingrese una expresion", "Error", MessageBoxButtons.OK)
            lblErrorTemp.Text = "Ingrese una expresión válida"
            gErronOn = True
            btnErrores.Image = NIbtnER
            txtInput.Text = "|| Comienza por escribir ... ||"
            Exit Sub
        End If
        btnErrores.Image = NIbtnEN
        lblErrorTemp.Text = ""
        gpxError.Visible = False

        expresion = txtInput.Text
        tam = Len(expresion)

        For i As Integer = 1 To tam
            caracter = Mid(expresion, i, 1)
            Select Case caracter
                Case "0"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "1"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "2"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "1"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "3"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "4"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "5"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "6"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "7"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "8"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "9"
                    operandos = operandos & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "+"
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "-"
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "*"
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "/"
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case "("
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case ")"
                    operadores = operadores & caracter
                    txtCaracteres.AppendText(caracter & " valido" & vbCrLf)
                    btnErrores.Image = NIbtnEN
                Case Else
                    txtCaracteres.AppendText(caracter & " No valido" & vbCrLf)

                    'MessageBox.Show("La expresion no ha sido validada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblErrorTemp.Text = "La expresion no ha sido validada"
                    gErronOn = True
                    btnErrores.Image = NIbtnER
                    Exit Sub
            End Select
        Next

        tam = Len(operandos)
        For i As Integer = 1 To tam
            numeros = Mid(operandos, i, 1)
            txtOperandos.AppendText(numeros & vbCrLf)
        Next
        tam = Len(operadores)
        For i As Integer = 1 To tam
            simbolos = Mid(operadores, i, 1)
            txtOperadores.AppendText(simbolos & vbCrLf)
        Next
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Select()
    End Sub


    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseHover
        btnNuevoInput.Image = NIbtnNW
    End Sub

    Private Sub btnNuevoInput_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevoInput.MouseLeave
        btnNuevoInput.Image = NIbtnNN
    End Sub

    Private Sub RegresarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        regresar()
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        btnGuardar.Image = NIbtnDW
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Image = NIbtnDN
    End Sub

    Private Sub btnAnalizr_MouseHover(sender As Object, e As EventArgs) Handles btnAnalizr.MouseHover
        btnAnalizr.Image = NIbtnAW
    End Sub

    Private Sub btnAnalizr_MouseLeave(sender As Object, e As EventArgs) Handles btnAnalizr.MouseLeave
        btnAnalizr.Image = NIbtnAN
    End Sub

    Private Sub btnCompilar_MouseHover(sender As Object, e As EventArgs) Handles btnCompilar.MouseHover
        btnCompilar.Image = NIbtnCW
    End Sub

    Private Sub btnCompilar_MouseLeave(sender As Object, e As EventArgs) Handles btnCompilar.MouseLeave
        btnCompilar.Image = NIbtnCN
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        btnLimpiar.Image = NIbtnLW
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        btnLimpiar.Image = NIbtnLN
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        btnSalir.Image = NIbtnSW
    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        btnSalir.Image = NIbtnSN
    End Sub

    Private Sub btnErrores_MouseHover(sender As Object, e As EventArgs) Handles btnErrores.MouseHover
        btnErrores.Image = NIbtnEW
    End Sub

    Private Sub btnErrores_MouseLeave(sender As Object, e As EventArgs) Handles btnErrores.MouseLeave
        btnErrores.Image = NIbtnEN
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        accionLimpiar()
        LimpiaInput()

    End Sub

    Private Sub IniciarCompiladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarCompiladorToolStripMenuItem.Click
        accionLimpiar()
        LimpiaInput()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        regresar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        analizar()
    End Sub

    Private Sub btnAnalizr_Click(sender As Object, e As EventArgs) Handles btnAnalizr.Click
        analizar()
    End Sub

    Private Sub btnErrores_Click(sender As Object, e As EventArgs) Handles btnErrores.Click
        If gErronOn = True Then
            gpxError.Visible = True
        Else
            gpxError.Visible = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        gpxError.Visible = False
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.White
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.LightGray
    End Sub

    Private Sub btnProcesos_Click(sender As Object, e As EventArgs) Handles btnProcesos.Click
        If stateProceso = True Then
            stateProceso = False
            Panel1.Visible = False
            Panel3.Visible = False
            Panel2.Visible = False
            Panel5.Visible = False
        Else
            stateProceso = True
            Panel1.Visible = True
            Panel3.Visible = True
            Panel2.Visible = True
            Panel5.Visible = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        regresar()
    End Sub

    Private Sub btnProcesos_MouseHover(sender As Object, e As EventArgs) Handles btnProcesos.MouseHover
        btnProcesos.Image = NIbtnPW
    End Sub

    Private Sub btnProcesos_MouseLeave(sender As Object, e As EventArgs) Handles btnProcesos.MouseLeave
        btnProcesos.Image = NIbtnPN
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnCompilar_Click(sender As Object, e As EventArgs) Handles btnCompilar.Click
        accionCompilar()

    End Sub

    Public Sub Sumar()
        o = 0
        m = 0
        x = 0
        z = 0
        lim = 0
        dis = 0
        s = 0
        dr = 0
        op = 0
        des = 0
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "+" Then
                x = i
                m = i
                While x > 1
                    token = Mid(imp, x + 1, 1)
                    If token = "+" Or token = "-" Then
                        Exit While
                    Else
                        lim = lim + 1
                    End If
                    x = x + 1
                End While
                Exit For
            End If
        Next
        dis = lim + m
        operacion = Mid(imp, 1, dis)
        z = tama - m
        basura = Mid(imp, dis + 1, z)
        resultado = ModuleCodeDom.Eval(operacion)
        res = Convert.ToString(resultado)
        imp = res + basura
        txtOperaciones.AppendText(imp & vbCrLf)
    End Sub

    Public Sub accionCompilar()
        txtOperaciones.Clear()
        ordn = True
        imp = txtInput.Text
        tama = Len(imp)
        txtOperaciones.AppendText(imp & vbCrLf)
        While ordn = True
            TipoOperacion()
            If contador = 1 Then
                operacion = imp
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                txtOperaciones.AppendText(res & vbCrLf)
                ordn = False
                GoTo fin
            Else
                For x = 1 To tama
                    token = Mid(imp, x, 1)
                    If token = "(" Then
                        Analisis()
                        GoTo fin
                        Exit For
                    End If
                Next
                For x = 1 To tama
                    token = Mid(imp, x, 1)
                    If token = "/" Then
                        Dividir()
                        GoTo fin
                        Exit For
                    ElseIf token = "*" Then
                        Multiplicar()
                        GoTo fin
                    End If
                Next
                For x = 1 To tama
                    token = Mid(imp, x, 1)
                    If token = "+" Then
                        Sumar()
                        GoTo fin
                        Exit For
                    ElseIf token = "-" Then
                        Resta()
                        GoTo fin
                    End If
                Next
fin:        End If
        End While
    End Sub

    Public Sub Dividir()
        o = 0
        m = 0
        x = 0
        z = 0
        lim = 0
        dis = 0
        s = 0
        dr = 0
        op = 0
        des = 0
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "+" Or token = "-" Or token = "*" Then
                o = 1
                Exit For
            ElseIf token = "/" Then
                o = 2
                Exit For
            End If
        Next
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "/" Then
                x = i
                m = i
                While x > 1
                    token = Mid(imp, x, 1)
                    If token = "+" Or token = "-" Or token = "*" Then
                        z = x
                        Exit While
                    Else
                        lim = lim + 1
                    End If
                    x = x - 1
                End While
                While m <= tama
                    token = Mid(imp, m, 1)
                    If token = "+" Or token = "-" Or token = "/" Or "-" Then
                        Exit While
                    Else
                        des = des + 1
                    End If
                    m = m + 1
                End While
                Exit For
            End If
        Next
        s = lim + des
        If o = 1 Then
            operacion = Mid(imp, z + 1, s - 1)
            basura = Mid(imp, 1, z)
            ss = basura + operacion
            dis = tama - Len(ss)
            If dis = 0 Then
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = res + basura
                txtOperaciones.AppendText(imp & vbCrLf)
                tama = Len(imp)
            Else
                basura2 = Mid(imp, Len(ss) + 1, dis)
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = basura + res + basura2
                txtOperaciones.AppendText(imp & vbCrLf)
                tama = Len(imp)
            End If
        Else
            dr = s
            While dr < tama
                op = op + 1
                dr = dr + 1
            End While
            operacion = Mid(imp, 1, s)
            basura = Mid(imp, s + 1, op)
            resultado = ModuleCodeDom.Eval(operacion)
            res = Convert.ToString(resultado)
            imp = res + basura
            txtOperaciones.AppendText(imp & vbCrLf)
            tama = Len(imp)
        End If
    End Sub

    Public Sub Resta()
        o = 0
        m = 0
        x = 0
        z = 0
        lim = 0
        dis = 0
        s = 0
        dr = 0
        op = 0
        des = 0
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "-" Then
                x = i
                m = i
                While x > 1
                    token = Mid(imp, x + 1, 1)
                    If token = "+" Or token = "-" Then
                        Exit While
                    Else
                        lim = lim + 1
                    End If
                    x = x + 1
                End While
                Exit For
            End If
        Next
        dis = lim + m
        operacion = Mid(imp, 1, dis)
        z = tama - m
        basura = Mid(imp, dis + 1, z)
        resultado = ModuleCodeDom.Eval(operacion)
        res = Convert.ToString(resultado)
        imp = res + basura
        txtOperaciones.AppendText(imp & vbCrLf)
    End Sub

    Public Sub Multiplicar()
        o = 0
        m = 0
        x = 0
        z = 0
        lim = 0
        dis = 0
        s = 0
        dr = 0
        op = 0
        des = 0
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "+" Or token = "-" Or token = "/" Then
                o = 1
                Exit For
            ElseIf token = "*" Then
                o = 2
                Exit For
            End If
        Next
        For i = 1 To tama
            token = Mid(imp, i, 1)
            If token = "*" Then
                x = i
                m = i
                While x > 1
                    token = Mid(imp, x, 1)
                    If token = "+" Or token = "-" Or token = "/" Then
                        z = x
                        Exit While
                    Else
                        lim = lim + 1
                    End If
                    x = x - 1
                End While
                While m <= tama
                    token = Mid(imp, m, 1)
                    If token = "+" Or token = "-" Or token = "/" Then
                        Exit While
                    Else
                        des = des + 1
                    End If
                    m = m + 1
                End While
                Exit For
            End If
        Next
        s = lim + des
        If o = 1 Then
            operacion = Mid(imp, z + 1, s - 1)
            basura = Mid(imp, 1, z)
            ss = basura + operacion
            dis = tama - Len(ss)
            If dis = 0 Then
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = res + basura
                txtOperaciones.AppendText(imp & vbCrLf)
                tama = Len(imp)
            Else
                basura2 = Mid(imp, Len(ss) + 1, dis)
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = basura + res + basura2
                txtOperaciones.AppendText(imp & vbCrLf)
                tama = Len(imp)
            End If
        Else
            dr = s
            While dr < tama
                op = op + 1
                dr = dr + 1
            End While
            operacion = Mid(imp, 1, s)
            basura = Mid(imp, s + 1, op)
            resultado = ModuleCodeDom.Eval(operacion)
            res = Convert.ToString(resultado)
            imp = res + basura
            txtOperaciones.AppendText(imp & vbCrLf)
            tama = Len(imp)
        End If
    End Sub

    Public Sub Analisis()
        daf = 0
        cd = 0
        op = 0
        a = 0
        o = 0
        lim = 0
        dr = 0
        se = 0
        veces = 0
        x = 0
        ats = 0
        token = Mid(imp, 1, 1)

        If token = "(" Then
            o = 1
            MsgBox("Realizando compilación", MsgBoxStyle.Information, "Compilando")
        Else
            o = 2
        End If

        If o = 1 Then
            For x = 1 To tama
                token = Mid(imp, x, 1)
                If token <> ")" Then
                    op = op + 1
                ElseIf token = ")" Then
                    lim = x
                    Exit For
                End If
            Next

            daf = tama - op + 1
            operacion = Mid(imp, 2, op - 1)
            basura = Mid(imp, lim + 1, daf)
            resultado = ModuleCodeDom.Eval(operacion)
            res = Convert.ToString(resultado)
            imp = res + basura
            txtOperaciones.AppendText(imp & vbCrLf)
            imp = imp
            tama = Len(imp)
        Else
            For x = 1 To tama
                token = Mid(imp, x, 1)
                If token <> "(" Then
                    op = op + 1
                Else
                    Exit For
                End If
            Next
            For a = op + 1 To tama
                token = Mid(imp, a, 1)
                If token <> ")" Then
                    lim = lim + 1
                    m = lim
                Else
                    Exit For
                End If
            Next
            se = lim + op + 1
            basura = Mid(imp, 1, op)
            operacion = Mid(imp, op + 2, lim - 1)
            If se = tama Then
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = basura + res
                txtOperaciones.AppendText(imp & vbCrLf)
                imp = imp
                tama = Len(imp)
            Else
                ats = tama - se
                basura2 = Mid(imp, se + 1, ats)
                resultado = ModuleCodeDom.Eval(operacion)
                res = Convert.ToString(resultado)
                imp = basura + res + basura2
                txtOperaciones.AppendText(imp & vbCrLf)
                imp = imp
                tama = Len(imp)
            End If
        End If
    End Sub
End Class