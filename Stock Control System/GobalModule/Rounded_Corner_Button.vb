Module Rounded_Corner_Button
    Sub RoundCornerButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.DarkGray                                                      'sets how the buttion will look like 
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)                                    'sets how the dimensions on how the buttion will be seen
        rad.AddLine(10, 0, btn.Width - 20, 0)                                               ' in terms of the size and propositions
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)                              ' this makes a normal buttion rounded. 
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        btn.Region = New Region(rad)

    End Sub
End Module
