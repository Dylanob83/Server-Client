Public Class Form1
    Private Server As TCPControl



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server = New TCPControl
        txtChat.Text = ":: SERVER STARTED ::" & vbCrLf

        AddHandler Server.MessageReceived, AddressOf OnLineReceived
    End Sub

    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)

    'Update Textbox
    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then
                TB.AppendText(txt & vbCrLf)
            End If
        End If
    End Sub

    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        UpdateText(txtChat, Data)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Server.IsListening = False
    End Sub
End Class
