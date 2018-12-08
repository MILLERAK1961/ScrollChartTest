Public Class Form1

    Const MaxPoints = 100

    Dim MasterCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Chart1.ChartAreas(0).AxisX.Minimum = 0
        Chart1.ChartAreas(0).AxisX.Maximum = 100


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Text = MasterCount

        If Chart1.Series(0).Points.Count >= MaxPoints Then

            Chart1.ChartAreas(0).AxisX.Minimum = MasterCount - MaxPoints + 1
            Chart1.ChartAreas(0).AxisX.Maximum = MasterCount


            Chart1.Series(0).Points.RemoveAt(0)

        End If

        Chart1.Series(0).Points.AddXY(MasterCount, Rnd())



        MasterCount += 1

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class
