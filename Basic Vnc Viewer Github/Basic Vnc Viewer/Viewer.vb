Imports VncSharp

Public Class Viewer
    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.Disconnect()
            ConnectDialog.Show()
            ConnectDialog.txtboxsvrIP.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub ClippedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClippedViewToolStripMenuItem.Click
        ClippedViewToolStripMenuItem.Checked = True
        ScaledViewToolStripMenuItem.Checked = False

        If (rd.IsConnected) Then
            rd.SetScalingMode(False)
        End If
    End Sub

    Private Sub ScaledViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScaledViewToolStripMenuItem.Click
        ClippedViewToolStripMenuItem.Checked = False
        ScaledViewToolStripMenuItem.Checked = True

        If (rd.IsConnected) Then
            rd.SetScalingMode(True)
        End If
    End Sub

    Private Sub FullScreenRefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenRefreshToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.FullScreenUpdate()
        End If
    End Sub

    Private Sub ViewOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOnlyToolStripMenuItem.Click
        ViewOnlyToolStripMenuItem.Checked = Not ViewOnlyToolStripMenuItem.Checked

        If (rd.IsConnected) Then
            rd.SetInputMode(ViewOnlyToolStripMenuItem.Checked)
        End If
    End Sub

    Private Sub rd_ConnectComplete(sender As Object, e As VncSharp.ConnectEventArgs) Handles rd.ConnectComplete
        ClientSize = New Size(e.DesktopWidth, e.DesktopHeight + MenuStrip1.Height)

        Text = e.DesktopName

        rd.Focus()
    End Sub

    Private Sub rd_ConnectionLost(sender As Object, e As System.EventArgs) Handles rd.ConnectionLost
        MessageBox.Show(Me,
                        "Connection Ended",
                        "Connection Ended",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class