
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Private Class CSState
        Public myTcpListener As TcpListener
        Public ClientSocket As Socket
        Public mystring As String
    End Class
    Private myDatatable As New DataTable
    Private myTcpListener As TcpListener
    Delegate Sub SetMsgCallBack(ByVal state As Object)
    Private Sub DisplayMsg1(ByVal state As Object)
        Dim myObj As New CSState
        myObj = CType(state, CSState)
        If Me.DataGridView1.InvokeRequired Then
            Dim d As New SetMsgCallBack(AddressOf DisplayMsg1)
            Me.Invoke(d, New Object() {myObj})
        Else
            Dim xRow As DataRow = myDatatable.NewRow()
            xRow.Item(0) = CType(myObj.ClientSocket.RemoteEndPoint, IPEndPoint).Address.ToString()
            xRow.Item(1) = CType(myObj.ClientSocket.RemoteEndPoint, IPEndPoint).Port.ToString()
            xRow.Item(2) = myObj.mystring
            myDatatable.Rows.Add(xRow)
        End If
    End Sub
    Delegate Sub LbCallBack(ByVal myString As String, ByVal myColor As Color)
    Private Sub ChangeLB(ByVal myString As String, ByVal myColor As Color)
        If Me.Label2.InvokeRequired Then
            Dim d As New LbCallBack(AddressOf ChangeLB)
            Me.Invoke(d, New Object() {myString, myColor})
        Else
            Label2.Text = myString
            Label2.ForeColor = myColor
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myDatatable.Columns.Add("IP")
        myDatatable.Columns.Add("Port")
        myDatatable.Columns.Add("Data")
        DataGridView1.DataSource = myDatatable
        DataGridView1.Columns(2).Width = 150
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Enabled = True Then
            Dim iPort As Integer
            iPort = NumericUpDown1.Value
            Button1.Enabled = False
            Button2.Enabled = True
            Dim ListenThread As New Thread(AddressOf StartListen)
            ListenThread.IsBackground = True
            ListenThread.Start(iPort)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Enabled = True Then
            myTcpListener.Stop()
            ChangeLB("TCP Listener 停止", Color.Red)
            Button1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub
    Private Sub StartListen(ByVal state As Object)
        Dim iPort As Integer
        iPort = CType(state, Integer)
        myTcpListener = New TcpListener(IPAddress.Any, iPort)
        Try
            Dim ClientSocket As Socket
            myTcpListener.Start()
            Dim iCount As Integer = 0
            ChangeLB("TCP Listener 已啟動", Color.Blue)
            Do
                ClientSocket = myTcpListener.AcceptSocket()
                If ClientSocket.Connected = True Then
                    Dim myObj As New CSState
                    myObj.myTcpListener = myTcpListener
                    myObj.ClientSocket = ClientSocket
                    myObj.mystring = Now.ToString("yyyy/MM/dd HH:mm:ss") & "已連線"
                    DisplayMsg1(myObj)
                    Dim ReceiveThread As New Thread(AddressOf ReceiveData)
                    ReceiveThread.IsBackground = True
                    ReceiveThread.Start(myObj)
                    iCount += 1
                End If
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub ReceiveData(ByVal state As Object)
        Dim myObj As New CSState
        myObj.ClientSocket = CType(state, CSState).ClientSocket
        myObj.myTcpListener = CType(state, CSState).myTcpListener
        myObj.mystring = ""
        Dim myNetworkStream As New NetworkStream(myObj.ClientSocket)
        Dim InBytesCount As Integer = 0
        Dim myReceiveBytes(1023) As Byte
        Dim i As Integer = 0
        While True
            Try
                InBytesCount = myNetworkStream.Read(myReceiveBytes, 0, myReceiveBytes.Length)
                System.Threading.Thread.Sleep(100)
                If InBytesCount = 0 Then
                    Exit While
                End If
                myObj.mystring = Encoding.GetEncoding(950).GetString(myReceiveBytes).TrimEnd().TrimStart()
                DisplayMsg1(myObj)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        End While
    End Sub
End Class
