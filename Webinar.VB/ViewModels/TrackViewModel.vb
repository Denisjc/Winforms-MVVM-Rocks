Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Webinar.VB.Data

Namespace ViewModels

    <POCOViewModel>
    Partial Public Class TrackViewModel
        Implements IEditableObject

        Private _track As TrackInfo

        Protected Sub New()
            Me.New(New TrackList().Item(32))
        End Sub

        Protected Sub New(ByVal track As TrackInfo)
            If track Is Nothing Then Throw New ArgumentNullException("track", "track is null.")
            Load(track)
        End Sub

        Public Shared Function Create() As TrackViewModel
            Return ViewModelSource.Create(Function() New TrackViewModel())
        End Function

        Public Shared Function Create(ByVal track As TrackInfo) As TrackViewModel
            Return ViewModelSource.Create(Function() New TrackViewModel(track))
        End Function

        Private Sub Load(ByVal track As TrackInfo)
            Me._track = track
            Me.TrackId = _track.TrackId
            Me.Name = _track.Name
            Me.Composer = _track.Composer
        End Sub

        Public Overridable Property TrackId As Integer
        Public Overridable Property Name As String
        Public Overridable Property Composer As String

        Public Function CanResetName() As Boolean
            Return _track IsNot Nothing AndAlso Not String.IsNullOrEmpty(Name)
        End Function

        Public Sub ResetName()
            If _track IsNot Nothing Then
                If MessageBoxService.ShowMessage("Are you sure you want to reset the Name value?", "Question", MessageButton.YesNo, MessageIcon.Question, MessageResult.No) = MessageResult.Yes Then Name = ""
            End If
        End Sub

        <ServiceProperty(SearchMode:=ServiceSearchMode.PreferParents)>
        Public Overridable ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub BeginEdit() Implements IEditableObject.BeginEdit

        End Sub

        Public Sub EndEdit() Implements IEditableObject.EndEdit

            If Not String.Equals(Name, _track.Name) Then _track.Name = Name
            If Not String.Equals(Composer, _track.Composer) Then _track.Composer = Composer
            If TrackId <> _track.TrackId Then _track.TrackId = TrackId
        End Sub

        Public Sub CancelEdit() Implements IEditableObject.CancelEdit
            Load(_track)
        End Sub


        Public Sub Save()
            EndEdit()
        End Sub

        Public Sub Revert()
            CancelEdit()

        End Sub
    End Class
End NameSpace