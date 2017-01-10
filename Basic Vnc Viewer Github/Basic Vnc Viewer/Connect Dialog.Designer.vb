<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConnectDialog))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtboxsvrIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Enabled = False
        Me.btnConnect.Location = New System.Drawing.Point(182, 52)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(126, 22)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 51)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtboxsvrIP
        '
        Me.txtboxsvrIP.Location = New System.Drawing.Point(12, 25)
        Me.txtboxsvrIP.Name = "txtboxsvrIP"
        Me.txtboxsvrIP.Size = New System.Drawing.Size(296, 20)
        Me.txtboxsvrIP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the ip address of the computer with a vnc server"
        '
        'ConnectDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(320, 84)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxsvrIP)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConnect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ConnectDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Vnc Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtboxsvrIP As TextBox
    Friend WithEvents Label1 As Label
End Class
