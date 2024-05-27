Option Strict On
Imports System.CodeDom.Compiler
Imports System.Reflection
Class ModuleCodeDom

    Shared Function Eval(ByVal expresion As String) As Object
        Dim CrLf As String = Environment.NewLine
        Dim cpar As New CompilerParameters()

        cpar.GenerateInMemory = True

        cpar.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

        Dim vbcp As New VBCodeProvider()

        Dim source As String =
        "Imports Microsoft.VisualBasic" & CrLf &
        "Namespace MiNamespace" & CrLf &
        "   Public Class MiClase" & CrLf &
        "       Public Shared Function Eval() As Object " & CrLf &
        "           Return " & expresion & CrLf &
        "       End Function" & CrLf &
        "   End Class" & CrLf &
        "End Namespace"

        Dim res As CompilerResults = vbcp.CompileAssemblyFromSource(cpar, source)
        res.TempFiles.KeepFiles = True

        If (res.Errors.Count > 0) Then _
            Return res.Errors(0).ErrorText

        Dim ty As System.Type =
            res.CompiledAssembly.GetType("MiNamespace.MiClase")

        Dim funceval As MethodInfo = ty.GetMethod("Eval")

        Return funceval.Invoke(Nothing, Nothing)
    End Function
End Class
