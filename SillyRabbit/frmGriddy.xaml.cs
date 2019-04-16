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
    /// Interaction logic for frmGriddy.xaml
    /// </summary>
    public partial class frmGriddy : Window {
        public frmGriddy() {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid() {

            for (int i = 0; i < 8; i++) {
                grdMain.RowDefinitions.Add(new RowDefinition());
            }
            for (int j = 0; j < 10; j++) {
                grdMain.ColumnDefinitions.Add(new ColumnDefinition());
            }

            Random rnd = new Random();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 10; j++) {
                    string text = "btn";
                    int newDieRoll = rnd.Next(8);
                    if (newDieRoll == 1) text = "Big Thing";
                    else if (newDieRoll == 2) text = "Bigger Thing";
                    else if (newDieRoll > 5) text = "x";

                    Button b = new Button() {
                        Content = text
                    };
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    grdMain.Children.Add(b);
                }
            }
        }
    }
}
