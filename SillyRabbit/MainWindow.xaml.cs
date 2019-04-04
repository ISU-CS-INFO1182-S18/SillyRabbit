using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using MyObjects;
using System.IO;
using Microsoft.Win32;

namespace SillyRabbit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void BtnSerialize_Click(object sender, RoutedEventArgs e) {
            SuperHero sup = new SuperHero("Super", "Man");

            FileStream fs = null;
            try {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "TRIX Files|*.trix";
                if (sfd.ShowDialog() == true) {
                    // got a file name correctly.
                    BinaryFormatter bf = new BinaryFormatter();
                    fs = new FileStream(sfd.FileName, FileMode.Create);
                    bf.Serialize(fs, sup);
                } else {
                    // error getting file.
                }
            } catch (Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                if (fs != null) fs.Close();
            }


        }
    }
}
