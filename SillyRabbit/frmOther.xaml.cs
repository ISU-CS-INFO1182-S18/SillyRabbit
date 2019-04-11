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

namespace SillyRabbit {
    /// <summary>
    /// Interaction logic for frmOther.xaml
    /// </summary>
    public partial class frmOther : Window {
        public frmOther() {
            InitializeComponent();
        }

        private void BtnShowMain_Click(object sender, RoutedEventArgs e) {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
            //Application.Current.Shutdown();
        }

        private void BtnLoadMiddle_Click(object sender, RoutedEventArgs e) {
            frmMiddle frm = new frmMiddle(true);
            frm.ShowDialog();
        }

        private void BtnLoadMiddleOut_Click(object sender, RoutedEventArgs e) {
            frmMiddle frm = new frmMiddle(false);
            frm.ShowDialog();
        }
    }
}
