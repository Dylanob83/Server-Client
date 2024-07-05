Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading

Public Class TCPControl

    Public Event MessageReceived(sender As TCPControl, Data As String)


    'Server Config
    Public ServerIP As IPAddress = IPAddress.Parse("192.168.1.62")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread
    Public IsListening As Boolean = True

    'Clients
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()
    End Sub

    Private Sub Listening()
        'Create Listener Loop
        Do Until IsListening = False
            'Accept Incoming Connections
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)

            End If

            'Raise Event For Incoming Messages
            'Try
            'RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            'Catch ex As Exception

            'End Try

            'Reduce CPU Usage
            Thread.Sleep(100)

        Loop
    End Sub
End Class
