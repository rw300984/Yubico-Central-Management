Module Others
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
