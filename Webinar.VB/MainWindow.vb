Imports System.ComponentModel
Imports System.Text


Partial Public Class MainWindow
    Inherits DevExpress.XtraEditors.XtraForm

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
End Class
