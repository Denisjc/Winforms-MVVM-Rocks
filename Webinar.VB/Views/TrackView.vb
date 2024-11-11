Imports DevExpress.XtraEditors
Imports Webinar.VB.ViewModels

Partial Public Class TrackView
    Inherits XtraUserControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (Not DesignMode) Then InitBindings()


    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Not DesignMode Then InitBindings()
    End Sub

    Private Sub InitBindings()

        Dim fluent = mvvmContext1.OfType(Of TrackViewModel)()

        fluent.SetBinding(txtEditId, Function(x) x.EditValue, Function(x) x.TrackId)
        fluent.SetBinding(txtEditName, Function(x) x.EditValue, Function(x) x.Name)
        fluent.SetBinding(txtEditComposer, Function(x) x.EditValue, Function(x) x.Composer)

        fluent.BindCommand(btnClear, Sub(x) x.ResetName())
        fluent.BindCommand(btnSave, Sub(x) x.Save())
        fluent.BindCommand(btnCancel, Sub(x) x.Revert())

    End Sub
End Class

