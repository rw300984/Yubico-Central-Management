Module Others
    'Public Function FindDockedTaskBars(ByRef DockedRectCounter As Integer) As Rectangle()
    '    Dim TmpScrn As Screen = Nothing
    '    Dim LeftDockedWidth As Integer = 0
    '    Dim TopDockedHeight As Integer = 0
    '    Dim RightDockedWidth As Integer = 0
    '    Dim BottomDockedHeight As Integer = 0
    '    Dim DockedRects(Screen.AllScreens.Count - 1) As Rectangle

    '    DockedRectCounter = 0

    '    For Each TmpScrn In Screen.AllScreens
    '        If Not TmpScrn.Bounds.Equals(TmpScrn.WorkingArea) Then
    '            LeftDockedWidth = Math.Abs(Math.Abs(TmpScrn.Bounds.Left) - Math.Abs(TmpScrn.WorkingArea.Left))
    '            TopDockedHeight = Math.Abs(Math.Abs(TmpScrn.Bounds.Top) - Math.Abs(TmpScrn.WorkingArea.Top))
    '            RightDockedWidth = (TmpScrn.Bounds.Width - LeftDockedWidth) - TmpScrn.WorkingArea.Width
    '            BottomDockedHeight = (TmpScrn.Bounds.Height - TopDockedHeight) - TmpScrn.WorkingArea.Height

    '            If LeftDockedWidth > 0 Then
    '                DockedRects(DockedRectCounter).X = TmpScrn.Bounds.Left
    '                DockedRects(DockedRectCounter).Y = TmpScrn.Bounds.Top
    '                DockedRects(DockedRectCounter).Width = LeftDockedWidth
    '                DockedRects(DockedRectCounter).Height = TmpScrn.Bounds.Height
    '                DockedRectCounter += 1
    '            End If
    '            If RightDockedWidth > 0 Then
    '                DockedRects(DockedRectCounter).X = TmpScrn.WorkingArea.Right
    '                DockedRects(DockedRectCounter).Y = TmpScrn.Bounds.Top
    '                DockedRects(DockedRectCounter).Width = RightDockedWidth
    '                DockedRects(DockedRectCounter).Height = TmpScrn.Bounds.Height
    '                DockedRectCounter += 1
    '            End If
    '            If TopDockedHeight > 0 Then
    '                DockedRects(DockedRectCounter).X = TmpScrn.WorkingArea.Left
    '                DockedRects(DockedRectCounter).Y = TmpScrn.Bounds.Top
    '                DockedRects(DockedRectCounter).Width = TmpScrn.WorkingArea.Width
    '                DockedRects(DockedRectCounter).Height = TopDockedHeight
    '                DockedRectCounter += 1
    '            End If
    '            If BottomDockedHeight > 0 Then
    '                DockedRects(DockedRectCounter).X = TmpScrn.WorkingArea.Left
    '                DockedRects(DockedRectCounter).Y = TmpScrn.WorkingArea.Bottom
    '                DockedRects(DockedRectCounter).Width = TmpScrn.WorkingArea.Width
    '                DockedRects(DockedRectCounter).Height = BottomDockedHeight
    '                DockedRectCounter += 1
    '            End If
    '        End If
    '    Next
    '    Return DockedRects
    'End Function
    Public Function FindDockedTaskBars(ByVal MyScreen As Rectangle, ByVal MyWorkingArea As Rectangle) As Rectangle
        Dim TmpScrn As Screen = Nothing
        Dim LeftDockedWidth As Integer = 0
        Dim TopDockedHeight As Integer = 0
        Dim RightDockedWidth As Integer = 0
        Dim BottomDockedHeight As Integer = 0
        Dim Result As Rectangle

        If Not MyScreen.Equals(MyWorkingArea) Then
            LeftDockedWidth = Math.Abs(Math.Abs(MyScreen.Left) - Math.Abs(MyWorkingArea.Left))
            TopDockedHeight = Math.Abs(Math.Abs(MyScreen.Top) - Math.Abs(MyWorkingArea.Top))
            RightDockedWidth = (MyScreen.Width - LeftDockedWidth) - MyWorkingArea.Width
            BottomDockedHeight = (MyScreen.Height - TopDockedHeight) - MyWorkingArea.Height

            If LeftDockedWidth > 0 Then
                Result.X = MyScreen.Left
                Result.Y = MyScreen.Top
                Result.Width = LeftDockedWidth
                Result.Height = MyScreen.Height
                ' DockedRectCounter += 1
            End If
            If RightDockedWidth > 0 Then
                Result.X = MyWorkingArea.Right
                Result.Y = MyScreen.Top
                Result.Width = RightDockedWidth
                Result.Height = MyScreen.Height
                '  DockedRectCounter += 1
            End If
            If TopDockedHeight > 0 Then
                Result.X = MyWorkingArea.Left
                Result.Y = MyScreen.Top
                Result.Width = MyWorkingArea.Width
                Result.Height = TopDockedHeight
                '  DockedRectCounter += 1
            End If
            If BottomDockedHeight > 0 Then
                Result.X = MyWorkingArea.Left
                Result.Y = MyWorkingArea.Bottom
                Result.Width = MyWorkingArea.Width
                Result.Height = BottomDockedHeight
                ' DockedRectCounter += 1
            End If
        Else
            Return Nothing
        End If
        Return Result
    End Function
    Public Function FindTaskbarlocation(ByVal MyScreen As Rectangle, ByVal MyWorkingArea As Rectangle) As Integer
        Dim TmpScrn As Screen = Nothing
        Dim LeftDockedWidth As Integer = 0
        Dim TopDockedHeight As Integer = 0
        Dim RightDockedWidth As Integer = 0
        Dim BottomDockedHeight As Integer = 0
        Dim Result As Integer

        If Not MyScreen.Equals(MyWorkingArea) Then
            LeftDockedWidth = Math.Abs(Math.Abs(MyScreen.Left) - Math.Abs(MyWorkingArea.Left))
            TopDockedHeight = Math.Abs(Math.Abs(MyScreen.Top) - Math.Abs(MyWorkingArea.Top))
            RightDockedWidth = (MyScreen.Width - LeftDockedWidth) - MyWorkingArea.Width
            BottomDockedHeight = (MyScreen.Height - TopDockedHeight) - MyWorkingArea.Height

            If LeftDockedWidth > 0 Then
                Result = 0
            End If
            If RightDockedWidth > 0 Then
                Result = 1
            End If
            If TopDockedHeight > 0 Then
                Result = 2
            End If
            If BottomDockedHeight > 0 Then
                Result = 3
            End If
        Else
            Result = 4
        End If
        Return Result
    End Function
End Module
