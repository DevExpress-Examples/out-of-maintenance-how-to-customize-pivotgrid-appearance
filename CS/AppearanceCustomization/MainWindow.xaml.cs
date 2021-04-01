using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace AppearanceCustomization {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(OnLoaded);
        }
        void OnLoaded(object sender, RoutedEventArgs e) {
            DataTable table = new DataTable();
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Rows.Add("Category", "Coffee", 2019, 1);
            table.Rows.Add("Category", "Coffee", 2020, 7);
            table.Rows.Add("Category", "Coffee", 2021, 4);
            table.Rows.Add("Category", "Juice", 2019, 4);
            table.Rows.Add("Category", "Juice", 2020, 20);
            table.Rows.Add("Category", "Juice", 2021, 2);
            table.Rows.Add("Category", "Tea", 2019, 9);
            table.Rows.Add("Category", "Tea", 2020, 8);
            table.Rows.Add("Category", "Tea", 2021, 12);
            pivotGrid.DataSource = table;
        }
    }
}
