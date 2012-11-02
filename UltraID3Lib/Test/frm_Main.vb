Imports HundredMilesSoftware.UltraID3Lib
Imports System.IO
Imports System.Text

Public Class frm_Main
    Inherits System.Windows.Forms.Form

    Private m_UltraID3 As New UltraID3
    Private m_CurrentPictureFrame As ID3PictureFrame
    Private m_PictureTypes As ArrayList
    Private m_FileName As String
    Private m_PictureFrames As ID3FrameCollection
    Private m_PictureIndex As Integer

    Private c_TabFormatText_Frames As String = "Frames - {0}"
    Private c_TabFormatText_Pictures As String = "Pictures - {0}"
    Private c_TabFormatText_Errors As String = "Errors - {0}"
    Private c_TabFormatText_Warnings As String = "Warnings - {0}"
    Private c_AppTitleFormat As String = "UltraID3Lib Test Harness - {0}"

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        InitGenreComboBoxes()
        InitFramesListView()

    End Sub

    Private Sub ReadTrack(ByVal trackFileName As String)

        Me.Text = String.Format(c_AppTitleFormat, trackFileName)

        ReadTag(trackFileName)

        LoadPicture()

        m_FileName = trackFileName

    End Sub

    Private Sub SetWriteTagCheckBoxes()

        With m_UltraID3
            chk_WriteID3v1Tag.Checked = .ID3v1Tag.WriteFlag
            chk_WriteID3v2Tag.Checked = .ID3v23Tag.WriteFlag
        End With

    End Sub

    Private Sub SetWriteTagFields()

        With m_UltraID3
            .ID3v1Tag.WriteFlag = chk_WriteID3v1Tag.Checked
            .ID3v23Tag.WriteFlag = chk_WriteID3v2Tag.Checked
        End With

    End Sub

    Private Sub SetV1TagControls()

        With m_UltraID3.ID3v1Tag
            txt_AlbumV1.Text = .Album
            txt_ArtistV1.Text = .Artist
            txt_CommentsV1.Text = .Comments
            cmb_GenreV1.SelectedValue = CInt(.Genre) 'CInt is necessary for some reason
            txt_TitleV1.Text = .Title
            txt_TrackNumV1.Text = .TrackNum.ToString
            txt_YearV1.Text = .Year.ToString
        End With

    End Sub

    Private Sub SetV2TagControls()

        With m_UltraID3.ID3v23Tag
            txt_ArtistV2.Text = .Artist
            txt_AlbumV2.Text = UltraID3.GetCustomEncodedText(.Album, Encoding.GetEncoding(28591), Encoding.GetEncoding(1257))
            txt_CommentsV2.Text = .Comments
            cmb_GenreV2.Text = .Genre
            txt_TitleV2.Text = .Title
            txt_TrackNumV2.Text = .TrackNum.ToString
            txt_TrackCountV2.Text = .TrackCount.ToString
            txt_YearV2.Text = .Year.ToString
            chk_IsCoverV2.Checked = .IsCover
            chk_IsRemixV2.Checked = .IsRemix
        End With

    End Sub

    Private Sub SetMPEGTextBoxes()

        With m_UltraID3.FirstMPEGFrameInfo
            txt_BitRate.Text = .Bitrate.ToString
            txt_Frequency.Text = .Frequency.ToString
            txt_Duration.Text = .Duration.ToString
            txt_Level.Text = .Level.ToString
            txt_Layer.Text = .Layer.ToString
            txt_Mode.Text = .Mode.ToString
            txt_CopyrightFlag.Text = .CopyrightFlag.ToString
            txt_OriginalFlag.Text = .OriginalFlag.ToString
            txt_PrivateFlag.Text = .PrivateFlag.ToString
            txt_ProtectionFlag.Text = .ProtectionFlag.ToString

            If .VBRInfo.FoundFlag Then

                txt_VBR_HeaderFound.Text = "Yes"

                If .VBRInfo.Duration.HasValue Then
                    txt_VBR_Duration.Text = .VBRInfo.Duration.ToString
                Else
                    txt_VBR_Duration.Text = "N/A"
                End If

                If .VBRInfo.FrameCount.hasvalue Then
                    txt_VBR_FrameCount.Text = .VBRInfo.FrameCount.ToString
                Else
                    txt_VBR_FrameCount.Text = "N/A"
                End If

                If .VBRInfo.Size.HasValue Then
                    txt_VBR_Size.Text = .VBRInfo.Size.ToString
                Else
                    txt_VBR_Size.Text = "N/A"
                End If

                If .VBRInfo.QualityRating.HasValue Then
                    txt_VBR_QualityRating.Text = .VBRInfo.QualityRating.ToString
                Else
                    txt_VBR_QualityRating.Text = "N/A"
                End If

                If .VBRInfo.TableOfContentsExists Then
                    txt_VBR_TOCExists.Text = "Yes"
                Else
                    txt_VBR_TOCExists.Text = "No"
                End If

            Else
                txt_VBR_HeaderFound.Text = "No"
                txt_VBR_Duration.Text = "N/A"
                txt_VBR_FrameCount.Text = "N/A"
                txt_VBR_Size.Text = "N/A"
                txt_VBR_QualityRating.Text = "N/A"
                txt_VBR_TOCExists.Text = "N/A"
            End If

        End With

        txt_Size.Text = m_UltraID3.Size.ToString

    End Sub

    Private Sub WriteV1TagProperties()

        With m_UltraID3.ID3v1Tag

            If chk_WriteID3v1Tag.Checked Then

                .WriteFlag = True

                .Album = txt_AlbumV1.Text.Trim
                .Artist = txt_ArtistV1.Text.Trim
                .Comments = txt_CommentsV1.Text.Trim
                .Genre = CByte(cmb_GenreV1.SelectedValue)
                .Title = txt_TitleV1.Text.Trim
                .TrackNum = GetNullableByte(txt_TrackNumV1.Text)
                .Year = GetNullableShort(txt_YearV1.Text)

            Else

                .WriteFlag = False
                .Clear()

            End If

        End With

    End Sub

    Private Function GetNullableByte(ByVal value As String) As Nullable(Of Byte)

        If value <> String.Empty Then
            Return Byte.Parse(value)
        Else
            Return Nothing
        End If

    End Function

    Private Function GetNullableShort(ByVal value As String) As Nullable(Of Short)

        If value <> String.Empty Then
            Return Short.Parse(value)
        Else
            Return Nothing
        End If

    End Function

    Private Sub WriteV2TagProperties()

        With m_UltraID3.ID3v23Tag

            If chk_WriteID3v2Tag.Checked Then

                .WriteFlag = True

                .Album = UltraID3.GetCustomEncodedText(txt_AlbumV2.Text.Trim, Encoding.GetEncoding(1257), Encoding.GetEncoding(28591))
                .Artist = txt_ArtistV2.Text.Trim
                .Comments = txt_CommentsV2.Text.Trim
                .Genre = cmb_GenreV2.Text.Trim
                .Title = txt_TitleV2.Text.Trim
                .TrackNum = GetNullableShort(txt_TrackNumV2.Text)
                .TrackCount = GetNullableShort(txt_TrackCountV2.Text)
                .Year = GetNullableShort(txt_YearV2.Text)
                .IsCover = chk_IsCoverV2.Checked
                .IsRemix = chk_IsRemixV2.Checked

                m_UltraID3.ID3v23Tag.Frames.ReplaceFrames(m_PictureFrames, FrameTypes.Picture)

            Else

                .WriteFlag = False
                .Clear()

            End If

        End With

    End Sub

    Private Sub InitFramesListView()

        With lvw_Frames.Columns
            .Add("Frame Type", -2, HorizontalAlignment.Left)
            .Add("Frame Data", -2, HorizontalAlignment.Left)
            .Add("Frame Exception", -2, HorizontalAlignment.Left)
        End With

    End Sub

    Private Sub LoadFramesListView()

        tpg_Frames.Text = String.Format(c_TabFormatText_Frames, m_UltraID3.ID3v23Tag.Frames.Count)

        lvw_Frames.Items.Clear()

        txt_FrameCount.Text = CStr(m_UltraID3.ID3v23Tag.Frames.Count)

        Dim IndexID3Frame As ID3Frame

        For Each IndexID3Frame In m_UltraID3.ID3v23Tag.Frames

            Dim MyFrameListViewItem As New FrameListViewItem(IndexID3Frame)
            lvw_Frames.Items.Add(MyFrameListViewItem)

        Next

    End Sub

    Private Sub btn_Write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Write.Click

        If m_UltraID3 IsNot Nothing Then

            Try

                With m_UltraID3

                    WriteV1TagProperties()
                    WriteV2TagProperties()

                    .Write()

                End With

            Catch exc As Exception

                MsgBox(exc.Message)

            End Try
        Else

            btn_Write.Enabled = False

        End If

    End Sub

    Private Sub ReadTag(ByVal trackFileName As String)

        Try

            m_UltraID3.Read(trackFileName)

            Dim Errors As ID3MetaDataException() = m_UltraID3.GetExceptions(ID3ExceptionLevels.Error)
            Dim Warnings As ID3MetaDataException() = m_UltraID3.GetExceptions(ID3ExceptionLevels.Warning)

            tpg_Errors.Text = String.Format(c_TabFormatText_Errors, Errors.Length)
            tpg_Warnings.Text = String.Format(c_TabFormatText_Warnings, Warnings.Length)

            lst_Exceptions.Items.Clear()
            If Errors.Length > 0 Then
                lst_Exceptions.Items.AddRange(Errors)
            End If

            lst_Warnings.Items.Clear()
            If Warnings.Length > 0 Then
                lst_Warnings.Items.AddRange(Warnings)
            End If

            If Errors.Length > 0 Then
                tab_Tag.SelectedTab = tpg_Errors
            ElseIf Warnings.Length > 0 Then
                tab_Tag.SelectedTab = tpg_Warnings
            End If

            btn_Write.Enabled = True
            tab_Tag.Enabled = True
            SetWriteTagCheckBoxes()
            SetV1TagControls()
            SetV2TagControls()
            SetMPEGTextBoxes()
            LoadFramesListView()

        Catch exc As Exception

            MsgBox(exc.Message)

        End Try

    End Sub

    Private Sub LoadPicture()

        m_PictureFrames = m_UltraID3.ID3v23Tag.Frames.GetFrames(MultipleInstanceFrameTypes.Picture)

        m_PictureTypes = HundredMilesSoftware.UltraID3Lib.ID3PictureFrame.PictureTypeList
        lst_PictureType.DataSource = m_PictureTypes

        m_PictureIndex = -1

        tpg_Pictures.Text = String.Format(c_TabFormatText_Pictures, m_PictureFrames.Count)

        If m_PictureFrames.Count > 0 Then
            m_PictureIndex = 0
        End If

        EnablePictureButtons()

    End Sub

    Private Sub EnablePictureButtons()

        Dim PictureFrameCount As Integer = m_PictureFrames.Count

        If PictureFrameCount > 0 Then

            m_CurrentPictureFrame = CType(m_PictureFrames.Item(m_PictureIndex), ID3PictureFrame)

            With m_CurrentPictureFrame

                If m_CurrentPictureFrame.Picture IsNot Nothing Then
                    pbx_Picture.Image = m_CurrentPictureFrame.Picture
                End If

                lst_PictureType.DataBindings.Clear()
                lst_PictureType.DataBindings.Add("SelectedValue", m_CurrentPictureFrame, "Type")

                txt_PictureDescription.DataBindings.Clear()
                txt_PictureDescription.DataBindings.Add("Text", m_CurrentPictureFrame, "Description")

            End With

            btn_DeletePicture.Enabled = True

            If PictureFrameCount > 1 Then

                If m_PictureIndex = 0 Then
                    btn_Prev.Enabled = False
                Else
                    btn_Prev.Enabled = True
                End If

                If m_PictureIndex = PictureFrameCount - 1 Then
                    btn_Next.Enabled = False
                Else
                    btn_Next.Enabled = True
                End If

            Else

                btn_Prev.Enabled = False
                btn_Next.Enabled = False

            End If

        Else

            pbx_Picture.Image = Nothing
            btn_DeletePicture.Enabled = False

        End If

    End Sub

    Private Sub chk_WriteID3v1Tag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_WriteID3v1Tag.CheckedChanged

        grp_ID3v1.Enabled = chk_WriteID3v1Tag.Checked

    End Sub

    Private Sub chk_WriteID3v2Tag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_WriteID3v2Tag.CheckedChanged

        grp_ID3v2.Enabled = chk_WriteID3v2Tag.Checked

    End Sub

    Private Sub InitGenreComboBoxes()

        cmb_GenreV1.DataSource = m_UltraID3.GenreInfos

        'The Genres have to be added to the V2 ComboBox because when it's bound to Genres and the GenreV2 does not match a defined Genre, the SelectedValue is set to "[Unknown]"
        For Each IndexGenreInfo As GenreInfo In m_UltraID3.GenreInfos
            If IndexGenreInfo.Number <> 255 Then
                cmb_GenreV2.Items.Add(IndexGenreInfo.Name)
            End If
        Next

    End Sub

    Private Function GetReadOnlyAttribute(ByVal FileName As String) As Boolean

        Dim MyFileAttributes As FileAttributes = System.IO.File.GetAttributes(FileName)
        Return ((MyFileAttributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly)

    End Function

    Private Sub SetReadOnlyAttribute(ByVal FileName As String, ByVal ReadOnlyFlag As Boolean)

        Dim MyFileAttributes As FileAttributes = System.IO.File.GetAttributes(FileName)

        If ReadOnlyFlag Then
            System.IO.File.SetAttributes(FileName, MyFileAttributes Or FileAttributes.ReadOnly)
        Else
            System.IO.File.SetAttributes(FileName, MyFileAttributes And Not FileAttributes.ReadOnly)
        End If

    End Sub

    Private Sub btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Prev.Click

        m_PictureIndex -= 1
        EnablePictureButtons()

    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        m_PictureIndex += 1
        EnablePictureButtons()

    End Sub

    Private Function GetMenuItemControl(ByVal MenuItemObject As Object) As Control

        Dim SenderMenuItem As MenuItem = CType(MenuItemObject, MenuItem)
        Dim SenderContextMenu As ContextMenu = CType(SenderMenuItem.Parent, ContextMenu)
        Dim SenderControl As Control = CType(SenderContextMenu.SourceControl, Control)

        Return SenderControl

    End Function

    Private Sub btn_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Load.Click

        With OpenFileDialog1
            .Filter = "MP3 Files|*.mp3"
            .Title = "Please select an MP3 file to open"
            .ShowDialog()
        End With

        Dim TrackFileName As String = OpenFileDialog1.FileName

        ReadTrack(TrackFileName)

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click

        Close()

    End Sub

    Private Sub btn_AddPictures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddPictures.Click

        With OpenFileDialog1
            .Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG"
            .Title = "Please select an image file to add"
            .ShowDialog()
        End With

        Dim PictureFileName As String = OpenFileDialog1.FileName

        Dim NewPicture As New Bitmap(PictureFileName)

        Dim PictureFrame As New ID3PictureFrame(NewPicture, PictureTypes.Other, String.Empty, TextEncodingTypes.Unicode)
        m_UltraID3.ID3v23Tag.Frames.Add(PictureFrame)

        LoadPicture()
        LoadFramesListView()

    End Sub

    Private Sub btn_DeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeletePicture.Click

        Dim ImageIndex As Integer = 0

        For FrameIndex As Integer = 0 To m_UltraID3.ID3v23Tag.Frames.Count - 1
            If m_UltraID3.ID3v23Tag.Frames.Item(FrameIndex).FrameType = FrameTypes.Picture Then
                If ImageIndex = m_PictureIndex Then
                    m_UltraID3.ID3v23Tag.Frames.RemoveAt(FrameIndex)
                    Exit For
                Else
                    ImageIndex += 1
                End If
            End If
        Next

        LoadPicture()
        LoadFramesListView()

    End Sub

    Private Sub btn_GetFrameCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GetFrameCount.Click

        MsgBox(m_UltraID3.GetMPEGTrackInfo.ToString)

    End Sub

    Private Sub DeleteFrameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFrameToolStripMenuItem.Click

        For Each IndexListViewItem As ListViewItem In lvw_Frames.SelectedItems

            Dim MyFrameListViewItem As FrameListViewItem = CType(IndexListViewItem, FrameListViewItem)

            'Remove the Frame from the Tag
            m_UltraID3.ID3v23Tag.Frames.Remove(MyFrameListViewItem.Frame)

        Next

    End Sub


    Private Sub btn_GetDurations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GetDurations.Click

        Dim MyTrackInfo As MPEGTrackInfo = m_UltraID3.GetMPEGTrackInfo
        MsgBox(MyTrackInfo.Duration)

        Dim MyFrameInfo As MPEGFrameInfo = m_UltraID3.FirstMPEGFrameInfo
        MsgBox(MyFrameInfo.Duration)

        MsgBox(m_UltraID3.Duration)

    End Sub

End Class
