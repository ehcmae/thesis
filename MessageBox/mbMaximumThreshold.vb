﻿Public Class mbMaximumThreshold

    Private Sub mbMaximumThreshold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1500
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class