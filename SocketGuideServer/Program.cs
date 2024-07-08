using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Server
{
    public static void Main()
    {
        //Set ipv4 address and socket to variables
        IPAddress ServerAddress = IPAddress.Parse("127.0.0.1");
        int ServerPort = 1234;

        //Setup the new socket with the parameters of addressFamily.interNetwork (tells it to use a ipv4 address)
        //socketType.stream and protocolType.tcp (tells it to have a connection tye of tcp)
        Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        ServerSocket.Bind(new IPEndPoint(ServerAddress, ServerPort));

        //telling the socket to start listening and to only let 5 connections at one time
        ServerSocket.Listen(5);
        Console.WriteLine("Server is listening for connections");

        while (true)
        {
            Socket ClientSocket = ServerSocket.Accept();
            Console.WriteLine("Client connected!");

            //setup a array called temp to store the clients data, set what you recieve from clientSocket to be put into an int called ClientBytes
            //convert the bytes from clientbytes to string to read it 
            byte[] temp = new byte[1024];
            int ClientBytes = ClientSocket.Receive(temp);
            string ClientMessage = Encoding.ASCII.GetString(temp, 0, ClientBytes);
            Console.WriteLine("Recieved data from client: " + ClientMessage);

            //Convert the serverMessage to bytes then send it down the clientSocket
            string ServerMessage = "Hello Client!";
            byte[] temp2 = Encoding.ASCII.GetBytes(ServerMessage);
            ClientSocket.Send(temp2);

            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
        }
        
        ServerSocket.Close();
    }
}
