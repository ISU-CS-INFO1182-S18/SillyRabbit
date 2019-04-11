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
    /// Interaction logic for frmMiddle.xaml
    /// </summary>
    public partial class frmMiddle : Window {
        public frmMiddle(bool isClosing) {
            InitializeComponent();
            //WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SetFormElementsVisibility(isClosing);
        }

        private void SetFormElementsVisibility(bool show) {
            if (show) {
                btnShutDown.Visibility =
                    tbShutdown.Visibility = Visibility.Collapsed;
                btnClose.Visibility =
                    tbClose.Visibility = Visibility.Visible;
            } else {
                btnShutDown.Visibility =
                     tbShutdown.Visibility = Visibility.Visible;
                btnClose.Visibility =
                    tbClose.Visibility = Visibility.Collapsed;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e) {
            this.Close();
            SetFormElementsVisibility(false);
        }

        private void BtnShutDown_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
