<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlayer))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.WmpPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.LblFilename = New System.Windows.Forms.Label()
        Me.lblVolumeLevel = New System.Windows.Forms.Label()
        Me.TbrVolumeLevel = New System.Windows.Forms.TrackBar()
        Me.PicOpen = New System.Windows.Forms.PictureBox()
        Me.PicStop = New System.Windows.Forms.PictureBox()
        Me.PicFastForward = New System.Windows.Forms.PictureBox()
        Me.PicPlayPause = New System.Windows.Forms.PictureBox()
        Me.PicRewind = New System.Windows.Forms.PictureBox()
        Me.PicMute = New System.Windows.Forms.PictureBox()
        Me.TipPlayer = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.WmpPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbrVolumeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFastForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRewind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.WmpPlayer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblFilename)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblVolumeLevel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TbrVolumeLevel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicOpen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicStop)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicFastForward)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicPlayPause)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicRewind)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicMute)
        Me.SplitContainer1.Size = New System.Drawing.Size(1174, 769)
        Me.SplitContainer1.SplitterDistance = 713
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'WmpPlayer
        '
        Me.WmpPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WmpPlayer.Enabled = True
        Me.WmpPlayer.Location = New System.Drawing.Point(0, 0)
        Me.WmpPlayer.Name = "WmpPlayer"
        Me.WmpPlayer.OcxState = CType(resources.GetObject("WmpPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WmpPlayer.Size = New System.Drawing.Size(1174, 713)
        Me.WmpPlayer.TabIndex = 1
        '
        'LblFilename
        '
        Me.LblFilename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFilename.Location = New System.Drawing.Point(707, 2)
        Me.LblFilename.Name = "LblFilename"
        Me.LblFilename.Size = New System.Drawing.Size(386, 50)
        Me.LblFilename.TabIndex = 8
        Me.LblFilename.Text = "No File Selected"
        Me.LblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVolumeLevel
        '
        Me.lblVolumeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumeLevel.ForeColor = System.Drawing.Color.Teal
        Me.lblVolumeLevel.Location = New System.Drawing.Point(294, 29)
        Me.lblVolumeLevel.Name = "lblVolumeLevel"
        Me.lblVolumeLevel.Size = New System.Drawing.Size(43, 20)
        Me.lblVolumeLevel.TabIndex = 7
        Me.lblVolumeLevel.Text = "100"
        '
        'TbrVolumeLevel
        '
        Me.TbrVolumeLevel.AutoSize = False
        Me.TbrVolumeLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TbrVolumeLevel.LargeChange = 10
        Me.TbrVolumeLevel.Location = New System.Drawing.Point(65, 19)
        Me.TbrVolumeLevel.Maximum = 100
        Me.TbrVolumeLevel.Name = "TbrVolumeLevel"
        Me.TbrVolumeLevel.Size = New System.Drawing.Size(223, 27)
        Me.TbrVolumeLevel.TabIndex = 6
        Me.TbrVolumeLevel.Value = 50
        '
        'PicOpen
        '
        Me.PicOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicOpen.Image = Global.CoolMediaPlayer.My.Resources.Resources.Power
        Me.PicOpen.Location = New System.Drawing.Point(1115, 0)
        Me.PicOpen.Name = "PicOpen"
        Me.PicOpen.Size = New System.Drawing.Size(56, 55)
        Me.PicOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicOpen.TabIndex = 5
        Me.PicOpen.TabStop = False
        '
        'PicStop
        '
        Me.PicStop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicStop.Image = Global.CoolMediaPlayer.My.Resources.Resources.Stop_Off
        Me.PicStop.Location = New System.Drawing.Point(632, 0)
        Me.PicStop.Name = "PicStop"
        Me.PicStop.Size = New System.Drawing.Size(56, 55)
        Me.PicStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicStop.TabIndex = 4
        Me.PicStop.TabStop = False
        '
        'PicFastForward
        '
        Me.PicFastForward.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicFastForward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFastForward.Image = Global.CoolMediaPlayer.My.Resources.Resources.FF_Off
        Me.PicFastForward.Location = New System.Drawing.Point(570, 0)
        Me.PicFastForward.Name = "PicFastForward"
        Me.PicFastForward.Size = New System.Drawing.Size(56, 55)
        Me.PicFastForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFastForward.TabIndex = 3
        Me.PicFastForward.TabStop = False
        '
        'PicPlayPause
        '
        Me.PicPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicPlayPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPlayPause.Image = Global.CoolMediaPlayer.My.Resources.Resources.Play_Off
        Me.PicPlayPause.Location = New System.Drawing.Point(508, 0)
        Me.PicPlayPause.Name = "PicPlayPause"
        Me.PicPlayPause.Size = New System.Drawing.Size(56, 55)
        Me.PicPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPlayPause.TabIndex = 2
        Me.PicPlayPause.TabStop = False
        '
        'PicRewind
        '
        Me.PicRewind.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicRewind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRewind.Image = Global.CoolMediaPlayer.My.Resources.Resources.RW_Off
        Me.PicRewind.Location = New System.Drawing.Point(446, 0)
        Me.PicRewind.Name = "PicRewind"
        Me.PicRewind.Size = New System.Drawing.Size(56, 55)
        Me.PicRewind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRewind.TabIndex = 1
        Me.PicRewind.TabStop = False
        '
        'PicMute
        '
        Me.PicMute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMute.Image = Global.CoolMediaPlayer.My.Resources.Resources.Volume_On
        Me.PicMute.Location = New System.Drawing.Point(3, 0)
        Me.PicMute.Name = "PicMute"
        Me.PicMute.Size = New System.Drawing.Size(56, 55)
        Me.PicMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMute.TabIndex = 0
        Me.PicMute.TabStop = False
        '
        'FrmPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 769)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1190, 808)
        Me.Name = "FrmPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cool Media Player"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.WmpPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbrVolumeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFastForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRewind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents WmpPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PicOpen As PictureBox
    Friend WithEvents PicStop As PictureBox
    Friend WithEvents PicFastForward As PictureBox
    Friend WithEvents PicPlayPause As PictureBox
    Friend WithEvents PicRewind As PictureBox
    Friend WithEvents PicMute As PictureBox
    Friend WithEvents TbrVolumeLevel As TrackBar
    Friend WithEvents lblVolumeLevel As Label
    Friend WithEvents TipPlayer As ToolTip
    Friend WithEvents LblFilename As Label
End Class
