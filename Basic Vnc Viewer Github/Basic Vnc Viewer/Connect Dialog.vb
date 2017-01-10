Public Class ConnectDialog
    Public ReadOnly Property Host() As String
        Get
            Return txtboxsvrIP.Text
        End Get
    End Property

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtboxsvrIP_TextChanged(sender As Object, e As EventArgs) Handles txtboxsvrIP.TextChanged
        If (txtboxsvrIP.Text = Nothing) Then
            btnConnect.Enabled = False
        Else
            btnConnect.Enabled = True
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Viewer.Show()
        Me.Hide()
        If (Not Host = Nothing) Then
            Try
                MessageBox.Show(Me,
                                "Connecting to Vnc server. click OK to continue.",
                                "Connecting",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Viewer.rd.Connect(Host)
            Catch ex As Exception
                Viewer.Hide()
                MessageBox.Show(Me,
                                String.Format("Unable to connect to Vnc Server. Check connection and try again", ex.Message),
                                String.Format("Unable to Connect", Host),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Me.Show()
            End Try
        End If
    End Sub
End Class
