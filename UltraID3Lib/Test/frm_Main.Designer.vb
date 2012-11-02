Partial Public Class frm_Main

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tab_Tag As System.Windows.Forms.TabControl
    Friend WithEvents tpg_Fields As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ProtectionFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_PrivateFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_OriginalFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_CopyrightFlag As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_Level As System.Windows.Forms.TextBox
    Friend WithEvents txt_Frequency As System.Windows.Forms.TextBox
    Friend WithEvents txt_Size As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_Duration As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_BitRate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Mode As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Layer As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents grp_ID3v2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_IsCoverV2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_IsRemixV2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_TrackCountV2 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_GenreV2 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_TrackNumV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_AlbumV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CommentsV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TitleV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ArtistV2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_YearV2 As System.Windows.Forms.TextBox
    Friend WithEvents grp_ID3v1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_GenreV1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_YearV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_AlbumV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ArtistV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CommentsV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TrackNumV1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TitleV1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_WriteID3v1Tag As System.Windows.Forms.CheckBox
    Friend WithEvents chk_WriteID3v2Tag As System.Windows.Forms.CheckBox
    Friend WithEvents tpg_Pictures As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lst_PictureType As System.Windows.Forms.ListBox
    Friend WithEvents txt_PictureDescription As System.Windows.Forms.TextBox
    Friend WithEvents btn_Prev As System.Windows.Forms.Button
    Friend WithEvents btn_Next As System.Windows.Forms.Button
    Friend WithEvents btn_DeletePicture As System.Windows.Forms.Button
    Friend WithEvents btn_AddPictures As System.Windows.Forms.Button
    Friend WithEvents pbx_Picture As System.Windows.Forms.PictureBox
    Friend WithEvents tpg_Frames As System.Windows.Forms.TabPage
    Friend WithEvents lvw_Frames As System.Windows.Forms.ListView
    Friend WithEvents txt_FrameCount As System.Windows.Forms.TextBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Write As System.Windows.Forms.Button
    Friend WithEvents btn_Load As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_GetFrameCount As System.Windows.Forms.Button
    Friend WithEvents tpg_Errors As System.Windows.Forms.TabPage
    Friend WithEvents tpg_Warnings As System.Windows.Forms.TabPage
    Friend WithEvents lst_Exceptions As System.Windows.Forms.ListBox
    Friend WithEvents lst_Warnings As System.Windows.Forms.ListBox
    Friend WithEvents grp_VBRInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txt_VBR_Duration As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txt_VBR_TOCExists As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txt_VBR_HeaderFound As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txt_VBR_FrameCount As System.Windows.Forms.TextBox
    Friend WithEvents txt_VBR_QualityRating As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_VBR_Size As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tab_Tag = New System.Windows.Forms.TabControl
        Me.tpg_Fields = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_GetDurations = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_ProtectionFlag = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_PrivateFlag = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_OriginalFlag = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_CopyrightFlag = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_Level = New System.Windows.Forms.TextBox
        Me.txt_Frequency = New System.Windows.Forms.TextBox
        Me.txt_Size = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_Duration = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_BitRate = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_Mode = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_Layer = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.grp_VBRInfo = New System.Windows.Forms.GroupBox
        Me.txt_VBR_Duration = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txt_VBR_TOCExists = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txt_VBR_HeaderFound = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txt_VBR_FrameCount = New System.Windows.Forms.TextBox
        Me.txt_VBR_QualityRating = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_VBR_Size = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.btn_GetFrameCount = New System.Windows.Forms.Button
        Me.grp_ID3v2 = New System.Windows.Forms.GroupBox
        Me.chk_IsCoverV2 = New System.Windows.Forms.CheckBox
        Me.chk_IsRemixV2 = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_TrackCountV2 = New System.Windows.Forms.TextBox
        Me.cmb_GenreV2 = New System.Windows.Forms.ComboBox
        Me.txt_TrackNumV2 = New System.Windows.Forms.TextBox
        Me.txt_AlbumV2 = New System.Windows.Forms.TextBox
        Me.txt_CommentsV2 = New System.Windows.Forms.TextBox
        Me.txt_TitleV2 = New System.Windows.Forms.TextBox
        Me.txt_ArtistV2 = New System.Windows.Forms.TextBox
        Me.txt_YearV2 = New System.Windows.Forms.TextBox
        Me.grp_ID3v1 = New System.Windows.Forms.GroupBox
        Me.cmb_GenreV1 = New System.Windows.Forms.ComboBox
        Me.txt_YearV1 = New System.Windows.Forms.TextBox
        Me.txt_AlbumV1 = New System.Windows.Forms.TextBox
        Me.txt_ArtistV1 = New System.Windows.Forms.TextBox
        Me.txt_CommentsV1 = New System.Windows.Forms.TextBox
        Me.txt_TrackNumV1 = New System.Windows.Forms.TextBox
        Me.txt_TitleV1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_WriteID3v1Tag = New System.Windows.Forms.CheckBox
        Me.chk_WriteID3v2Tag = New System.Windows.Forms.CheckBox
        Me.tpg_Pictures = New System.Windows.Forms.TabPage
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lst_PictureType = New System.Windows.Forms.ListBox
        Me.txt_PictureDescription = New System.Windows.Forms.TextBox
        Me.btn_Prev = New System.Windows.Forms.Button
        Me.btn_Next = New System.Windows.Forms.Button
        Me.btn_DeletePicture = New System.Windows.Forms.Button
        Me.btn_AddPictures = New System.Windows.Forms.Button
        Me.pbx_Picture = New System.Windows.Forms.PictureBox
        Me.tpg_Frames = New System.Windows.Forms.TabPage
        Me.lvw_Frames = New System.Windows.Forms.ListView
        Me.cms_Frames = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txt_FrameCount = New System.Windows.Forms.TextBox
        Me.tpg_Errors = New System.Windows.Forms.TabPage
        Me.lst_Exceptions = New System.Windows.Forms.ListBox
        Me.tpg_Warnings = New System.Windows.Forms.TabPage
        Me.lst_Warnings = New System.Windows.Forms.ListBox
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Write = New System.Windows.Forms.Button
        Me.btn_Load = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.tab_Tag.SuspendLayout()
        Me.tpg_Fields.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_VBRInfo.SuspendLayout()
        Me.grp_ID3v2.SuspendLayout()
        Me.grp_ID3v1.SuspendLayout()
        Me.tpg_Pictures.SuspendLayout()
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpg_Frames.SuspendLayout()
        Me.cms_Frames.SuspendLayout()
        Me.tpg_Errors.SuspendLayout()
        Me.tpg_Warnings.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Tag
        '
        Me.tab_Tag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Tag.Controls.Add(Me.tpg_Fields)
        Me.tab_Tag.Controls.Add(Me.tpg_Pictures)
        Me.tab_Tag.Controls.Add(Me.tpg_Frames)
        Me.tab_Tag.Controls.Add(Me.tpg_Errors)
        Me.tab_Tag.Controls.Add(Me.tpg_Warnings)
        Me.tab_Tag.Enabled = False
        Me.tab_Tag.Location = New System.Drawing.Point(8, 8)
        Me.tab_Tag.MinimumSize = New System.Drawing.Size(656, 544)
        Me.tab_Tag.Name = "tab_Tag"
        Me.tab_Tag.SelectedIndex = 0
        Me.tab_Tag.Size = New System.Drawing.Size(656, 544)
        Me.tab_Tag.TabIndex = 24
        '
        'tpg_Fields
        '
        Me.tpg_Fields.Controls.Add(Me.GroupBox1)
        Me.tpg_Fields.Controls.Add(Me.grp_ID3v2)
        Me.tpg_Fields.Controls.Add(Me.grp_ID3v1)
        Me.tpg_Fields.Controls.Add(Me.Label8)
        Me.tpg_Fields.Controls.Add(Me.Label7)
        Me.tpg_Fields.Controls.Add(Me.Label6)
        Me.tpg_Fields.Controls.Add(Me.Label5)
        Me.tpg_Fields.Controls.Add(Me.Label3)
        Me.tpg_Fields.Controls.Add(Me.Label2)
        Me.tpg_Fields.Controls.Add(Me.Label1)
        Me.tpg_Fields.Controls.Add(Me.chk_WriteID3v1Tag)
        Me.tpg_Fields.Controls.Add(Me.chk_WriteID3v2Tag)
        Me.tpg_Fields.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Fields.Name = "tpg_Fields"
        Me.tpg_Fields.Size = New System.Drawing.Size(648, 518)
        Me.tpg_Fields.TabIndex = 0
        Me.tpg_Fields.Text = "Fields"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_GetDurations)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.grp_VBRInfo)
        Me.GroupBox1.Controls.Add(Me.btn_GetFrameCount)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 240)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MPEG/VBR"
        '
        'btn_GetDurations
        '
        Me.btn_GetDurations.Location = New System.Drawing.Point(377, 93)
        Me.btn_GetDurations.Name = "btn_GetDurations"
        Me.btn_GetDurations.Size = New System.Drawing.Size(134, 51)
        Me.btn_GetDurations.TabIndex = 61
        Me.btn_GetDurations.Text = "Button2"
        Me.btn_GetDurations.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ProtectionFlag)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_PrivateFlag)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_OriginalFlag)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_CopyrightFlag)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txt_Level)
        Me.GroupBox3.Controls.Add(Me.txt_Frequency)
        Me.GroupBox3.Controls.Add(Me.txt_Size)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txt_Duration)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txt_BitRate)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_Mode)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txt_Layer)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 208)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MPEG"
        '
        'txt_ProtectionFlag
        '
        Me.txt_ProtectionFlag.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_ProtectionFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ProtectionFlag.Location = New System.Drawing.Point(104, 184)
        Me.txt_ProtectionFlag.Name = "txt_ProtectionFlag"
        Me.txt_ProtectionFlag.ReadOnly = True
        Me.txt_ProtectionFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_ProtectionFlag.TabIndex = 58
        Me.txt_ProtectionFlag.TabStop = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Protection (CRC):"
        '
        'txt_PrivateFlag
        '
        Me.txt_PrivateFlag.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_PrivateFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PrivateFlag.Location = New System.Drawing.Point(104, 168)
        Me.txt_PrivateFlag.Name = "txt_PrivateFlag"
        Me.txt_PrivateFlag.ReadOnly = True
        Me.txt_PrivateFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_PrivateFlag.TabIndex = 56
        Me.txt_PrivateFlag.TabStop = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Private:"
        '
        'txt_OriginalFlag
        '
        Me.txt_OriginalFlag.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_OriginalFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_OriginalFlag.Location = New System.Drawing.Point(104, 152)
        Me.txt_OriginalFlag.Name = "txt_OriginalFlag"
        Me.txt_OriginalFlag.ReadOnly = True
        Me.txt_OriginalFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_OriginalFlag.TabIndex = 54
        Me.txt_OriginalFlag.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Original:"
        '
        'txt_CopyrightFlag
        '
        Me.txt_CopyrightFlag.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_CopyrightFlag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_CopyrightFlag.Location = New System.Drawing.Point(104, 136)
        Me.txt_CopyrightFlag.Name = "txt_CopyrightFlag"
        Me.txt_CopyrightFlag.ReadOnly = True
        Me.txt_CopyrightFlag.Size = New System.Drawing.Size(88, 13)
        Me.txt_CopyrightFlag.TabIndex = 52
        Me.txt_CopyrightFlag.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Copyrighted:"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 104)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Mode:"
        '
        'txt_Level
        '
        Me.txt_Level.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Level.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Level.Location = New System.Drawing.Point(104, 24)
        Me.txt_Level.Name = "txt_Level"
        Me.txt_Level.ReadOnly = True
        Me.txt_Level.Size = New System.Drawing.Size(88, 13)
        Me.txt_Level.TabIndex = 34
        Me.txt_Level.TabStop = False
        '
        'txt_Frequency
        '
        Me.txt_Frequency.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Frequency.Location = New System.Drawing.Point(104, 72)
        Me.txt_Frequency.Name = "txt_Frequency"
        Me.txt_Frequency.ReadOnly = True
        Me.txt_Frequency.Size = New System.Drawing.Size(88, 13)
        Me.txt_Frequency.TabIndex = 37
        Me.txt_Frequency.TabStop = False
        '
        'txt_Size
        '
        Me.txt_Size.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Size.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Size.Location = New System.Drawing.Point(104, 120)
        Me.txt_Size.Name = "txt_Size"
        Me.txt_Size.ReadOnly = True
        Me.txt_Size.Size = New System.Drawing.Size(88, 13)
        Me.txt_Size.TabIndex = 40
        Me.txt_Size.TabStop = False
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Duration:"
        '
        'txt_Duration
        '
        Me.txt_Duration.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Duration.Location = New System.Drawing.Point(104, 88)
        Me.txt_Duration.Name = "txt_Duration"
        Me.txt_Duration.ReadOnly = True
        Me.txt_Duration.Size = New System.Drawing.Size(88, 13)
        Me.txt_Duration.TabIndex = 38
        Me.txt_Duration.TabStop = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Frequency:"
        '
        'txt_BitRate
        '
        Me.txt_BitRate.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_BitRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BitRate.Location = New System.Drawing.Point(104, 56)
        Me.txt_BitRate.Name = "txt_BitRate"
        Me.txt_BitRate.ReadOnly = True
        Me.txt_BitRate.Size = New System.Drawing.Size(88, 13)
        Me.txt_BitRate.TabIndex = 36
        Me.txt_BitRate.TabStop = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Level:"
        '
        'txt_Mode
        '
        Me.txt_Mode.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Mode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Mode.Location = New System.Drawing.Point(104, 104)
        Me.txt_Mode.Name = "txt_Mode"
        Me.txt_Mode.ReadOnly = True
        Me.txt_Mode.Size = New System.Drawing.Size(88, 13)
        Me.txt_Mode.TabIndex = 39
        Me.txt_Mode.TabStop = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Bit Rate:"
        '
        'txt_Layer
        '
        Me.txt_Layer.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_Layer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Layer.Location = New System.Drawing.Point(104, 40)
        Me.txt_Layer.Name = "txt_Layer"
        Me.txt_Layer.ReadOnly = True
        Me.txt_Layer.Size = New System.Drawing.Size(88, 13)
        Me.txt_Layer.TabIndex = 35
        Me.txt_Layer.TabStop = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Layer:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Size:"
        '
        'grp_VBRInfo
        '
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_Duration)
        Me.grp_VBRInfo.Controls.Add(Me.Label39)
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_TOCExists)
        Me.grp_VBRInfo.Controls.Add(Me.Label38)
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_HeaderFound)
        Me.grp_VBRInfo.Controls.Add(Me.Label37)
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_FrameCount)
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_QualityRating)
        Me.grp_VBRInfo.Controls.Add(Me.Label34)
        Me.grp_VBRInfo.Controls.Add(Me.Label35)
        Me.grp_VBRInfo.Controls.Add(Me.txt_VBR_Size)
        Me.grp_VBRInfo.Controls.Add(Me.Label36)
        Me.grp_VBRInfo.Location = New System.Drawing.Point(224, 24)
        Me.grp_VBRInfo.Name = "grp_VBRInfo"
        Me.grp_VBRInfo.Size = New System.Drawing.Size(144, 136)
        Me.grp_VBRInfo.TabIndex = 58
        Me.grp_VBRInfo.TabStop = False
        Me.grp_VBRInfo.Text = "Variable Bit Rate Info"
        '
        'txt_VBR_Duration
        '
        Me.txt_VBR_Duration.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_Duration.Location = New System.Drawing.Point(88, 40)
        Me.txt_VBR_Duration.Name = "txt_VBR_Duration"
        Me.txt_VBR_Duration.ReadOnly = True
        Me.txt_VBR_Duration.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_Duration.TabIndex = 54
        Me.txt_VBR_Duration.TabStop = False
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 16)
        Me.Label39.TabIndex = 55
        Me.Label39.Text = "Duration:"
        '
        'txt_VBR_TOCExists
        '
        Me.txt_VBR_TOCExists.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_TOCExists.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_TOCExists.Location = New System.Drawing.Point(88, 104)
        Me.txt_VBR_TOCExists.Name = "txt_VBR_TOCExists"
        Me.txt_VBR_TOCExists.ReadOnly = True
        Me.txt_VBR_TOCExists.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_TOCExists.TabIndex = 52
        Me.txt_VBR_TOCExists.TabStop = False
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(8, 104)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 16)
        Me.Label38.TabIndex = 53
        Me.Label38.Text = "TOC Exists?:"
        '
        'txt_VBR_HeaderFound
        '
        Me.txt_VBR_HeaderFound.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_HeaderFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_HeaderFound.Location = New System.Drawing.Point(88, 24)
        Me.txt_VBR_HeaderFound.Name = "txt_VBR_HeaderFound"
        Me.txt_VBR_HeaderFound.ReadOnly = True
        Me.txt_VBR_HeaderFound.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_HeaderFound.TabIndex = 50
        Me.txt_VBR_HeaderFound.TabStop = False
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(8, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 16)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "Header Found:"
        '
        'txt_VBR_FrameCount
        '
        Me.txt_VBR_FrameCount.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_FrameCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_FrameCount.Location = New System.Drawing.Point(88, 56)
        Me.txt_VBR_FrameCount.Name = "txt_VBR_FrameCount"
        Me.txt_VBR_FrameCount.ReadOnly = True
        Me.txt_VBR_FrameCount.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_FrameCount.TabIndex = 44
        Me.txt_VBR_FrameCount.TabStop = False
        '
        'txt_VBR_QualityRating
        '
        Me.txt_VBR_QualityRating.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_QualityRating.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_QualityRating.Location = New System.Drawing.Point(88, 88)
        Me.txt_VBR_QualityRating.Name = "txt_VBR_QualityRating"
        Me.txt_VBR_QualityRating.ReadOnly = True
        Me.txt_VBR_QualityRating.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_QualityRating.TabIndex = 46
        Me.txt_VBR_QualityRating.TabStop = False
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 16)
        Me.Label34.TabIndex = 47
        Me.Label34.Text = "Frame Count:"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 16)
        Me.Label35.TabIndex = 49
        Me.Label35.Text = "Quality Rating:"
        '
        'txt_VBR_Size
        '
        Me.txt_VBR_Size.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_VBR_Size.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_VBR_Size.Location = New System.Drawing.Point(88, 72)
        Me.txt_VBR_Size.Name = "txt_VBR_Size"
        Me.txt_VBR_Size.ReadOnly = True
        Me.txt_VBR_Size.Size = New System.Drawing.Size(48, 13)
        Me.txt_VBR_Size.TabIndex = 45
        Me.txt_VBR_Size.TabStop = False
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 72)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 16)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = "Size (Bytes):"
        '
        'btn_GetFrameCount
        '
        Me.btn_GetFrameCount.Location = New System.Drawing.Point(376, 32)
        Me.btn_GetFrameCount.Name = "btn_GetFrameCount"
        Me.btn_GetFrameCount.Size = New System.Drawing.Size(136, 48)
        Me.btn_GetFrameCount.TabIndex = 60
        Me.btn_GetFrameCount.Text = "Get MPEG Track Info"
        '
        'grp_ID3v2
        '
        Me.grp_ID3v2.Controls.Add(Me.chk_IsCoverV2)
        Me.grp_ID3v2.Controls.Add(Me.chk_IsRemixV2)
        Me.grp_ID3v2.Controls.Add(Me.Label13)
        Me.grp_ID3v2.Controls.Add(Me.txt_TrackCountV2)
        Me.grp_ID3v2.Controls.Add(Me.cmb_GenreV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_TrackNumV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_AlbumV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_CommentsV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_TitleV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_ArtistV2)
        Me.grp_ID3v2.Controls.Add(Me.txt_YearV2)
        Me.grp_ID3v2.Enabled = False
        Me.grp_ID3v2.Location = New System.Drawing.Point(304, 32)
        Me.grp_ID3v2.Name = "grp_ID3v2"
        Me.grp_ID3v2.Size = New System.Drawing.Size(336, 232)
        Me.grp_ID3v2.TabIndex = 0
        Me.grp_ID3v2.TabStop = False
        Me.grp_ID3v2.Text = "ID3v2"
        '
        'chk_IsCoverV2
        '
        Me.chk_IsCoverV2.Location = New System.Drawing.Point(152, 144)
        Me.chk_IsCoverV2.Name = "chk_IsCoverV2"
        Me.chk_IsCoverV2.Size = New System.Drawing.Size(64, 16)
        Me.chk_IsCoverV2.TabIndex = 9
        Me.chk_IsCoverV2.Text = "Cover?"
        '
        'chk_IsRemixV2
        '
        Me.chk_IsRemixV2.Location = New System.Drawing.Point(232, 144)
        Me.chk_IsRemixV2.Name = "chk_IsRemixV2"
        Me.chk_IsRemixV2.Size = New System.Drawing.Size(64, 16)
        Me.chk_IsRemixV2.TabIndex = 8
        Me.chk_IsRemixV2.Text = "Remix?"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(64, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "of"
        '
        'txt_TrackCountV2
        '
        Me.txt_TrackCountV2.Location = New System.Drawing.Point(88, 72)
        Me.txt_TrackCountV2.Name = "txt_TrackCountV2"
        Me.txt_TrackCountV2.Size = New System.Drawing.Size(48, 20)
        Me.txt_TrackCountV2.TabIndex = 3
        '
        'cmb_GenreV2
        '
        Me.cmb_GenreV2.Location = New System.Drawing.Point(8, 144)
        Me.cmb_GenreV2.Name = "cmb_GenreV2"
        Me.cmb_GenreV2.Size = New System.Drawing.Size(128, 21)
        Me.cmb_GenreV2.TabIndex = 6
        '
        'txt_TrackNumV2
        '
        Me.txt_TrackNumV2.Location = New System.Drawing.Point(8, 72)
        Me.txt_TrackNumV2.Name = "txt_TrackNumV2"
        Me.txt_TrackNumV2.Size = New System.Drawing.Size(48, 20)
        Me.txt_TrackNumV2.TabIndex = 2
        '
        'txt_AlbumV2
        '
        Me.txt_AlbumV2.Location = New System.Drawing.Point(8, 96)
        Me.txt_AlbumV2.Name = "txt_AlbumV2"
        Me.txt_AlbumV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_AlbumV2.TabIndex = 4
        '
        'txt_CommentsV2
        '
        Me.txt_CommentsV2.Location = New System.Drawing.Point(8, 168)
        Me.txt_CommentsV2.Multiline = True
        Me.txt_CommentsV2.Name = "txt_CommentsV2"
        Me.txt_CommentsV2.Size = New System.Drawing.Size(320, 56)
        Me.txt_CommentsV2.TabIndex = 7
        '
        'txt_TitleV2
        '
        Me.txt_TitleV2.Location = New System.Drawing.Point(8, 48)
        Me.txt_TitleV2.Name = "txt_TitleV2"
        Me.txt_TitleV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_TitleV2.TabIndex = 1
        '
        'txt_ArtistV2
        '
        Me.txt_ArtistV2.Location = New System.Drawing.Point(8, 24)
        Me.txt_ArtistV2.Name = "txt_ArtistV2"
        Me.txt_ArtistV2.Size = New System.Drawing.Size(320, 20)
        Me.txt_ArtistV2.TabIndex = 0
        '
        'txt_YearV2
        '
        Me.txt_YearV2.Location = New System.Drawing.Point(8, 120)
        Me.txt_YearV2.Name = "txt_YearV2"
        Me.txt_YearV2.Size = New System.Drawing.Size(100, 20)
        Me.txt_YearV2.TabIndex = 5
        '
        'grp_ID3v1
        '
        Me.grp_ID3v1.Controls.Add(Me.cmb_GenreV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_YearV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_AlbumV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_ArtistV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_CommentsV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_TrackNumV1)
        Me.grp_ID3v1.Controls.Add(Me.txt_TitleV1)
        Me.grp_ID3v1.Enabled = False
        Me.grp_ID3v1.Location = New System.Drawing.Point(80, 32)
        Me.grp_ID3v1.Name = "grp_ID3v1"
        Me.grp_ID3v1.Size = New System.Drawing.Size(216, 232)
        Me.grp_ID3v1.TabIndex = 6
        Me.grp_ID3v1.TabStop = False
        Me.grp_ID3v1.Text = "ID3v1"
        '
        'cmb_GenreV1
        '
        Me.cmb_GenreV1.DisplayMember = "Name"
        Me.cmb_GenreV1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GenreV1.Location = New System.Drawing.Point(8, 144)
        Me.cmb_GenreV1.Name = "cmb_GenreV1"
        Me.cmb_GenreV1.Size = New System.Drawing.Size(128, 21)
        Me.cmb_GenreV1.TabIndex = 5
        Me.cmb_GenreV1.ValueMember = "Number"
        '
        'txt_YearV1
        '
        Me.txt_YearV1.Location = New System.Drawing.Point(8, 120)
        Me.txt_YearV1.MaxLength = 4
        Me.txt_YearV1.Name = "txt_YearV1"
        Me.txt_YearV1.Size = New System.Drawing.Size(100, 20)
        Me.txt_YearV1.TabIndex = 4
        '
        'txt_AlbumV1
        '
        Me.txt_AlbumV1.Location = New System.Drawing.Point(8, 96)
        Me.txt_AlbumV1.MaxLength = 30
        Me.txt_AlbumV1.Name = "txt_AlbumV1"
        Me.txt_AlbumV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_AlbumV1.TabIndex = 3
        '
        'txt_ArtistV1
        '
        Me.txt_ArtistV1.Location = New System.Drawing.Point(8, 24)
        Me.txt_ArtistV1.MaxLength = 30
        Me.txt_ArtistV1.Name = "txt_ArtistV1"
        Me.txt_ArtistV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_ArtistV1.TabIndex = 0
        '
        'txt_CommentsV1
        '
        Me.txt_CommentsV1.Location = New System.Drawing.Point(8, 168)
        Me.txt_CommentsV1.MaxLength = 30
        Me.txt_CommentsV1.Multiline = True
        Me.txt_CommentsV1.Name = "txt_CommentsV1"
        Me.txt_CommentsV1.Size = New System.Drawing.Size(200, 56)
        Me.txt_CommentsV1.TabIndex = 6
        '
        'txt_TrackNumV1
        '
        Me.txt_TrackNumV1.Location = New System.Drawing.Point(8, 72)
        Me.txt_TrackNumV1.MaxLength = 4
        Me.txt_TrackNumV1.Name = "txt_TrackNumV1"
        Me.txt_TrackNumV1.Size = New System.Drawing.Size(72, 20)
        Me.txt_TrackNumV1.TabIndex = 2
        '
        'txt_TitleV1
        '
        Me.txt_TitleV1.Location = New System.Drawing.Point(8, 48)
        Me.txt_TitleV1.MaxLength = 30
        Me.txt_TitleV1.Name = "txt_TitleV1"
        Me.txt_TitleV1.Size = New System.Drawing.Size(200, 20)
        Me.txt_TitleV1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Comments:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Genre:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Track:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Artist:"
        '
        'chk_WriteID3v1Tag
        '
        Me.chk_WriteID3v1Tag.Location = New System.Drawing.Point(80, 8)
        Me.chk_WriteID3v1Tag.Name = "chk_WriteID3v1Tag"
        Me.chk_WriteID3v1Tag.Size = New System.Drawing.Size(80, 18)
        Me.chk_WriteID3v1Tag.TabIndex = 5
        Me.chk_WriteID3v1Tag.Text = "ID3v1 Tag"
        '
        'chk_WriteID3v2Tag
        '
        Me.chk_WriteID3v2Tag.Location = New System.Drawing.Point(304, 8)
        Me.chk_WriteID3v2Tag.Name = "chk_WriteID3v2Tag"
        Me.chk_WriteID3v2Tag.Size = New System.Drawing.Size(80, 18)
        Me.chk_WriteID3v2Tag.TabIndex = 1
        Me.chk_WriteID3v2Tag.Text = "ID3v2 Tag"
        '
        'tpg_Pictures
        '
        Me.tpg_Pictures.Controls.Add(Me.Label14)
        Me.tpg_Pictures.Controls.Add(Me.Label9)
        Me.tpg_Pictures.Controls.Add(Me.lst_PictureType)
        Me.tpg_Pictures.Controls.Add(Me.txt_PictureDescription)
        Me.tpg_Pictures.Controls.Add(Me.btn_Prev)
        Me.tpg_Pictures.Controls.Add(Me.btn_Next)
        Me.tpg_Pictures.Controls.Add(Me.btn_DeletePicture)
        Me.tpg_Pictures.Controls.Add(Me.btn_AddPictures)
        Me.tpg_Pictures.Controls.Add(Me.pbx_Picture)
        Me.tpg_Pictures.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Pictures.Name = "tpg_Pictures"
        Me.tpg_Pictures.Size = New System.Drawing.Size(648, 518)
        Me.tpg_Pictures.TabIndex = 3
        Me.tpg_Pictures.Text = "Pictures"
        Me.tpg_Pictures.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(445, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Type"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Description"
        '
        'lst_PictureType
        '
        Me.lst_PictureType.DisplayMember = "Value"
        Me.lst_PictureType.Location = New System.Drawing.Point(448, 32)
        Me.lst_PictureType.Name = "lst_PictureType"
        Me.lst_PictureType.Size = New System.Drawing.Size(192, 277)
        Me.lst_PictureType.TabIndex = 40
        Me.lst_PictureType.ValueMember = "Key"
        '
        'txt_PictureDescription
        '
        Me.txt_PictureDescription.Location = New System.Drawing.Point(288, 32)
        Me.txt_PictureDescription.Multiline = True
        Me.txt_PictureDescription.Name = "txt_PictureDescription"
        Me.txt_PictureDescription.Size = New System.Drawing.Size(152, 144)
        Me.txt_PictureDescription.TabIndex = 38
        '
        'btn_Prev
        '
        Me.btn_Prev.Enabled = False
        Me.btn_Prev.Location = New System.Drawing.Point(152, 288)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(56, 24)
        Me.btn_Prev.TabIndex = 37
        Me.btn_Prev.Text = "<"
        '
        'btn_Next
        '
        Me.btn_Next.Enabled = False
        Me.btn_Next.Location = New System.Drawing.Point(216, 288)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(56, 24)
        Me.btn_Next.TabIndex = 36
        Me.btn_Next.Text = ">"
        '
        'btn_DeletePicture
        '
        Me.btn_DeletePicture.Enabled = False
        Me.btn_DeletePicture.Location = New System.Drawing.Point(72, 288)
        Me.btn_DeletePicture.Name = "btn_DeletePicture"
        Me.btn_DeletePicture.Size = New System.Drawing.Size(56, 23)
        Me.btn_DeletePicture.TabIndex = 35
        Me.btn_DeletePicture.Text = "Delete"
        '
        'btn_AddPictures
        '
        Me.btn_AddPictures.Location = New System.Drawing.Point(8, 288)
        Me.btn_AddPictures.Name = "btn_AddPictures"
        Me.btn_AddPictures.Size = New System.Drawing.Size(56, 23)
        Me.btn_AddPictures.TabIndex = 34
        Me.btn_AddPictures.Text = "Add"
        '
        'pbx_Picture
        '
        Me.pbx_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Picture.Location = New System.Drawing.Point(8, 8)
        Me.pbx_Picture.Name = "pbx_Picture"
        Me.pbx_Picture.Size = New System.Drawing.Size(264, 264)
        Me.pbx_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Picture.TabIndex = 33
        Me.pbx_Picture.TabStop = False
        '
        'tpg_Frames
        '
        Me.tpg_Frames.Controls.Add(Me.lvw_Frames)
        Me.tpg_Frames.Controls.Add(Me.txt_FrameCount)
        Me.tpg_Frames.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Frames.Name = "tpg_Frames"
        Me.tpg_Frames.Size = New System.Drawing.Size(648, 518)
        Me.tpg_Frames.TabIndex = 2
        Me.tpg_Frames.Text = "Frames"
        Me.tpg_Frames.Visible = False
        '
        'lvw_Frames
        '
        Me.lvw_Frames.ContextMenuStrip = Me.cms_Frames
        Me.lvw_Frames.FullRowSelect = True
        Me.lvw_Frames.Location = New System.Drawing.Point(8, 8)
        Me.lvw_Frames.Name = "lvw_Frames"
        Me.lvw_Frames.Size = New System.Drawing.Size(632, 504)
        Me.lvw_Frames.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvw_Frames.TabIndex = 2
        Me.lvw_Frames.UseCompatibleStateImageBehavior = False
        Me.lvw_Frames.View = System.Windows.Forms.View.Details
        '
        'cms_Frames
        '
        Me.cms_Frames.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFrameToolStripMenuItem})
        Me.cms_Frames.Name = "cms_Frames"
        Me.cms_Frames.ShowImageMargin = False
        Me.cms_Frames.Size = New System.Drawing.Size(178, 26)
        '
        'DeleteFrameToolStripMenuItem
        '
        Me.DeleteFrameToolStripMenuItem.Name = "DeleteFrameToolStripMenuItem"
        Me.DeleteFrameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeleteFrameToolStripMenuItem.Text = "Delete Seleced Frame(s)"
        '
        'txt_FrameCount
        '
        Me.txt_FrameCount.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_FrameCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_FrameCount.Location = New System.Drawing.Point(80, 8)
        Me.txt_FrameCount.Name = "txt_FrameCount"
        Me.txt_FrameCount.ReadOnly = True
        Me.txt_FrameCount.Size = New System.Drawing.Size(100, 13)
        Me.txt_FrameCount.TabIndex = 1
        '
        'tpg_Errors
        '
        Me.tpg_Errors.Controls.Add(Me.lst_Exceptions)
        Me.tpg_Errors.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Errors.Name = "tpg_Errors"
        Me.tpg_Errors.Size = New System.Drawing.Size(648, 518)
        Me.tpg_Errors.TabIndex = 4
        Me.tpg_Errors.Text = "Exceptions"
        Me.tpg_Errors.Visible = False
        '
        'lst_Exceptions
        '
        Me.lst_Exceptions.DisplayMember = "Message"
        Me.lst_Exceptions.HorizontalScrollbar = True
        Me.lst_Exceptions.Location = New System.Drawing.Point(8, 8)
        Me.lst_Exceptions.Name = "lst_Exceptions"
        Me.lst_Exceptions.Size = New System.Drawing.Size(632, 498)
        Me.lst_Exceptions.TabIndex = 0
        '
        'tpg_Warnings
        '
        Me.tpg_Warnings.Controls.Add(Me.lst_Warnings)
        Me.tpg_Warnings.Location = New System.Drawing.Point(4, 22)
        Me.tpg_Warnings.Name = "tpg_Warnings"
        Me.tpg_Warnings.Size = New System.Drawing.Size(648, 518)
        Me.tpg_Warnings.TabIndex = 5
        Me.tpg_Warnings.Text = "Warnings"
        '
        'lst_Warnings
        '
        Me.lst_Warnings.DisplayMember = "Message"
        Me.lst_Warnings.HorizontalScrollbar = True
        Me.lst_Warnings.Location = New System.Drawing.Point(8, 8)
        Me.lst_Warnings.Name = "lst_Warnings"
        Me.lst_Warnings.Size = New System.Drawing.Size(632, 498)
        Me.lst_Warnings.TabIndex = 1
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Close.Location = New System.Drawing.Point(584, 560)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(80, 24)
        Me.btn_Close.TabIndex = 27
        Me.btn_Close.Text = "Close"
        '
        'btn_Write
        '
        Me.btn_Write.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Write.Enabled = False
        Me.btn_Write.Location = New System.Drawing.Point(496, 560)
        Me.btn_Write.Name = "btn_Write"
        Me.btn_Write.Size = New System.Drawing.Size(80, 24)
        Me.btn_Write.TabIndex = 26
        Me.btn_Write.Text = "Write"
        '
        'btn_Load
        '
        Me.btn_Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Load.Location = New System.Drawing.Point(408, 560)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(80, 24)
        Me.btn_Load.TabIndex = 28
        Me.btn_Load.Text = "Open"
        '
        'frm_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 589)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Write)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.tab_Tag)
        Me.MinimumSize = New System.Drawing.Size(680, 616)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UltraID3Lib Test Harness"
        Me.tab_Tag.ResumeLayout(False)
        Me.tpg_Fields.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_VBRInfo.ResumeLayout(False)
        Me.grp_VBRInfo.PerformLayout()
        Me.grp_ID3v2.ResumeLayout(False)
        Me.grp_ID3v2.PerformLayout()
        Me.grp_ID3v1.ResumeLayout(False)
        Me.grp_ID3v1.PerformLayout()
        Me.tpg_Pictures.ResumeLayout(False)
        Me.tpg_Pictures.PerformLayout()
        CType(Me.pbx_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpg_Frames.ResumeLayout(False)
        Me.tpg_Frames.PerformLayout()
        Me.cms_Frames.ResumeLayout(False)
        Me.tpg_Errors.ResumeLayout(False)
        Me.tpg_Warnings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_Frames As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_GetDurations As System.Windows.Forms.Button

End Class
