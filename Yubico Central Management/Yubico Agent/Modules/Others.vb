Module Others
    Public Function FindDockedTaskBars(ByVal MyScreen As Rectangle, ByVal MyWorkingArea As Rectangle) As Rectangle
        Try
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function FindTaskbarlocation(ByVal MyScreen As Rectangle, ByVal MyWorkingArea As Rectangle) As Integer
        Try
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
    Public Function GetFileVersion(ByVal file As String) As String
        Try
            Dim result As String
            If System.IO.File.Exists(file) Then
                Dim driver_info As FileVersionInfo = FileVersionInfo.GetVersionInfo(file)
                result = driver_info.FileVersion
            Else
                result = "0"
            End If
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
    Public Function GetRegistryEntry(ByVal key As String, ByVal attribute As String)
        Try
            Dim result As String = My.Computer.Registry.GetValue(key, attribute, Nothing)
            If result = Nothing Then
                result = "0"
            End If
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
End Module
