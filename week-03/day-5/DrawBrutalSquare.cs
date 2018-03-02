using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace MindUck
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var foxDraw = new FoxDraw(canvas);

            const float margin = 10;
            Rect rect = new Rect(
                margin, margin,
                canvas.Width - 2 * margin,
                canvas.Height - 2 * margin);

            int level = 4;

            DrawBrutalSquare(foxDraw,level,rect);
           
        }
        public void DrawBrutalSquare(FoxDraw foxDraw, int level, Rect rect)
        {
            Random rnd = new Random();

            if (level == 0)
            {
                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(255), (byte)rnd.Next(255), (byte)rnd.Next(255)));
                foxDraw.DrawRectangle(rect.X,rect.Y,rect.Width,rect.Height); 
            }
            else
            {
                float width = (float)rect.Width / 3f;
                float x0 = (float)rect.Left;
                float x1 = x0 + width;
                float x2 = x0 + width * 2f;

                float height = (float)rect.Height / 3f;
                float y0 = (float)rect.Top;
                float y1 = y0 + height;
                float y2 = y0 + height * 2f;

                DrawBrutalSquare(foxDraw, level - 1, new Rect(x0, y0, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x1, y0, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x2, y0, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x0, y1, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x2, y1, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x0, y2, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x1, y2, width, height));
                DrawBrutalSquare(foxDraw, level - 1, new Rect(x2, y2, width, height));
            }
        }
    }
}
