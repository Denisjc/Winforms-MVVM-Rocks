
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Webinar.VB.Data

Namespace ViewModels

    <POCOViewModel>
    Partial Public Class TrackListViewModel

        Public Overridable Property Tracks As TrackList
        Public Overridable Property SelectedTrack As TrackInfo

        Protected Sub New()
            Tracks = New TrackList()
        End Sub

        Public Shared Function Create() As TrackListViewModel
            Return ViewModelSource.Create(Function() New TrackListViewModel())
        End Function

        <ServiceProperty(SearchMode:=ServiceSearchMode.PreferParents)>
        Protected Overridable ReadOnly Property DocumentManagerService As IDocumentManagerService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub EditTrack(ByVal trackObject As Object)
            Dim track = TryCast(trackObject, TrackInfo)
            Dim document = DocumentManagerService.CreateDocument("TrackView", TrackViewModel.Create(track))
            document.Show()
        End Sub

    End Class
End NameSpace