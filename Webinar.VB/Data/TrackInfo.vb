Imports System.ComponentModel

Namespace Data

    Public Class TrackInfo
        Implements INotifyPropertyChanged

        Public Sub New()
        End Sub

        Public Sub New(trackId As Integer, name As String, albumId As Integer, mediaTypeId As Integer, genreId As Integer, composer As String, milliseconds As Double, bytes As Double)
            _trackId = trackId
            _name = name
            _albumId = albumId
            _mediaTypeId = mediaTypeId
            _genreId = genreId
            _composer = composer
            _milliseconds = milliseconds
            _bytes = bytes
        End Sub

        Private _trackId As Integer

        Public Property TrackId As Integer
            Get
                Return _trackId
            End Get
            Set(value As Integer)
                If _trackId = value Then Return
                _trackId = value
                OnPropertyChanged("TrackId")
            End Set
        End Property

        Private _name As String

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                If _name = value Then Return
                _name = value
                OnPropertyChanged("Name")
            End Set
        End Property

        Private _albumId As Integer

        Public Property AlbumId As Integer
            Get
                Return _albumId
            End Get
            Set(value As Integer)
                If _albumId = value Then Return
                _albumId = value
                OnPropertyChanged("AlbumId")
            End Set
        End Property

        Private _mediaTypeId As Integer

        Public Property MediaTypeId As Integer
            Get
                Return _mediaTypeId
            End Get
            Set(value As Integer)
                If _mediaTypeId = value Then Return
                _mediaTypeId = value
                OnPropertyChanged("MediaTypeId")
            End Set
        End Property

        Private _genreId As Integer

        Public Property GenreId As Integer
            Get
                Return _genreId
            End Get
            Set(value As Integer)
                If _genreId = value Then Return
                _genreId = value
                OnPropertyChanged("GenreId")
            End Set
        End Property

        Private _composer As String

        Public Property Composer As String
            Get
                Return _composer
            End Get
            Set(value As String)
                If _composer = value Then Return
                _composer = value
                OnPropertyChanged("Composer")
            End Set
        End Property

        Private _milliseconds As Double

        Public Property Milliseconds As Double
            Get
                Return _milliseconds
            End Get
            Set(value As Double)
                If _milliseconds = value Then Return
                _milliseconds = value
                OnPropertyChanged("Milliseconds")
            End Set
        End Property

        Private _bytes As Double

        Public Property Bytes As Double
            Get
                Return _bytes
            End Get
            Set(value As Double)
                If _bytes = value Then Return
                Bytes = value
                OnPropertyChanged("Bytes")
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return String.Format("Name: {0}, Milliseconds: {1}, Composer: {2}", Name, Milliseconds, Composer)
        End Function


        Public Event Handler As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(propertyName As String)
            RaiseEvent Handler(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

    End Class
End NameSpace