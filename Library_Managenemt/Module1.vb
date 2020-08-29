Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

'----------codes for removig 3d boder effect from mdi parent form-----------

Namespace MDITest

    Module MDIClientSupport

        <DllImport("user32.dll")>
        Private Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
        End Function

        <DllImport("user32.dll")>
        Private Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
        End Function

        <DllImport("user32.dll", ExactSpelling:=True)>
        Private Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Integer
        End Function

        Private Const GWL_EXSTYLE As Integer = -20

        Private Const WS_EX_CLIENTEDGE As Integer = 512

        Private Const SWP_NOSIZE As UInteger = 1

        Private Const SWP_NOMOVE As UInteger = 2

        Private Const SWP_NOZORDER As UInteger = 4

        Private Const SWP_NOREDRAW As UInteger = 8

        Private Const SWP_NOACTIVATE As UInteger = 16

        Private Const SWP_FRAMECHANGED As UInteger = 32

        Private Const SWP_SHOWWINDOW As UInteger = 64

        Private Const SWP_HIDEWINDOW As UInteger = 128

        Private Const SWP_NOCOPYBITS As UInteger = 256

        Private Const SWP_NOOWNERZORDER As UInteger = 512

        Private Const SWP_NOSENDCHANGING As UInteger = 1024

        <Extension()>
        Function SetBevel(ByVal form As Form, ByVal show As Boolean) As Boolean
            For Each c As Control In form.Controls
                Dim client As MdiClient = TryCast(c, MdiClient)
                If client IsNot Nothing Then
                    Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                    If show Then
                        windowLong = windowLong Or WS_EX_CLIENTEDGE
                    Else
                        windowLong = windowLong And Not WS_EX_CLIENTEDGE
                    End If

                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOZORDER Or SWP_NOOWNERZORDER Or SWP_FRAMECHANGED)
                    Return True
                End If
            Next

            Return False
        End Function
    End Module
End Namespace