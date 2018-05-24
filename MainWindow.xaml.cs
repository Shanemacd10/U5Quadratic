using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U5Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  
        int a;
        int b;
        int c;
        public MainWindow()
        {
            InitializeComponent();

            Line line = new Line();
            line.StrokeThickness = 1;
            line.Stroke = Brushes.Black;
            line.X1 = 325;
            line.X2 = 325;
            line.Y1 = 50;
            line.Y2 = 450;
            canvas.Children.Add(line);

            Line line2 = new Line();
            line2.StrokeThickness = 1;
            line2.Stroke = Brushes.Black;
            line2.X1 = 125;
            line2.X2 = 525;
            line2.Y1 = 250;
            line2.Y2 = 250;
            canvas.Children.Add(line2);
        }
      

        public void btnRun_Click(object sender, RoutedEventArgs e)
        {
            
            a = Convert.ToInt32(txtA.Text);
             b = Convert.ToInt32(txtB.Text);
             c = Convert.ToInt32(txtC.Text);
            if (Convert.ToDouble((b * b) - (4 * a * c)) < 0)
            {
                lblOutput.Content = "No zeros";
            }
            else if(Convert.ToDouble((b * b) - (4 * a * c)) == 0)
                {
                double output1 = ((-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));
                lblOutput.Content = output1.ToString();
            }
            else
            {
                double output1 = ((-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));
                double output2 = ((-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));
                lblOutput.Content = output1.ToString() + "\n" +"\r" + output2.ToString();
            }
            for(int i = -1000; i < 1000; i++)
            {
                generateDot(i);
            }
            
        }
        public void generateDot(int x)
        {
            Ellipse ellipsex = new Ellipse();
            ellipsex.Width = 3;
            ellipsex.Height = 3;
            ellipsex.Fill = Brushes.Black;
            Canvas.SetLeft(ellipsex, (x*0.01)*10 + 325);
            Canvas.SetTop(ellipsex, (250 - (((x*0.01*x*0.01)*a + x*0.01*b + c)*10) ));
            canvas.Children.Add(ellipsex);
        }
        
    }
}
