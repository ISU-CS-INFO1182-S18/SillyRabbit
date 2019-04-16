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
        SuperHero _MyDude;
        public MainWindow() {
            InitializeComponent();
            //btnNewButton.Style = (Style)App.Current.Resources["styButton"];
            ResizeMode = ResizeMode.NoResize;

            imgCat.Source = new BitmapImage(new Uri(@"..\..\images\kittens.jpg",UriKind.Relative));

        }

        private void BtnSerialize_Click(object sender, RoutedEventArgs e) {
            //SuperHero sup = new SuperHero("Super", "Man");
             _MyDude = new SuperHero("Super", "Man");

            FileStream fs = null;
            try {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "TRIX Files|*.trix";
                if (sfd.ShowDialog() == true) {
                    // got a file name correctly.
                    BinaryFormatter bf = new BinaryFormatter();
                    fs = new FileStream(sfd.FileName, FileMode.Create);
                    bf.Serialize(fs, _MyDude);
                } else {
                    // error getting file.
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                if (fs != null) fs.Close();
            }


        }

        private void BtnDeSerialize_Click(object sender, RoutedEventArgs e) {
            System.IO.FileStream fs = null;
            try {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TRIX Files|*.trix|All Files(*.*)|*.*";

                if (ofd.ShowDialog() == true) {
                    // got our file.
                    //File.ReadAllLines(ofd.FileName);
                    fs = File.Open(ofd.FileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    //SuperHero o = (SuperHero)bf.Deserialize(fs);
                    _MyDude = (SuperHero)bf.Deserialize(fs); 
                    tbOutput.Text = _MyDude.FullName;

                } else {
                    //nope.

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                if (fs != null) fs.Close();
            }
        }
    }
}
