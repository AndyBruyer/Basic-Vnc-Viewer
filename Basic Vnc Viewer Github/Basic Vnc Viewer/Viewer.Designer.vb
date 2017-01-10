<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClippedViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaledViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullScreenRefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rd = New VncSharp.RemoteDesktop()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClippedViewToolStripMenuItem, Me.ScaledViewToolStripMenuItem, Me.ToolStripSeparator1, Me.FullScreenRefreshToolStripMenuItem, Me.ViewOnlyToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ClippedViewToolStripMenuItem
        '
        Me.ClippedViewToolStripMenuItem.Checked = True
        Me.ClippedViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClippedViewToolStripMenuItem.Name = "ClippedViewToolStripMenuItem"
        Me.ClippedViewToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClippedViewToolStripMenuItem.Text = "Clipped View"
        '
        'ScaledViewToolStripMenuItem
        '
        Me.ScaledViewToolStripMenuItem.Name = "ScaledViewToolStripMenuItem"
        Me.ScaledViewToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ScaledViewToolStripMenuItem.Text = "Scaled View"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'FullScreenRefreshToolStripMenuItem
        '
        Me.FullScreenRefreshToolStripMenuItem.Name = "FullScreenRefreshToolStripMenuItem"
        Me.FullScreenRefreshToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.FullScreenRefreshToolStripMenuItem.Text = "Full Screen Refresh"
        '
        'ViewOnlyToolStripMenuItem
        '
        Me.ViewOnlyToolStripMenuItem.Name = "ViewOnlyToolStripMenuItem"
        Me.ViewOnlyToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ViewOnlyToolStripMenuItem.Text = "View Only"
        '
        'rd
        '
        Me.rd.AutoScroll = True
        Me.rd.AutoScrollMinSize = New System.Drawing.Size(608, 427)
        Me.rd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rd.Location = New System.Drawing.Point(0, 24)
        Me.rd.Name = "rd"
        Me.rd.Size = New System.Drawing.Size(784, 537)
        Me.rd.TabIndex = 1
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.rd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Viewer"
        Me.Text = "Viewer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rd As VncSharp.RemoteDesktop
    Friend WithEvents DisconnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClippedViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaledViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FullScreenRefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOnlyToolStripMenuItem As ToolStripMenuItem
End Class
