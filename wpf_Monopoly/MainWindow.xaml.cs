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

namespace wpf_Monopoly {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid1.MouseLeftButtonUp += new MouseButtonEventHandler(grid1_MouseLeftButtonUp);       
        }

        private void grid1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            MessageBox.Show("Geklickt! " + e.GetPosition(this).ToString());
        }

       
    }
}
