Module themes
    Public Sub Change_theme(ByVal frm As Form, ByVal Theme As String)
        Dim backcolor As Color
        Dim forecolor As Color
        Dim backcolor_sub As Color
        Dim forecolor_sub As Color
        Select Case Theme
            Case "Gray (default)"
                backcolor = SystemColors.Control
                forecolor = Color.Black
                backcolor_sub = SystemColors.ControlLight
                forecolor_sub = Color.Black
            Case "Light"
                backcolor = Color.White
                forecolor = Color.Black
                backcolor_sub = Color.WhiteSmoke
                forecolor_sub = Color.Black
            Case "Dark"
                backcolor = Color.Black
                forecolor = Color.White
                backcolor_sub = Color.DimGray
                forecolor_sub = Color.White
            Case Else
                backcolor = SystemColors.Control
                forecolor = Color.Black
                backcolor_sub = SystemColors.ControlLight
                forecolor_sub = Color.Black
        End Select
        frm.BackColor = backcolor
        frm.ForeColor = forecolor
        For Each ctr As Control In frm.Controls
            If ctr.HasChildren Then
                For Each sub_ctr As Control In ctr.Controls
                    If sub_ctr.HasChildren Then
                        For Each sub_sub_ctr As Control In sub_ctr.Controls
                            Select Case sub_sub_ctr.GetType
                                Case GetType(ComboBox)
                                    sub_sub_ctr.BackColor = backcolor_sub
                                    sub_sub_ctr.ForeColor = forecolor_sub
                                Case GetType(TextBox)
                                    sub_sub_ctr.BackColor = backcolor_sub
                                    sub_sub_ctr.ForeColor = forecolor_sub
                            End Select
                        Next
                    End If
                    sub_ctr.BackColor = backcolor
                    sub_ctr.ForeColor = forecolor
                Next
            Else
                ctr.BackColor = backcolor
                ctr.ForeColor = forecolor
            End If
            ctr.BackColor = backcolor
            ctr.ForeColor = forecolor
        Next
    End Sub
End Module
