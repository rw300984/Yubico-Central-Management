Imports System
Imports System.Diagnostics
    Imports System.ComponentModel
    Imports System.Windows.Forms
    Imports System.Drawing
    Imports System.Drawing.Drawing2D


    Public Class RoundedPanel

        Inherits Panel

        Private pen As Pen = New Pen(_borderColor, penWidth)
        Private Shared ReadOnly penWidth As Single = 2.0F

        Public Sub New()

        End Sub

        Private _borderColor As Color = Color.White
        <Browsable(True)>
        Public Property BorderColor() As Color
            Get
                Return _borderColor
            End Get
            Set(ByVal Value As Color)
                _borderColor = Value
                pen = New Pen(_borderColor, penWidth)
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            ExtendedDraw(e)
            DrawBorder(e.Graphics)
        End Sub

        Private _edge As Integer = 50
        <Browsable(True)>
        Public Property Edge() As Integer
            Get
                Return _edge
            End Get
            Set(ByVal Value As Integer)
                _edge = Value
                Invalidate()
            End Set
        End Property


        Private Function GetLeftUpper(ByVal e As Integer) As Rectangle
            Return New Rectangle(0, 0, e, e)
        End Function

        Private Function GetRightUpper(ByVal e As Integer) As Rectangle
            Return New Rectangle(Width - e, 0, e, e)
        End Function

        Private Function GetRightLower(ByVal e As Integer) As Rectangle
            Return New Rectangle(Width - e, Height - e, e, e)
        End Function

        Private Function GetLeftLower(ByVal e As Integer) As Rectangle

            Return New Rectangle(0, Height - e, e, e)
        End Function

        Private Sub ExtendedDraw(ByVal e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim path As GraphicsPath = New GraphicsPath()
            path.StartFigure()
            path.StartFigure()
            path.AddArc(GetLeftUpper(Edge), 180, 90)
            path.AddLine(Edge, 0, Width - Edge, 0)
            path.AddArc(GetRightUpper(Edge), 270, 90)
            path.AddLine(Width, Edge, Width, Height - Edge)
            path.AddArc(GetRightLower(Edge), 0, 90)
            path.AddLine(Width - Edge, Height, Edge, Height)
            path.AddArc(GetLeftLower(Edge), 90, 90)
            path.AddLine(0, Height - Edge, 0, Edge)
            path.CloseFigure()
            Region = New Region(path)
        End Sub

        Private Sub DrawSingleBorder(ByVal graphics As Graphics)
            graphics.DrawArc(pen, New Rectangle(0, 0, Edge, Edge),
                             180, 90)
            graphics.DrawArc(pen, New Rectangle(Width - Edge - 1, -1,
                             Edge, Edge), 270, 90)
            graphics.DrawArc(pen, New Rectangle(Width - Edge - 1,
                             Height - Edge - 1, Edge, Edge), 0, 90)
            graphics.DrawArc(pen, New Rectangle(0, Height - Edge - 1,
                             Edge, Edge), 90, 90)
            graphics.DrawRectangle(pen, 0.0F, 0.0F, CType((Width - 1),
                                   Single), CType((Height - 1), Single))
        End Sub

        Private Sub Draw3DBorder(ByVal graphics As Graphics)
            'TODO Implement 3D border
        End Sub

        Private Sub DrawBorder(ByVal graphics As Graphics)
            DrawSingleBorder(graphics)
        End Sub
    End Class

