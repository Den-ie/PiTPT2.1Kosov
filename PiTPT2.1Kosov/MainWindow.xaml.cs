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

namespace PiTPT2._1Kosov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height = +25;
        }

        private void Answering(object sender, RoutedEventArgs e)
        {
            int fX1 = Convert.ToInt32(FirstX1.Text);
            int fX2 = Convert.ToInt32(FirstX2.Text);
            int fY1 = Convert.ToInt32(FirstY1.Text);
            int fY2 = Convert.ToInt32(FirstY2.Text);
            int fZ1 = Convert.ToInt32(FirstZ1.Text);
            int fZ2 = Convert.ToInt32(FirstZ2.Text);

            int sX1 = Convert.ToInt32(SecondX1.Text);
            int sX2 = Convert.ToInt32(SecondX2.Text);
            int sY1 = Convert.ToInt32(SecondY1.Text);
            int sY2 = Convert.ToInt32(SecondY2.Text);
            int sZ1 = Convert.ToInt32(SecondZ1.Text);
            int sZ2 = Convert.ToInt32(SecondZ2.Text);


            int L1 = fX2 - fX1;
            int M1 = fY2 - fY1;
            int N1 = fZ2 - fZ1;
            
            int L2 = sX2 - sX1;
            int M2 = sY2 - sY1;
            int N2 = sZ2 - sZ1;

            bool Parall;
            if (L1 / L2 == M1 / M2 && M1 / M2 == N1 / N2)
                Parall = true;
            else Parall = false;

            MessageBox.Show(Parall.ToString());
        }
    }
}
