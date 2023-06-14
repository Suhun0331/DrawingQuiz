using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using socketProtocol_Library;


public class DrawingBoard
{
    private PictureBox drawPicture;
    private bool isDrag = false;
    private Point previousPoint;
    private int setTool = 0;
    private int setColor = 0;
    private int prevTool = 0;
    private bool eraser = false;
    private Pen currentPen;
    private Bitmap bitmap;
    private Graphics g;

    public DrawingBoard(PictureBox pictureBox)
    {
        drawPicture = pictureBox;
        bitmap = new Bitmap(drawPicture.Width, drawPicture.Height);
        g = Graphics.FromImage(bitmap);
        g.Clear(Color.White);
        drawPicture.Image = bitmap;
    }

    public void SetPenWidth(int width)
    {
        setTool = width;
    }

    public void SetPenColor(int color)
    {
        setColor = color;
    }

    public void MouseDown(MouseEventArgs e)
    {
        isDrag = true;
        previousPoint = new Point(e.X, e.Y);
    }

    public void MouseUp(MouseEventArgs e)
    {
        isDrag = false;
    }

    public void MouseMove(MouseEventArgs e)
    {
        if (isDrag)
        {
            Point currentPoint = new Point(e.X, e.Y);

            Color[] colors = new Color[] { Color.Black, Color.Red, Color.Orange, Color.Yellow,
                Color.Green, Color.Blue, Color.Navy, Color.Purple, Color.White};

            int[] penWidths = new int[] { 1, 1, 3, 5, 10 };

            currentPen = new Pen(colors[setColor]);
            currentPen.Width = penWidths[setTool];

            g.DrawLine(currentPen, previousPoint, currentPoint);
            previousPoint = currentPoint;
            drawPicture.Image = bitmap;
        }
    }

    public void ResetCanvas()
    {
        g.Clear(Color.White);
        drawPicture.Image = bitmap;
    }

    public void SaveImage(string path)
    {
        bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
    }

    public void ChangeToEraser()
    {
        prevTool = setTool;
        eraser = true;
        setColor = 8;
        setTool = 4;
    }

    public void ClearDrawing()
    {
        g.Clear(Color.White);
    }

    public void SendPicture(TcpClient clientSocket, NetworkStream stream, int client_number)
    {
        byte[] sendBuffer = new byte[1024 * 4];
        //////////////////////////////   그림 파일 정보 전송   //////////////////////////////
        ClientDrawingInfo drawInfo = new ClientDrawingInfo();
        drawInfo.Type = (int)PacketType.그림정보;
        drawInfo.clientNum = client_number;
        Packet.Serialize(drawInfo).CopyTo(sendBuffer, 0);
        stream.Write(sendBuffer, 0, sendBuffer.Length);
        stream.Flush();
        //////////////////////////////   그림 파일 전송   //////////////////////////////
        ClientDrawing draw = new ClientDrawing();
        FileInfo file = new FileInfo(Environment.CurrentDirectory + "\\UserImage\\" + client_number + "Turn.jpg");
        FileStream fileStrm = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(fileStrm);

        int count = (int)(file.Length) / (1024) + 1;

        for (int i = 0; i < count; i++)
        {
            draw.buffer = reader.ReadBytes(1024);
            draw.count = count;
            draw.Type = (int)PacketType.그림;
            draw.clientNum = client_number;
            Packet.Serialize(draw).CopyTo(sendBuffer, 0);
            stream.Write(sendBuffer, 0, sendBuffer.Length);
            stream.Flush();
            resetBuffer(sendBuffer);
        }

        fileStrm.Close();
    }
    public void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

    // 그림판 객체 반환
    public Bitmap GetBitmap()
    {
        return bitmap;
    }

    // 그림판 Graphics 객체 반환
    public Graphics GetGraphics()
    {
        return g;
    }


}
