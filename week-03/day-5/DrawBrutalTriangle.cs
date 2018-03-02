using System.Windows;
using System.Windows.Media;

namespace TestTriangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Black);
            int level = 8; 
            Point topPoint = new Point(canvas.Width / 2, 0);
            Point leftPoint = new Point(0, canvas.Height);
            Point rightPoint = new Point(canvas.Width, canvas.Height);

            Point[] point = new Point[3] {topPoint,leftPoint,rightPoint };
            
            
            
           

            DrawBrutalTriangle(foxDraw, level, topPoint, leftPoint, rightPoint);
        }
        public void DrawBrutalTriangle(FoxDraw foxDraw, int level, Point topPoint, Point leftPoint, Point rightPoint)
        {
            if (level == 0)
            {
                Point[] points = { topPoint, leftPoint, rightPoint };
                foxDraw.DrawPolygon(points,Brushes.Black);
                
            }
            else
            {
                Point leftMid = new Point(
                                (topPoint.X + leftPoint.X) / 2f,
                                (topPoint.Y + leftPoint.Y) / 2f);
                Point rightMid = new Point(
                                (topPoint.X + rightPoint.X) / 2f,
                                (topPoint.Y + rightPoint.Y) / 2f);
                Point bottomMid = new Point(
                                (leftPoint.X + rightPoint.X) / 2f,
                                (leftPoint.Y + rightPoint.Y) / 2f);

                DrawBrutalTriangle(foxDraw, level - 1, topPoint, leftMid, rightMid);
                DrawBrutalTriangle(foxDraw, level - 1, leftMid, leftPoint, bottomMid);
                DrawBrutalTriangle(foxDraw, level - 1, rightMid, bottomMid, rightPoint);
            }
        }
    }
}
