Module themes
    Public Sub Change_theme_frm(ByVal frm As Form, ByVal Theme As String)
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
                    Select Case sub_ctr.GetType
                        Case GetType(ComboBox)
                            sub_ctr.BackColor = backcolor_sub
                            sub_ctr.ForeColor = forecolor_sub
                        Case GetType(TextBox)
                            sub_ctr.BackColor = backcolor_sub
                            sub_ctr.ForeColor = forecolor_sub
                        Case Else
                            sub_ctr.BackColor = backcolor
                            sub_ctr.ForeColor = forecolor
                    End Select
                Next
            Else
                Select Case ctr.GetType
                    Case GetType(ComboBox)
                        ctr.BackColor = backcolor_sub
                        ctr.ForeColor = forecolor_sub
                    Case GetType(TextBox)
                        ctr.BackColor = backcolor_sub
                        ctr.ForeColor = forecolor_sub
                    Case Else
                        ctr.BackColor = backcolor
                        ctr.ForeColor = forecolor
                End Select
            End If
            ctr.BackColor = backcolor
            ctr.ForeColor = forecolor
        Next
    End Sub
    Public Sub Change_theme_controls(ByVal current_control As Control, ByVal theme As String)
        Dim backcolor As Color
        Dim forecolor As Color
        Dim backcolor_sub As Color
        Dim forecolor_sub As Color
        Select Case theme
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
        current_control.BackColor = backcolor
        current_control.ForeColor = forecolor
        For Each ctr As Control In current_control.Controls
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
                    Select Case sub_ctr.GetType
                        Case GetType(ComboBox)
                            sub_ctr.BackColor = backcolor_sub
                            sub_ctr.ForeColor = forecolor_sub
                        Case GetType(TextBox)
                            sub_ctr.BackColor = backcolor_sub
                            sub_ctr.ForeColor = forecolor_sub
                        Case Else
                            sub_ctr.BackColor = backcolor
                            sub_ctr.ForeColor = forecolor
                    End Select
                Next
            Else
                Select Case ctr.GetType
                    Case GetType(ComboBox)
                        ctr.BackColor = backcolor_sub
                        ctr.ForeColor = forecolor_sub
                    Case GetType(TextBox)
                        ctr.BackColor = backcolor_sub
                        ctr.ForeColor = forecolor_sub
                    Case Else
                        ctr.BackColor = backcolor
                        ctr.ForeColor = forecolor
                End Select
            End If
            ctr.BackColor = backcolor
            ctr.ForeColor = forecolor
        Next
    End Sub
End Module
