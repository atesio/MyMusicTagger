Imports HundredMilesSoftware.UltraID3Lib

Public Class FrameListViewItem
    Inherits ListViewItem

    Private p_Frame As ID3Frame

    Public Sub New(ByVal item As ID3Frame)

        MyBase.New()

        p_Frame = item

        Dim FrameDescription As String = item.FrameDescription
        Me.Text = FrameDescription

        Me.SubItems.Add(item.ToString)

        Select Case item.Exceptions.Count
            Case 0
                Me.SubItems.Add(String.Empty)

            Case 1
                Me.SubItems.Add(item.Exceptions.Item(0).Message)

            Case Else
                Me.SubItems.Add(String.Format("Exceptions: {0}", item.Exceptions.Count))

        End Select

    End Sub

    Public ReadOnly Property Frame() As ID3Frame
        Get
            Return p_Frame
        End Get
    End Property

End Class
