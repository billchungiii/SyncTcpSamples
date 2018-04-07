Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Private myTcpClient As TcpClient
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim myIPEndPoint As New IPEndPoint(IPAddress.Any, 0)
        myTcpClient = New TcpClient(myIPEndPoint)
        Dim ServerIpAddress As IPAddress
        Try
            ServerIpAddress = IPAddress.Parse(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Server IP設定錯誤")
            Exit Sub
        End Try
        Dim iPort As Integer
        iPort = NumericUpDown1.Value
        Dim RemoteIpEndPoint As New IPEndPoint(ServerIpAddress, iPort)
        Try
            myTcpClient.Connect(RemoteIpEndPoint)
            Do
                If myTcpClient.Connected = True Then
                    Label4.Text = "連線中"
                    Button1.Enabled = False
                    Button2.Enabled = True
                    Button3.Enabled = True
                    Exit Do
                End If
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Label4.Text = "未連線"
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ServerIpAddress As IPAddress
        Try
            ServerIpAddress = IPAddress.Parse(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Server IP設定錯誤")
            Exit Sub
        End Try
        Dim iPort As Integer
        iPort = NumericUpDown1.Value
        Dim RemoteIpEndPoint As New IPEndPoint(ServerIpAddress, iPort)
        Dim myNetworkStream As NetworkStream
        Dim myBytes As Byte()
        myBytes = Encoding.GetEncoding(950).GetBytes(Trim(TextBox2.Text).TrimEnd())
        Try
            myNetworkStream = myTcpClient.GetStream()
            myNetworkStream.Write(myBytes, 0, myBytes.Length)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myTcpClient.Close()
        Label4.Text = "未連線"
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub


End Class
