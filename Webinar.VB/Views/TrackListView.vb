Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Webinar.VB.ViewModels

Partial Public Class TrackListView
    Inherits XtraUserControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (Not DesignMode) Then InitBindings()

    End Sub

    Private Sub InitBindings()

        Dim mvvm = mvvmContext1.OfType(Of TrackListViewModel)()

        mvvm.WithEvent(Of ColumnView, FocusedRowObjectChangedEventArgs)(GridView1, "FocusedRowObjectChanged") _
            .SetBinding(Function(x) x.SelectedTrack,
                        Function(args) args.Row,
                        Function(gView, track) gView.FocusedRowHandle = gView.FindRow(track))

        mvvm.WithEvent(Of RowClickEventArgs)(GridView1, "RowClick") _
            .EventToCommand(Function(x) x.SelectedTrack,
                            Function(args) args.Clicks.Equals(2) AndAlso args.Button = MouseButtons.Left)


    End Sub

End Class

