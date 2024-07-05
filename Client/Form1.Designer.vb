<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdConnect = New Button()
        cmdSend = New Button()
        txtMessage = New TextBox()
        SuspendLayout()
        ' 
        ' cmdConnect
        ' 
        cmdConnect.Location = New Point(167, 12)
        cmdConnect.Name = "cmdConnect"
        cmdConnect.Size = New Size(192, 57)
        cmdConnect.TabIndex = 0
        cmdConnect.Text = "Connect"
        cmdConnect.UseVisualStyleBackColor = True
        ' 
        ' cmdSend
        ' 
        cmdSend.Location = New Point(487, 164)
        cmdSend.Name = "cmdSend"
        cmdSend.Size = New Size(80, 36)
        cmdSend.TabIndex = 1
        cmdSend.Text = "Send"
        cmdSend.UseVisualStyleBackColor = True
        ' 
        ' txtMessage
        ' 
        txtMessage.Location = New Point(12, 172)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(445, 23)
        txtMessage.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(579, 273)
        Controls.Add(txtMessage)
        Controls.Add(cmdSend)
        Controls.Add(cmdConnect)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdConnect As Button
    Friend WithEvents cmdSend As Button
    Friend WithEvents txtMessage As TextBox

End Class
