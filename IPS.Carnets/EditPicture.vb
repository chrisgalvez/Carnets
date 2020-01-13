Imports System.Drawing.Bitmap
Imports System.Drawing.Image

Public Class EditPicture
    Friend _imagen As Bitmap
    Private _graf As Graphics
    Private _x1cut, _x2cut, _y1cut, _y2cut As Integer
    Private _image As Image
    Private _mousedown As Boolean


    Sub New(image As Image)
        InitializeComponent()
        _imagen = image
        _graf = Graphics.FromImage(_imagen)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        _x1cut = e.X
        _y1cut = e.Y
        _mousedown = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        _x2cut = e.X
        _y2cut = e.Y
        Dim cropPen = New Pen(Brushes.Red, 2)
        cropPen.DashStyle = Drawing2D.DashStyle.DashDot
        If (_mousedown) Then
            _graf = PictureBox1.CreateGraphics()
            _graf.DrawRectangle(cropPen,
                                New Rectangle(_x1cut, _y1cut, _x2cut - _x1cut, _x2cut - _x1cut))
            PictureBox1.Refresh()
        End If

    End Sub

    Private Sub EditPicture_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.Image = _imagen
        PictureBox1.Size = PictureBox1.Image.Size
        Me.Size = PictureBox1.Size
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        _mousedown = False
        Dim _width, _height As Integer

        _width = _x2cut - _x1cut
        _height = _y2cut - _y1cut

        If (_width > 1 Or _height > 1) Then
            Dim Image As New Bitmap(PictureBox1.Image, PictureBox1.Image.Width, PictureBox1.Image.Height)
            Dim cropImage As New Bitmap(_width, _height)
            Dim grp = Graphics.FromImage(cropImage)
            grp.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            grp.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            grp.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            grp.DrawImage(Image, 0, 0,
                            New Rectangle(_x1cut, _y1cut, _width, _height), GraphicsUnit.Pixel)

            PictureBox1.Image = cropImage
            _imagen = cropImage
        End If

    End Sub

    Private Sub PictureBox1_Resize(sender As Object, e As EventArgs) Handles PictureBox1.Resize
        'If Not (PictureBox1.Image Is Nothing) Then
        '    PictureBox1.Size = PictureBox1.Image.Size
        '    Me.Size = PictureBox1.Size
        'End If
    End Sub
End Class