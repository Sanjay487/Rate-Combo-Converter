Public Class Form1
    'Public Property SelectedItem() As String
    '    Get
    '        Return ComboBox1.SelectedItem.ToString()
    '    End Get
    '    Set(ByVal value As String)
    '        ComboBox1.SelectedItem = value
    '    End Set
    'End Property

    'Public Property TextValue() As String
    '    Get
    '        Return TextBox1.Text
    '    End Get
    '    Set(ByVal value As String)
    '        TextBox1.Text = value
    '    End Set
    'End Property

    Dim gp = 121000, sp = 1155, dia = 890200
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Gold" Then
            TextBox1.Text = gp
        ElseIf ComboBox1.Text = "Silver" Then
            TextBox1.Text = sp
        Else
            TextBox1.Text = dia
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form2
        frm2.SelectedItem = ComboBox1.SelectedItem.ToString
        frm2.Textvalue = TextBox1.Text
        frm2.ShowDialog()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
