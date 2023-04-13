Imports System.IO
Imports AxWMPLib

Public Class FrmPlayer

    Private myVideo As String = Nothing
    Private volLevel As Integer = 50

    Private ReadOnly forecolorNoFilename As Color = Color.FromArgb(200, 50, 50)
    Private ReadOnly forecolorWithFilename As Color = Color.FromArgb(25, 100, 25)

    Private ReadOnly bitmapPlayOn As Bitmap = My.Resources.Play_On, bitmapPlayOff As Bitmap = My.Resources.Play_Off
    Private ReadOnly bitmapStopOn As Bitmap = My.Resources.Stop_On, bitmapStopOff As Bitmap = My.Resources.Stop_Off
    Private ReadOnly bitmapRewindOn As Bitmap = My.Resources.RW_On, bitmapRewindOff As Bitmap = My.Resources.RW_Off
    Private ReadOnly bitmapForwardOn As Bitmap = My.Resources.FF_On, bitmapForwardOff As Bitmap = My.Resources.FF_Off
    Private ReadOnly bitmapPauseOn As Bitmap = My.Resources.Pause_On

    Private Sub FrmPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WmpPlayer.uiMode = "none"
        lblVolumeLevel.Text = TbrVolumeLevel.Value
        LblFilename.ForeColor = forecolorNoFilename

    End Sub

    Private Sub MutePlayer()

        If TbrVolumeLevel.Value = 0 Then
            PicMute.Image = My.Resources.Volume_Off
        Else
            PicMute.Image = My.Resources.Volume_On
            volLevel = TbrVolumeLevel.Value
        End If

        lblVolumeLevel.Text = TbrVolumeLevel.Value

    End Sub

    Private Sub PicMute_Click(sender As Object, e As EventArgs) Handles PicMute.Click

        If TbrVolumeLevel.Value = 0 Then
            TbrVolumeLevel.Value = volLevel
        Else
            TbrVolumeLevel.Value = 0
        End If

        Call MutePlayer()
        WmpPlayer.settings.volume = TbrVolumeLevel.Value

    End Sub

    Private Sub TbrVolumeLevel_Scroll(sender As Object, e As EventArgs) Handles TbrVolumeLevel.Scroll

        Call MutePlayer()
        WmpPlayer.settings.volume = TbrVolumeLevel.Value

    End Sub

    Private Sub PicOpen_MouseHover(sender As Object, e As EventArgs) Handles PicOpen.MouseHover

        TipPlayer.Show("Open Video File", PicOpen)

    End Sub

    Private Sub PicOpen_Click(sender As Object, e As EventArgs) Handles PicOpen.Click

        Dim ofdVideo As New OpenFileDialog
        Using ofdVideo
            ofdVideo.InitialDirectory = Environment.SpecialFolder.MyVideos
            ofdVideo.Title = "Select a video file to play"
            ofdVideo.Filter = "Video Files|*.mp4"
            ofdVideo.CheckFileExists = False
            If ofdVideo.ShowDialog <> DialogResult.Cancel Then
                If Not File.Exists(ofdVideo.FileName) Then
                    MessageBox.Show("The video you attempted to play could not be found." & Environment.NewLine &
                                    "Please make sure the file exists and try again." & Environment.NewLine & Environment.NewLine &
                                    "Any existing video has been removed from the player and must be reselected.",
                                    "Video Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myVideo = ""
                Else
                    myVideo = ofdVideo.FileName
                    WmpPlayer.URL = myVideo
                    WmpPlayer.Ctlcontrols.stop()
                End If
                If myVideo <> "" Then
                    LblFilename.Text = ofdVideo.SafeFileName
                    LblFilename.ForeColor = forecolorWithFilename
                    PicPlayPause.Image = bitmapPlayOn
                Else
                    LblFilename.Text = "No File Selected"
                    LblFilename.ForeColor = forecolorNoFilename
                    PicPlayPause.Image = bitmapPlayOff
                End If
            End If
            ofdVideo.Dispose()
        End Using

    End Sub

    Private Sub PicPlayPause_Click(sender As Object, e As EventArgs) Handles PicPlayPause.Click

        If myVideo <> "" Then
            If WmpPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                WmpPlayer.Ctlcontrols.pause()
            Else
                WmpPlayer.Ctlcontrols.play()
            End If
        End If

    End Sub

    Private Sub PicStop_Click(sender As Object, e As EventArgs) Handles PicStop.Click

        WmpPlayer.Ctlcontrols.stop()

    End Sub

    Private Sub WmpPlayer_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles WmpPlayer.PlayStateChange

        If WmpPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            PicPlayPause.Image = bitmapPauseOn
            WmpPlayer.settings.volume = TbrVolumeLevel.Value
            PicRewind.Image = bitmapRewindOn
            PicFastForward.Image = bitmapForwardOn
            PicStop.Image = bitmapStopOn
        ElseIf WmpPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
            PicPlayPause.Image = bitmapPlayOn
            PicRewind.Image = bitmapRewindOff
            PicFastForward.Image = bitmapForwardOff
        ElseIf WmpPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
            PicPlayPause.Image = bitmapPlayOn
            PicRewind.Image = bitmapRewindOff
            PicFastForward.Image = bitmapForwardOff
            PicStop.Image = bitmapStopOff
        ElseIf WmpPlayer.playState = WMPLib.WMPPlayState.wmppsScanReverse Or
                WmpPlayer.playState = WMPLib.WMPPlayState.wmppsScanForward Then
            PicPlayPause.Image = bitmapPlayOn
            PicRewind.Image = bitmapRewindOff
            PicFastForward.Image = bitmapForwardOff
            PicStop.Image = bitmapStopOn
        End If

    End Sub

    Private Sub PicRewind_Click(sender As Object, e As EventArgs) Handles PicRewind.Click

        If WmpPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            WmpPlayer.Ctlcontrols.fastReverse()
        End If

    End Sub

    Private Sub PicFastForward_Click(sender As Object, e As EventArgs) Handles PicFastForward.Click

        If WmpPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            WmpPlayer.Ctlcontrols.fastForward()
            WmpPlayer.settings.volume = 0
        End If

    End Sub
End Class
