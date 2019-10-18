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
using System.Windows.Shapes;

namespace WPF_Project_WSEI
{
    /// <summary>
    /// Interaction logic for EoTM_Certificate.xaml
    /// </summary>
    public partial class EoTM_Certificate : Window
    {
        public EoTM_Certificate()
        {
            InitializeComponent();
        }
        protected void Window3Button_Click(object sender, RoutedEventArgs e)
        {
            Button btnSender = (Button)sender;
            if (btnSender.Name == "MaximizeButton")
            {
                if (this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized;
                else
                    this.WindowState = WindowState.Normal;
            }
            else if (btnSender.Name == "MinimizeButton")
                this.WindowState = WindowState.Minimized;
            else if (btnSender.Name == "TurnOffButton")
                this.Close();
        }
        protected void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
