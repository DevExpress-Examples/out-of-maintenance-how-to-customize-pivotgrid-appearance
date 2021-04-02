Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Data
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace AppearanceCustomization
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf OnLoaded
        End Sub
        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim table As New DataTable()
            table.Columns.Add("Category", GetType(String))
            table.Columns.Add("Product", GetType(String))
            table.Columns.Add("Year", GetType(Integer))
            table.Columns.Add("Quantity", GetType(Integer))
            table.Rows.Add("Category", "Coffee", 2019, 1)
            table.Rows.Add("Category", "Coffee", 2020, 7)
            table.Rows.Add("Category", "Coffee", 2021, 4)
            table.Rows.Add("Category", "Juice", 2019, 4)
            table.Rows.Add("Category", "Juice", 2020, 20)
            table.Rows.Add("Category", "Juice", 2021, 2)
            table.Rows.Add("Category", "Tea", 2019, 9)
            table.Rows.Add("Category", "Tea", 2020, 8)
            table.Rows.Add("Category", "Tea", 2021, 12)
            pivotGrid.DataSource = table
        End Sub
    End Class
End Namespace
